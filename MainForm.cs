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


        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            Thread t = new Thread(receiveUDPPacket);
            t.Start();
            //receiveUDPPacket();
        }

        public void receiveUDPPacket()
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
                int i = s.ReceiveFrom(bytesRecebidosModulo1,ref senderRemote);
                menssagemRecebidaModulo1 = Encoding.ASCII.GetString(bytesRecebidosModulo1);
                
                debugBox.Text = i + " bytes: " + menssagemRecebidaModulo1;
            }
            return;
        }

    }
}
