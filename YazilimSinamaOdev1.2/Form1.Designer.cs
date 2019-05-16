namespace YazilimSinamaOdev1._2
{
    partial class frmBaslangic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaslangic));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTekKisi = new System.Windows.Forms.Button();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.btnPlayXOX = new System.Windows.Forms.Button();
            this.btnIki_Kisi = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAyniNet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(66, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(204, 31);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Oyun Seçenekleri";
            // 
            // btnTekKisi
            // 
            this.btnTekKisi.BackColor = System.Drawing.Color.White;
            this.btnTekKisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTekKisi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTekKisi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTekKisi.Location = new System.Drawing.Point(2, 94);
            this.btnTekKisi.Name = "btnTekKisi";
            this.btnTekKisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTekKisi.Size = new System.Drawing.Size(207, 32);
            this.btnTekKisi.TabIndex = 6;
            this.btnTekKisi.Text = "Tek Kişi (Bilgisayara Karşı)";
            this.btnTekKisi.UseVisualStyleBackColor = false;
            this.btnTekKisi.Click += new System.EventHandler(this.btnTekKisi_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(246, 131);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(87, 20);
            this.txtPlayer1.TabIndex = 8;
            this.txtPlayer1.Visible = false;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(246, 192);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(87, 20);
            this.txtPlayer2.TabIndex = 9;
            this.txtPlayer2.Visible = false;
            // 
            // btnPlayXOX
            // 
            this.btnPlayXOX.BackColor = System.Drawing.Color.White;
            this.btnPlayXOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlayXOX.ForeColor = System.Drawing.Color.Maroon;
            this.btnPlayXOX.Location = new System.Drawing.Point(246, 247);
            this.btnPlayXOX.Name = "btnPlayXOX";
            this.btnPlayXOX.Size = new System.Drawing.Size(87, 61);
            this.btnPlayXOX.TabIndex = 10;
            this.btnPlayXOX.Text = "PLAY";
            this.btnPlayXOX.UseVisualStyleBackColor = false;
            this.btnPlayXOX.Click += new System.EventHandler(this.btnPlayXOX_Click);
            // 
            // btnIki_Kisi
            // 
            this.btnIki_Kisi.BackColor = System.Drawing.Color.White;
            this.btnIki_Kisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIki_Kisi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIki_Kisi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnIki_Kisi.Location = new System.Drawing.Point(2, 157);
            this.btnIki_Kisi.Name = "btnIki_Kisi";
            this.btnIki_Kisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIki_Kisi.Size = new System.Drawing.Size(207, 31);
            this.btnIki_Kisi.TabIndex = 11;
            this.btnIki_Kisi.Text = "İki Kişi ";
            this.btnIki_Kisi.UseVisualStyleBackColor = false;
            this.btnIki_Kisi.Click += new System.EventHandler(this.btnIki_Kisi_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(292, 10);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(56, 19);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(192, 9);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(36, 20);
            this.txtPort.TabIndex = 16;
            this.txtPort.Text = "8910";
            this.txtPort.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Port:";
            this.label2.Visible = false;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(79, 10);
            this.txtHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(76, 20);
            this.txtHost.TabIndex = 14;
            this.txtHost.Text = "192.168.1.103";
            this.txtHost.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Host:";
            this.label1.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(232, 10);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 19);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnAyniNet
            // 
            this.btnAyniNet.BackColor = System.Drawing.Color.White;
            this.btnAyniNet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyniNet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAyniNet.Location = new System.Drawing.Point(2, 221);
            this.btnAyniNet.Margin = new System.Windows.Forms.Padding(2);
            this.btnAyniNet.Name = "btnAyniNet";
            this.btnAyniNet.Size = new System.Drawing.Size(207, 30);
            this.btnAyniNet.TabIndex = 18;
            this.btnAyniNet.Text = "İki Kişi Aynı Network";
            this.btnAyniNet.UseVisualStyleBackColor = false;
            this.btnAyniNet.Click += new System.EventHandler(this.btnAyniNet_Click);
            // 
            // frmBaslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(358, 349);
            this.Controls.Add(this.btnAyniNet);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnIki_Kisi);
            this.Controls.Add(this.btnPlayXOX);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.btnTekKisi);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "frmBaslangic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X O X ";
            this.Load += new System.EventHandler(this.frmBaslangic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnTekKisi;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Button btnPlayXOX;
        private System.Windows.Forms.Button btnIki_Kisi;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAyniNet;
    }
}

