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

namespace filtragemParam
{
    public partial class MainForm : Form
    {

        bool receiving = false;
        List<Rule> rules = new List<Rule>(); //lista de regras adicionadas pelo usuário
        List<IED> ieds = new List<IED>(); //lista de IEDs encontradas
        ConcurrentQueue<PacoteIED> buffer = new ConcurrentQueue<PacoteIED> ();
        int NUM_THREAD; //número de threads, a princípio é single thread
        Mutex debugMutex = new Mutex ();
        


        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            NUM_THREAD = 1;

        }

        public void receiveUDPPacket()
        {
            try
            {
                Socket s = new Socket(SocketType.Dgram, ProtocolType.Udp);
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("10.15.79.136"), 12345);
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                EndPoint senderRemote = (EndPoint)sender;

                s.Bind(endPoint);


                //UdpClient usocketConexaoUDPModulo1 = new UdpClient(11666);
                byte[] bytesRecebidosModulo1 = new byte[256];
                //IPEndPoint ipConexaoRecebimentoUDPModulo1 = new IPEndPoint(IPAddress.Any, 11666);

                while (receiving)
                {
                    int i = s.ReceiveFrom(bytesRecebidosModulo1, ref senderRemote);
                    string receivedString = Encoding.ASCII.GetString(bytesRecebidosModulo1);
                    debugBox.Text = debugBox.Text + receivedString;
                    string[] subs = receivedString.Split('}');
                    string truncate = subs[0]+'}';
                    PacoteIED packet = JsonConvert.DeserializeObject<PacoteIED>(truncate);
                    if (packet != null) buffer.Enqueue(packet);
                    //debugBox.Text = debugBox.Text + packet + "\n";
                }
            }
            catch (Exception e)
            {
                showError(e.Message);
            }


            return;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            receiving = true;
            Thread t = new Thread(receiveUDPPacket);
            t.Start();

            Thread[] threads = new Thread[NUM_THREAD];

            for (int i = 0;i<NUM_THREAD;i++)
            {
                threads[i] = new Thread(new ThreadStart(analyzePackets));
                threads[i].Start();
            }

        }

        private void analyzePackets()
        {
            while(receiving)
            {                
                if (buffer.IsEmpty)
                {
                    Thread.Sleep(20);
                } else
                {
                    PacoteIED packet = new PacoteIED();
                    if (buffer.TryDequeue(out packet))
                    {
                        debugBox.Text = debugBox.Text + "\n" + packet;
                        for (int r = 0; r < rules.Count; r++)
                        {
                            Rule rule = rules[r];


                            if (rule.checkEvent(packet))
                            {
                                debugBox.Text = debugBox.Text + "ativou regra: " + rule;
                                //debugBox.Text = debugBox.Text + rule.checkEvent(packet) + "\n";
                                //debugMutex.WaitOne();
                                //debugBox.Text = debugBox.Text + packet + "\n";
                                //debugBox.Text = debugBox.Text + rule + "\n";
                                //debugBox.Text = r.ToString();
                                //debugMutex.ReleaseMutex();
                            }
                        }
                    }
                }
                
            }
        }

        private void ruleList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void addRuleButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                Rule r = new Rule(selectN.Text, selectOp.Text, (int)numValor.Value);
                rules.Add(r);
                ruleList.Items.Add(r.ToString());
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
    }
}
