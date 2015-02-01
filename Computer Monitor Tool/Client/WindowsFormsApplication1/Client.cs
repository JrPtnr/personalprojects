using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using TCPCamActivex;
using System.Threading;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    class Client
    {
        private string ipAddress;
        private int portNumber;
        private TcpClient client;
        private byte[] data = new byte[1024];
        private int size = 1024;
        private NetworkStream clientStream;
        private PictureBox picBox;

        public Client(string ipAddress, string portNumber, PictureBox picBox)
        {
            int port = Convert.ToInt32(portNumber);

            this.ipAddress = ipAddress;
            this.portNumber = port;
            this.picBox = picBox;
            StartConnection();
        }

        private void StartConnection()
        {
            client = new TcpClient();

            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), portNumber);

            client.Connect(serverEndPoint);

            clientStream = client.GetStream();

            Thread serverThread = new Thread(HandleServerComm);
            serverThread.Start();
            
        }

        public void EndConnection()
        {
            client.Close();
        }

        public void SendMessage(string msg)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(msg);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
        }
        
        public void StartLiveFeed()
        {
            SendMessage("Live");
        }

        private void HandleServerComm()
        {
            //Image image = Image.FromStream(clientStream);
            //picBox.Image = image;
            while (true)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Image img = (Image)formatter.Deserialize(clientStream);
                Image newImg = (Image)new Bitmap(img, picBox.Size);
                picBox.Image = newImg;
            }
                //Image recievedImage = Image.FromStream(clientStream);
                //picBox.Image = recievedImage;
           
           
        }
    }
}
