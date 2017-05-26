namespace Ücretli_Maaş
{
    partial class FrmMaasHesapla
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
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBordro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.DtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAciklama = new System.Windows.Forms.TextBox();
            this.BtnGecici = new System.Windows.Forms.Button();
            this.BtnKontrol = new System.Windows.Forms.Button();
            this.BtnKesin = new System.Windows.Forms.Button();
            this.BtnMuhasebe = new System.Windows.Forms.Button();
            this.BtnBanka = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesaplama Yapılacak Bordro :";
            // 
            // CmbBordro
            // 
            this.CmbBordro.BackColor = System.Drawing.SystemColors.Info;
            this.CmbBordro.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBordro.FormattingEnabled = true;
            this.CmbBordro.Location = new System.Drawing.Point(230, 15);
            this.CmbBordro.Name = "CmbBordro";
            this.CmbBordro.Size = new System.Drawing.Size(233, 28);
            this.CmbBordro.TabIndex = 1;
            this.CmbBordro.Text = "Bordro Seçiniz :";
            this.CmbBordro.SelectedIndexChanged += new System.EventHandler(this.CmbBordro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bordro Başlangıç Tarihi :";
            // 
            // DtpBaslangic
            // 
            this.DtpBaslangic.Enabled = false;
            this.DtpBaslangic.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpBaslangic.Location = new System.Drawing.Point(16, 109);
            this.DtpBaslangic.Name = "DtpBaslangic";
            this.DtpBaslangic.Size = new System.Drawing.Size(211, 27);
            this.DtpBaslangic.TabIndex = 3;
            // 
            // DtpBitis
            // 
            this.DtpBitis.Enabled = false;
            this.DtpBitis.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpBitis.Location = new System.Drawing.Point(252, 109);
            this.DtpBitis.Name = "DtpBitis";
            this.DtpBitis.Size = new System.Drawing.Size(211, 27);
            this.DtpBitis.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(324, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bordro Bitiş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Açıklama :";
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.BackColor = System.Drawing.SystemColors.Info;
            this.TxtAciklama.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAciklama.Location = new System.Drawing.Point(97, 158);
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(366, 27);
            this.TxtAciklama.TabIndex = 7;
            // 
            // BtnGecici
            // 
            this.BtnGecici.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGecici.Location = new System.Drawing.Point(16, 213);
            this.BtnGecici.Name = "BtnGecici";
            this.BtnGecici.Size = new System.Drawing.Size(108, 55);
            this.BtnGecici.TabIndex = 8;
            this.BtnGecici.Text = "&Geçici Hesaplama";
            this.BtnGecici.UseVisualStyleBackColor = true;
            this.BtnGecici.Click += new System.EventHandler(this.BtnGecici_Click);
            // 
            // BtnKontrol
            // 
            this.BtnKontrol.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKontrol.Location = new System.Drawing.Point(185, 213);
            this.BtnKontrol.Name = "BtnKontrol";
            this.BtnKontrol.Size = new System.Drawing.Size(108, 55);
            this.BtnKontrol.TabIndex = 9;
            this.BtnKontrol.Text = "Geçici &Hesap Kontrol";
            this.BtnKontrol.UseVisualStyleBackColor = true;
            this.BtnKontrol.Click += new System.EventHandler(this.BtnKontrol_Click);
            // 
            // BtnKesin
            // 
            this.BtnKesin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKesin.Location = new System.Drawing.Point(355, 213);
            this.BtnKesin.Name = "BtnKesin";
            this.BtnKesin.Size = new System.Drawing.Size(108, 55);
            this.BtnKesin.TabIndex = 10;
            this.BtnKesin.Text = "&Kesin Hesap";
            this.BtnKesin.UseVisualStyleBackColor = true;
            this.BtnKesin.Click += new System.EventHandler(this.BtnKesin_Click);
            // 
            // BtnMuhasebe
            // 
            this.BtnMuhasebe.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMuhasebe.Location = new System.Drawing.Point(16, 292);
            this.BtnMuhasebe.Name = "BtnMuhasebe";
            this.BtnMuhasebe.Size = new System.Drawing.Size(108, 55);
            this.BtnMuhasebe.TabIndex = 11;
            this.BtnMuhasebe.Text = "&Muhasebe Bordro";
            this.BtnMuhasebe.UseVisualStyleBackColor = true;
            this.BtnMuhasebe.Click += new System.EventHandler(this.BtnMuhasebe_Click);
            // 
            // BtnBanka
            // 
            this.BtnBanka.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBanka.Location = new System.Drawing.Point(185, 292);
            this.BtnBanka.Name = "BtnBanka";
            this.BtnBanka.Size = new System.Drawing.Size(108, 55);
            this.BtnBanka.TabIndex = 12;
            this.BtnBanka.Text = "&Banka Listesi";
            this.BtnBanka.UseVisualStyleBackColor = true;
            this.BtnBanka.Click += new System.EventHandler(this.BtnBanka_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(355, 292);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(108, 55);
            this.BtnCikis.TabIndex = 13;
            this.BtnCikis.Text = "&Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // FrmMaasHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(481, 372);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnBanka);
            this.Controls.Add(this.BtnMuhasebe);
            this.Controls.Add(this.BtnKesin);
            this.Controls.Add(this.BtnKontrol);
            this.Controls.Add(this.BtnGecici);
            this.Controls.Add(this.TxtAciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpBitis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtpBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbBordro);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmMaasHesapla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maaş Hesaplama Menüsü";
            this.Load += new System.EventHandler(this.FrmMaasHesapla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBordro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpBaslangic;
        private System.Windows.Forms.DateTimePicker DtpBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAciklama;
        private System.Windows.Forms.Button BtnGecici;
        private System.Windows.Forms.Button BtnKontrol;
        private System.Windows.Forms.Button BtnKesin;
        private System.Windows.Forms.Button BtnMuhasebe;
        private System.Windows.Forms.Button BtnBanka;
        private System.Windows.Forms.Button BtnCikis;
    }
}