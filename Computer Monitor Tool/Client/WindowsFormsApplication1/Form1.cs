using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private Client client;

        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            client = new Client(ipAddressText.Text, portNumberText.Text, videoBox);
            disconnectButton.Enabled = true;
            connectButton.Enabled = false;
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {

            client.EndConnection();
            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            sendMsgButton.Enabled = false;
        }

        private void ipAddressText_TextChanged(object sender, EventArgs e)
        {
            if(ipAddressText.Text == "" || portNumberText.Text == "")
            {
                connectButton.Enabled = false;
            }
            else
            {
                connectButton.Enabled = true;
            }
        }

        private void portNumberText_TextChanged(object sender, EventArgs e)
        {
            if (ipAddressText.Text == "" || portNumberText.Text == "")
            {
                connectButton.Enabled = false;
            }
            else
            {
                connectButton.Enabled = true;
            }
        }

        private void sendMsgButton_Click(object sender, EventArgs e)
        {
            client.SendMessage("Msg" + messageBox.Text);
        }

        private void liveFeedButton_Click(object sender, EventArgs e)
        {
            client.StartLiveFeed();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while(false)
            {
                System.Diagnostics.Debug.WriteLine("Testing");
            }
        }

        private void screenCapButton_Click(object sender, EventArgs e)
        {
            client.SendMessage("ScreenCap");
        }

        
    }
}
