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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTekKisi = new System.Windows.Forms.Button();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.btnPlayXOX = new System.Windows.Forms.Button();
            this.btnIki_Kisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(43, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Oyun Seçenekleri";
            // 
            // btnTekKisi
            // 
            this.btnTekKisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTekKisi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTekKisi.Location = new System.Drawing.Point(43, 102);
            this.btnTekKisi.Name = "btnTekKisi";
            this.btnTekKisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTekKisi.Size = new System.Drawing.Size(160, 23);
            this.btnTekKisi.TabIndex = 6;
            this.btnTekKisi.Text = "Tek Kişi (Bilgisayara Karşı)";
            this.btnTekKisi.UseVisualStyleBackColor = true;
            this.btnTekKisi.Click += new System.EventHandler(this.btnTekKisi_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(248, 102);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer1.TabIndex = 8;
            this.txtPlayer1.Visible = false;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(248, 140);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer2.TabIndex = 9;
            this.txtPlayer2.Visible = false;
            // 
            // btnPlayXOX
            // 
            this.btnPlayXOX.Location = new System.Drawing.Point(248, 179);
            this.btnPlayXOX.Name = "btnPlayXOX";
            this.btnPlayXOX.Size = new System.Drawing.Size(100, 47);
            this.btnPlayXOX.TabIndex = 10;
            this.btnPlayXOX.Text = "PLAY";
            this.btnPlayXOX.UseVisualStyleBackColor = true;
            this.btnPlayXOX.Click += new System.EventHandler(this.btnPlayXOX_Click);
            // 
            // btnIki_Kisi
            // 
            this.btnIki_Kisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIki_Kisi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIki_Kisi.Location = new System.Drawing.Point(43, 140);
            this.btnIki_Kisi.Name = "btnIki_Kisi";
            this.btnIki_Kisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIki_Kisi.Size = new System.Drawing.Size(160, 23);
            this.btnIki_Kisi.TabIndex = 11;
            this.btnIki_Kisi.Text = "İki Kişi ";
            this.btnIki_Kisi.UseVisualStyleBackColor = true;
            this.btnIki_Kisi.Click += new System.EventHandler(this.btnIki_Kisi_Click);
            // 
            // frmBaslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 333);
            this.Controls.Add(this.btnIki_Kisi);
            this.Controls.Add(this.btnPlayXOX);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.btnTekKisi);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "frmBaslangic";
            this.Text = "X O X ";
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
    }
}

