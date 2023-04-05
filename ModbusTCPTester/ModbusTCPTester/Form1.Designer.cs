namespace ModbusTCPTester
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxTraId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUnitNr = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxFuncCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSendCmd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(21, 37);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 23);
            this.textBoxIP.TabIndex = 0;
            this.textBoxIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(142, 37);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(45, 23);
            this.textBoxPort.TabIndex = 0;
            this.textBoxPort.Text = "502";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port Number";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(224, 37);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(305, 37);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(21, 77);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(84, 15);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Status : Offline";
            // 
            // textBoxTraId
            // 
            this.textBoxTraId.Location = new System.Drawing.Point(9, 52);
            this.textBoxTraId.Name = "textBoxTraId";
            this.textBoxTraId.Size = new System.Drawing.Size(34, 23);
            this.textBoxTraId.TabIndex = 0;
            this.textBoxTraId.Text = "0001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tra.Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pro.Id";
            // 
            // textBoxProId
            // 
            this.textBoxProId.Location = new System.Drawing.Point(53, 52);
            this.textBoxProId.Name = "textBoxProId";
            this.textBoxProId.Size = new System.Drawing.Size(34, 23);
            this.textBoxProId.TabIndex = 0;
            this.textBoxProId.Text = "0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Length";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(97, 52);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(34, 23);
            this.textBoxLength.TabIndex = 0;
            this.textBoxLength.Text = "0006";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Unit Nr.";
            // 
            // textBoxUnitNr
            // 
            this.textBoxUnitNr.Location = new System.Drawing.Point(141, 52);
            this.textBoxUnitNr.Name = "textBoxUnitNr";
            this.textBoxUnitNr.Size = new System.Drawing.Size(46, 23);
            this.textBoxUnitNr.TabIndex = 0;
            this.textBoxUnitNr.Text = "01";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTraId);
            this.groupBox1.Controls.Add(this.textBoxProId);
            this.groupBox1.Controls.Add(this.textBoxLength);
            this.groupBox1.Controls.Add(this.textBoxUnitNr);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MBAP Header";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxData);
            this.groupBox2.Controls.Add(this.textBoxFuncCode);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(215, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 86);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PDU";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(81, 52);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(113, 23);
            this.textBoxData.TabIndex = 5;
            this.textBoxData.Text = "20000002";
            // 
            // textBoxFuncCode
            // 
            this.textBoxFuncCode.Location = new System.Drawing.Point(6, 52);
            this.textBoxFuncCode.Name = "textBoxFuncCode";
            this.textBoxFuncCode.Size = new System.Drawing.Size(46, 23);
            this.textBoxFuncCode.TabIndex = 5;
            this.textBoxFuncCode.Text = "06";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Func Code";
            // 
            // buttonSendCmd
            // 
            this.buttonSendCmd.Location = new System.Drawing.Point(12, 204);
            this.buttonSendCmd.Name = "buttonSendCmd";
            this.buttonSendCmd.Size = new System.Drawing.Size(403, 37);
            this.buttonSendCmd.TabIndex = 5;
            this.buttonSendCmd.Text = "Send Command";
            this.buttonSendCmd.UseVisualStyleBackColor = true;
            this.buttonSendCmd.Click += new System.EventHandler(this.buttonSendCmd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxIP);
            this.groupBox3.Controls.Add(this.textBoxPort);
            this.groupBox3.Controls.Add(this.labelStatus);
            this.groupBox3.Controls.Add(this.buttonDisconnect);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.buttonConnect);
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connection";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 247);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(403, 260);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 528);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonSendCmd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Modbus Tcp Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBoxIP;
        private Label label1;
        private TextBox textBoxPort;
        private Label label2;
        private Button buttonConnect;
        private Button buttonDisconnect;
        private Label labelStatus;
        private TextBox textBoxTraId;
        private Label label4;
        private Label label5;
        private TextBox textBoxProId;
        private Label label6;
        private TextBox textBoxLength;
        private Label label7;
        private TextBox textBoxUnitNr;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxData;
        private TextBox textBoxFuncCode;
        private Label label9;
        private Label label8;
        private Button buttonSendCmd;
        private GroupBox groupBox3;
        private RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
    }
}