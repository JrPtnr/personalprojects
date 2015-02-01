namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipAddressText = new System.Windows.Forms.TextBox();
            this.portNumberText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.controlsGroup = new System.Windows.Forms.GroupBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.keyLoggerButton = new System.Windows.Forms.Button();
            this.liveFeedButton = new System.Windows.Forms.Button();
            this.screenCapButton = new System.Windows.Forms.Button();
            this.sendMsgButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.videoBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.controlsGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(47, 129);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(90, 29);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port Number";
            // 
            // ipAddressText
            // 
            this.ipAddressText.Location = new System.Drawing.Point(125, 33);
            this.ipAddressText.Name = "ipAddressText";
            this.ipAddressText.Size = new System.Drawing.Size(138, 22);
            this.ipAddressText.TabIndex = 3;
            this.ipAddressText.TextChanged += new System.EventHandler(this.ipAddressText_TextChanged);
            // 
            // portNumberText
            // 
            this.portNumberText.Location = new System.Drawing.Point(125, 76);
            this.portNumberText.Name = "portNumberText";
            this.portNumberText.Size = new System.Drawing.Size(138, 22);
            this.portNumberText.TabIndex = 4;
            this.portNumberText.TextChanged += new System.EventHandler(this.portNumberText_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disconnectButton);
            this.groupBox1.Controls.Add(this.ipAddressText);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.portNumberText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 178);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(148, 129);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(90, 29);
            this.disconnectButton.TabIndex = 5;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // controlsGroup
            // 
            this.controlsGroup.Controls.Add(this.messageBox);
            this.controlsGroup.Controls.Add(this.keyLoggerButton);
            this.controlsGroup.Controls.Add(this.liveFeedButton);
            this.controlsGroup.Controls.Add(this.screenCapButton);
            this.controlsGroup.Controls.Add(this.sendMsgButton);
            this.controlsGroup.Location = new System.Drawing.Point(293, 12);
            this.controlsGroup.Name = "controlsGroup";
            this.controlsGroup.Size = new System.Drawing.Size(588, 178);
            this.controlsGroup.TabIndex = 6;
            this.controlsGroup.TabStop = false;
            this.controlsGroup.Text = "Controls";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(6, 56);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(576, 22);
            this.messageBox.TabIndex = 4;
            // 
            // keyLoggerButton
            // 
            this.keyLoggerButton.Location = new System.Drawing.Point(233, 84);
            this.keyLoggerButton.Name = "keyLoggerButton";
            this.keyLoggerButton.Size = new System.Drawing.Size(113, 29);
            this.keyLoggerButton.TabIndex = 3;
            this.keyLoggerButton.Text = "Key Logger";
            this.keyLoggerButton.UseVisualStyleBackColor = true;
            // 
            // liveFeedButton
            // 
            this.liveFeedButton.Location = new System.Drawing.Point(469, 84);
            this.liveFeedButton.Name = "liveFeedButton";
            this.liveFeedButton.Size = new System.Drawing.Size(113, 29);
            this.liveFeedButton.TabIndex = 2;
            this.liveFeedButton.Text = "Live Feed";
            this.liveFeedButton.UseVisualStyleBackColor = true;
            this.liveFeedButton.Click += new System.EventHandler(this.liveFeedButton_Click);
            // 
            // screenCapButton
            // 
            this.screenCapButton.Location = new System.Drawing.Point(6, 84);
            this.screenCapButton.Name = "screenCapButton";
            this.screenCapButton.Size = new System.Drawing.Size(113, 29);
            this.screenCapButton.TabIndex = 1;
            this.screenCapButton.Text = "Screen Cap";
            this.screenCapButton.UseVisualStyleBackColor = true;
            this.screenCapButton.Click += new System.EventHandler(this.screenCapButton_Click);
            // 
            // sendMsgButton
            // 
            this.sendMsgButton.Location = new System.Drawing.Point(6, 21);
            this.sendMsgButton.Name = "sendMsgButton";
            this.sendMsgButton.Size = new System.Drawing.Size(113, 29);
            this.sendMsgButton.TabIndex = 0;
            this.sendMsgButton.Text = "Send Message";
            this.sendMsgButton.UseVisualStyleBackColor = true;
            this.sendMsgButton.Click += new System.EventHandler(this.sendMsgButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.videoBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1201, 731);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Video/Screen Capture";
            // 
            // videoBox
            // 
            this.videoBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.videoBox.Location = new System.Drawing.Point(6, 21);
            this.videoBox.Name = "videoBox";
            this.videoBox.Size = new System.Drawing.Size(1189, 701);
            this.videoBox.TabIndex = 0;
            this.videoBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 951);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.controlsGroup);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SuperNova Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.controlsGroup.ResumeLayout(false);
            this.controlsGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipAddressText;
        private System.Windows.Forms.TextBox portNumberText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.GroupBox controlsGroup;
        private System.Windows.Forms.Button sendMsgButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox videoBox;
        private System.Windows.Forms.Button keyLoggerButton;
        private System.Windows.Forms.Button liveFeedButton;
        private System.Windows.Forms.Button screenCapButton;
        private System.Windows.Forms.TextBox messageBox;
    }
}

