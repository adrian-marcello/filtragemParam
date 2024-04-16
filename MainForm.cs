using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace filtragemParam
{
    public partial class MainForm : Form
    {

        bool receiving = false;
        List<Rule> rules = new List<Rule>();


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
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("192.168.15.3"), 12345);
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                EndPoint senderRemote = (EndPoint)sender;

                s.Bind(endPoint);


                //UdpClient usocketConexaoUDPModulo1 = new UdpClient(11666);
                byte[] bytesRecebidosModulo1 = new byte[256];
                //IPEndPoint ipConexaoRecebimentoUDPModulo1 = new IPEndPoint(IPAddress.Any, 11666);
                string menssagemRecebidaModulo1;
                while (receiving)
                {
                    int i = s.ReceiveFrom(bytesRecebidosModulo1, ref senderRemote);
                    menssagemRecebidaModulo1 = Encoding.ASCII.GetString(bytesRecebidosModulo1);

                    debugBox.Text = i + " bytes: " + menssagemRecebidaModulo1;
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
            Thread t = new Thread(receiveUDPPacket);
            t.Start();
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
                ruleList.Items.Add(r.texto);
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

        //private void teste()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        debugBox.Text = debugBox.Text + i + "==";
        //    }
        //}
    }
}
