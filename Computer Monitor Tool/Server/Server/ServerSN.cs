using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using MetriCam;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;  

namespace Server
{
    class ServerSN
    {
        private string ipAddress;
        private int portNumber;
        private TcpListener listener;
        private Thread listenThread;
        WebCam camera;
        NetworkStream clientStream;
        TcpClient tClient;
        BackgroundWorker cameraWorker;
        PictureBox pic; 

        public ServerSN(PictureBox picBox)
        {
            pic = picBox;
            this.listener = new TcpListener(IPAddress.Any, 3000);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
            camera = new WebCam();
        }

        public ServerSN(BackgroundWorker cameraWorker, PictureBox picBox)
        {
            pic = picBox;
            this.cameraWorker = cameraWorker;
            this.listener = new TcpListener(IPAddress.Any, 3000);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
        }

        private void ListenForClients()
        {
            this.listener.Start();

            while(true)
            {
                TcpClient client = this.listener.AcceptTcpClient();

                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object client)
        {
            tClient = (TcpClient)client;
            clientStream = tClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while(true)
            {
                bytesRead = 0;

                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    break;
                }

                if(bytesRead == 0)
                {
                    break;
                }

                ASCIIEncoding encode = new ASCIIEncoding();
                string msg = encode.GetString(message, 0, bytesRead);

                ProcessMessages(msg); 
                
            }

            tClient.Close();
        }

        private void ProcessMessages(string msg)
        {
            if (msg.StartsWith("Msg"))
                MessageBox.Show(msg.Substring(3, msg.Length - 3), "Messasge", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if(msg == "Live")
            {
                camera = new WebCam();
                if(!camera.IsConnected())
                {
                    camera.Connect();
                    cameraWorker.RunWorkerAsync();
                }
                else
                {
                    cameraWorker.CancelAsync();
                }
            }
            else if(msg == "ScreenCap")
            {
                ScreenCap(true);
            }
        }

        public void Stream()
        {
            camera.Update();
            Bitmap image = camera.CalcBitmap();
            System.Diagnostics.Debug.WriteLine("Sending Images");
            NetworkStream clientStream = tClient.GetStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(clientStream, image);
        }
        public void ScreenCap(bool loopBool)
        {
            NetworkStream clientStream = tClient.GetStream();
            BinaryFormatter formatter = new BinaryFormatter();
            while(loopBool)
            {
               using(Bitmap screenCap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
               {
                   using(Graphics g =  Graphics.FromImage(screenCap))
                   {
                       g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0,
                           screenCap.Size, CopyPixelOperation.SourceCopy);
                       formatter.Serialize(clientStream, screenCap);
                      
                   }
               }
            }
        }       
  
        public void Test()
        {
            NetworkStream clientStream = tClient.GetStream();
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes("Hello");

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
            
        }
    }
}
