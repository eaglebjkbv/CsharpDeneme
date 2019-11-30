namespace ModBusTCPClient
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
            this.textBoxIpAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBaglan = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBaglantiDurum = new System.Windows.Forms.Label();
            this.textBoxKomut = new System.Windows.Forms.TextBox();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIpAdres
            // 
            this.textBoxIpAdres.Location = new System.Drawing.Point(35, 54);
            this.textBoxIpAdres.Name = "textBoxIpAdres";
            this.textBoxIpAdres.Size = new System.Drawing.Size(100, 20);
            this.textBoxIpAdres.TabIndex = 0;
            this.textBoxIpAdres.Text = "192.168.22.102";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ip Adres";
            // 
            // buttonBaglan
            // 
            this.buttonBaglan.Location = new System.Drawing.Point(203, 54);
            this.buttonBaglan.Name = "buttonBaglan";
            this.buttonBaglan.Size = new System.Drawing.Size(75, 23);
            this.buttonBaglan.TabIndex = 2;
            this.buttonBaglan.Text = "Bağlan";
            this.buttonBaglan.UseVisualStyleBackColor = true;
            this.buttonBaglan.Click += new System.EventHandler(this.buttonBaglan_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(141, 54);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(47, 20);
            this.textBoxPort.TabIndex = 0;
            this.textBoxPort.Text = "502";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // labelBaglantiDurum
            // 
            this.labelBaglantiDurum.AutoSize = true;
            this.labelBaglantiDurum.Location = new System.Drawing.Point(200, 35);
            this.labelBaglantiDurum.Name = "labelBaglantiDurum";
            this.labelBaglantiDurum.Size = new System.Drawing.Size(57, 13);
            this.labelBaglantiDurum.TabIndex = 1;
            this.labelBaglantiDurum.Text = "Bağlı Değil";
            // 
            // textBoxKomut
            // 
            this.textBoxKomut.Location = new System.Drawing.Point(38, 156);
            this.textBoxKomut.Name = "textBoxKomut";
            this.textBoxKomut.Size = new System.Drawing.Size(150, 20);
            this.textBoxKomut.TabIndex = 0;
            this.textBoxKomut.Text = "01060FAE0001";
            // 
            // buttonGonder
            // 
            this.buttonGonder.Location = new System.Drawing.Point(203, 153);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(75, 23);
            this.buttonGonder.TabIndex = 2;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Komut Frame";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bağlantı Kes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 337);
            this.Controls.Add(this.buttonGonder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBaglan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBaglantiDurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxKomut);
            this.Controls.Add(this.textBoxIpAdres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIpAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBaglan;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBaglantiDurum;
        private System.Windows.Forms.TextBox textBoxKomut;
        private System.Windows.Forms.Button buttonGonder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

