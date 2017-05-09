namespace Ücretli_Maaş
{
    partial class FrmBordroAc
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
            this.DtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpBitis = new System.Windows.Forms.DateTimePicker();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAciklama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DtpBaslangic
            // 
            this.DtpBaslangic.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpBaslangic.Location = new System.Drawing.Point(130, 12);
            this.DtpBaslangic.Name = "DtpBaslangic";
            this.DtpBaslangic.Size = new System.Drawing.Size(233, 27);
            this.DtpBaslangic.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş Tarihi :";
            // 
            // DtpBitis
            // 
            this.DtpBitis.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpBitis.Location = new System.Drawing.Point(130, 56);
            this.DtpBitis.Name = "DtpBitis";
            this.DtpBitis.Size = new System.Drawing.Size(233, 27);
            this.DtpBitis.TabIndex = 2;
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOlustur.Location = new System.Drawing.Point(31, 154);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(147, 43);
            this.BtnOlustur.TabIndex = 4;
            this.BtnOlustur.Text = "Bordro &Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(206, 154);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(147, 43);
            this.BtnCikis.TabIndex = 5;
            this.BtnCikis.Text = "&Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(55, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Açıklama :";
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.BackColor = System.Drawing.SystemColors.Info;
            this.TxtAciklama.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAciklama.Location = new System.Drawing.Point(131, 100);
            this.TxtAciklama.MaxLength = 30;
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(232, 27);
            this.TxtAciklama.TabIndex = 7;
            // 
            // FrmBordroAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 209);
            this.Controls.Add(this.TxtAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnOlustur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpBitis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpBaslangic);
            this.MaximizeBox = false;
            this.Name = "FrmBordroAc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bordro Açma Menüsü";
            this.Load += new System.EventHandler(this.FrmBordroAc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpBaslangic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpBitis;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAciklama;
    }
}