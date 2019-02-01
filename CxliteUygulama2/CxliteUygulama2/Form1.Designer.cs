namespace CxliteUygulama2
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
            this.components = new System.ComponentModel.Container();
            this.cxsLiteCtrl1 = new CXSLite.CXSLiteCtrl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxPLC = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPoint = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAktifPoint = new System.Windows.Forms.TextBox();
            this.textBoxDeger = new System.Windows.Forms.TextBox();
            this.buttonDegerGetir = new System.Windows.Forms.Button();
            this.buttonDegerDurdur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cxsLiteCtrl1
            // 
            this.cxsLiteCtrl1.Devices = null;
            this.cxsLiteCtrl1.Location = new System.Drawing.Point(661, 28);
            this.cxsLiteCtrl1.Name = "cxsLiteCtrl1";
            this.cxsLiteCtrl1.Points = null;
            this.cxsLiteCtrl1.Size = new System.Drawing.Size(64, 64);
            this.cxsLiteCtrl1.TabIndex = 0;
            this.cxsLiteCtrl1.Text = "cxsLiteCtrl1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxPLC
            // 
            this.listBoxPLC.FormattingEnabled = true;
            this.listBoxPLC.Location = new System.Drawing.Point(24, 47);
            this.listBoxPLC.Name = "listBoxPLC";
            this.listBoxPLC.Size = new System.Drawing.Size(120, 95);
            this.listBoxPLC.TabIndex = 1;
            this.listBoxPLC.SelectedIndexChanged += new System.EventHandler(this.listBoxPLC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLC Listesi";
            // 
            // listBoxPoint
            // 
            this.listBoxPoint.FormattingEnabled = true;
            this.listBoxPoint.Location = new System.Drawing.Point(201, 47);
            this.listBoxPoint.Name = "listBoxPoint";
            this.listBoxPoint.Size = new System.Drawing.Size(120, 95);
            this.listBoxPoint.TabIndex = 1;
            this.listBoxPoint.SelectedIndexChanged += new System.EventHandler(this.listBoxPoint_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Point Listesi";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aktif Point : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Değeri  : ";
            // 
            // textBoxAktifPoint
            // 
            this.textBoxAktifPoint.Location = new System.Drawing.Point(439, 39);
            this.textBoxAktifPoint.Name = "textBoxAktifPoint";
            this.textBoxAktifPoint.Size = new System.Drawing.Size(100, 20);
            this.textBoxAktifPoint.TabIndex = 4;
            // 
            // textBoxDeger
            // 
            this.textBoxDeger.Location = new System.Drawing.Point(439, 65);
            this.textBoxDeger.Name = "textBoxDeger";
            this.textBoxDeger.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeger.TabIndex = 4;
            // 
            // buttonDegerGetir
            // 
            this.buttonDegerGetir.Location = new System.Drawing.Point(439, 91);
            this.buttonDegerGetir.Name = "buttonDegerGetir";
            this.buttonDegerGetir.Size = new System.Drawing.Size(134, 29);
            this.buttonDegerGetir.TabIndex = 5;
            this.buttonDegerGetir.Text = "Veri Almayı Başlat";
            this.buttonDegerGetir.UseVisualStyleBackColor = true;
            this.buttonDegerGetir.Click += new System.EventHandler(this.buttonDegerGetir_Click);
            // 
            // buttonDegerDurdur
            // 
            this.buttonDegerDurdur.Location = new System.Drawing.Point(439, 126);
            this.buttonDegerDurdur.Name = "buttonDegerDurdur";
            this.buttonDegerDurdur.Size = new System.Drawing.Size(134, 29);
            this.buttonDegerDurdur.TabIndex = 5;
            this.buttonDegerDurdur.Text = "Veri Almayı Durdur";
            this.buttonDegerDurdur.UseVisualStyleBackColor = true;
            this.buttonDegerDurdur.Click += new System.EventHandler(this.buttonDegerDurdur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 402);
            this.Controls.Add(this.buttonDegerDurdur);
            this.Controls.Add(this.buttonDegerGetir);
            this.Controls.Add(this.textBoxDeger);
            this.Controls.Add(this.textBoxAktifPoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPoint);
            this.Controls.Add(this.listBoxPLC);
            this.Controls.Add(this.cxsLiteCtrl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CXSLite.CXSLiteCtrl cxsLiteCtrl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxPLC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAktifPoint;
        private System.Windows.Forms.TextBox textBoxDeger;
        private System.Windows.Forms.Button buttonDegerGetir;
        private System.Windows.Forms.Button buttonDegerDurdur;
    }
}

