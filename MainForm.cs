using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.Data;
using System.Windows.Forms;

namespace filtragemParam
{
    public partial class MainForm : Form
    {

        bool receiving = false;
        List<Rule> rules = new List<Rule>(); //lista de regras adicionadas pelo usuário
        List<IED> ieds = new List<IED>(); //lista de IEDs encontradas
        Mutex mutexRules = new Mutex();
        Mutex mutexIEDs = new Mutex();
        Relatorio relatorio = new Relatorio(0, []);
        int idcount = 0;



        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        public void receiveUDPPacket()
        {
            try
            {
                Socket s = new Socket(SocketType.Dgram, ProtocolType.Udp);
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("192.168.15.11"), 12345);
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                EndPoint senderRemote = (EndPoint)sender;

                s.Bind(endPoint);
                receiving = true;

                //UdpClient usocketConexaoUDPModulo1 = new UdpClient(11666);
                byte[] bytes = new byte[256];
                //IPEndPoint ipConexaoRecebimentoUDPModulo1 = new IPEndPoint(IPAddress.Any, 11666);

                while (receiving)
                {
                    int i = s.ReceiveFrom(bytes, ref senderRemote);
                    string receivedString = Encoding.ASCII.GetString(bytes);
                    //debugBox.Text = debugBox.Text + receivedString;
                    string[] subs = receivedString.Split('}');
                    string truncate = subs[0] + '}';
                    PacoteIED packet = JsonConvert.DeserializeObject<PacoteIED>(truncate);

                    mutexRules.WaitOne();
                    for (int r = 0; r < rules.Count; r++)
                    {
                        rules[r].buffer.Enqueue(packet);
                    }
                    mutexRules.ReleaseMutex();


                }
                s.Close();
            }
            catch (Exception e)
            {
                showError(e.Message);
            }


            return;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(receiveUDPPacket);
            t.Start();

            for (int r = 0; r < rules.Count; r++)
            {
                Rule rule = rules[r];
                rule.running = true;
                Thread ruleThread = new Thread(new ThreadStart(rule.analyzePackets));
                ruleThread.Start();
            }
            timer.Enabled = true;
        }





        private void addRuleButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                mutexRules.WaitOne();
                idcount++;
                Rule r = new Rule(selectN.Text, selectOp.Text, (int)numValor.Value, mutexIEDs, ieds, idcount, debugBox);
                rules.Add(r);
                listViewRule.Items.Add(new ListViewItem(new String[] { r.id.ToString(), r.ToString() }));
                if (receiving)
                {
                    r.running = true;
                    Thread ruleThread = new Thread(new ThreadStart(r.analyzePackets));
                    ruleThread.Start();
                }
                mutexRules.ReleaseMutex();
            }

        }

        public bool validateForm()
        {
            //debugBox.Text = debugBox.Text + selectN.Text + "\n" + selectOp.Text + "\n" + numValor.Value;

            if (selectN.Text == "" || selectOp.Text == "")
            {
                showError("Por Favor, Preencha todos os campos antes de adicionar a regra");
                return false;
            }
            return true;
        }

        private void showError(string message)
        {
            MessageBox.Show(message, "ERRO");
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            receiving = false;
            for (int r = 0; r < rules.Count; r++)
            {
                rules[r].running = false;
            }
            timer.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Thread t = new Thread(sendReport);
            t.Start();
        }

        public void sendReport()
        {
            mutexIEDs.WaitOne();
            listBoxIED.BeginUpdate();
            listBoxIED.Items.Clear();


            int totalEvents = 0;
            for (int i = 0; i < ieds.Count; i++)
            {
                IED ied = ieds[i];
                totalEvents += ied.qtdEventos;
                listBoxIED.Items.Add("IED " + ied.id.ToString() + ": " + ied.qtdEventos.ToString());
            }
            listBoxIED.Items.Add("");
            listBoxIED.Items.Add("Total de eventos: " + totalEvents.ToString());

            relatorio.totalEvents = totalEvents;
            relatorio.events = ieds;
            string json = JsonConvert.SerializeObject(relatorio);
            debugBox.Text = json + '\n';

            listBoxIED.EndUpdate();
            mutexIEDs.ReleaseMutex();

            UdpClient udpClient = new UdpClient();
            Byte[] sendBytes = Encoding.ASCII.GetBytes(json);
            udpClient.Send(sendBytes, sendBytes.Length, "192.168.15.11", 11666);
        }

        private void cleanRulesButton_Click(object sender, EventArgs e)
        {
            mutexRules.WaitOne();
            for (int i = 0; i < rules.Count; i++)
            {
                rules[i].running = false;
            }
            rules.Clear();
            mutexRules.ReleaseMutex();
            listViewRule.Items.Clear();
        }
    }
}
