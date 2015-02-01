using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Server
{
    public partial class Form1 : Form
    {
        private ServerSN server;

        public Form1()
        {
            InitializeComponent();
        }

        //Create the new server and start listening for connections when the program loads
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new ServerSN(cameraBackgroundWorker, pictureBox1);
            //tcpClientActivex1.StartListening();
        }
        #region Aux Methods

        //Hides the server window and makes it unaccessible 
        private void HideWindow()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(0, 0);
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.Hide(); 
        }
        #endregion

        private void cameraBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while(!cameraBackgroundWorker.CancellationPending)
            {
                server.Stream();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server.Test();
        }

    }
}
