namespace Ücretli_Maaş
{
    partial class FrmKullanici
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
            this.CmbKullanici = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKullanici = new System.Windows.Forms.TextBox();
            this.TxtParola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbKurum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RTxtAciklama = new System.Windows.Forms.RichTextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnDuzenle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Seç :";
            // 
            // CmbKullanici
            // 
            this.CmbKullanici.BackColor = System.Drawing.SystemColors.Info;
            this.CmbKullanici.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbKullanici.FormattingEnabled = true;
            this.CmbKullanici.Location = new System.Drawing.Point(110, 12);
            this.CmbKullanici.Name = "CmbKullanici";
            this.CmbKullanici.Size = new System.Drawing.Size(156, 25);
            this.CmbKullanici.TabIndex = 1;
            this.CmbKullanici.Text = "Kullanıcı Seçiniz :";
            this.CmbKullanici.SelectedIndexChanged += new System.EventHandler(this.CmbKullanici_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // TxtKullanici
            // 
            this.TxtKullanici.BackColor = System.Drawing.SystemColors.Info;
            this.TxtKullanici.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullanici.Location = new System.Drawing.Point(109, 53);
            this.TxtKullanici.MaxLength = 10;
            this.TxtKullanici.Name = "TxtKullanici";
            this.TxtKullanici.Size = new System.Drawing.Size(157, 25);
            this.TxtKullanici.TabIndex = 3;
            // 
            // TxtParola
            // 
            this.TxtParola.BackColor = System.Drawing.SystemColors.Info;
            this.TxtParola.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtParola.Location = new System.Drawing.Point(109, 93);
            this.TxtParola.MaxLength = 10;
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.Size = new System.Drawing.Size(157, 25);
            this.TxtParola.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola :";
            // 
            // CmbKurum
            // 
            this.CmbKurum.BackColor = System.Drawing.SystemColors.Info;
            this.CmbKurum.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbKurum.FormattingEnabled = true;
            this.CmbKurum.Location = new System.Drawing.Point(376, 12);
            this.CmbKurum.Name = "CmbKurum";
            this.CmbKurum.Size = new System.Drawing.Size(189, 25);
            this.CmbKurum.TabIndex = 7;
            this.CmbKurum.Text = "Kurum Seçiniz :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(290, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kurum Seç :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(301, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Açıklama :";
            // 
            // RTxtAciklama
            // 
            this.RTxtAciklama.BackColor = System.Drawing.SystemColors.Info;
            this.RTxtAciklama.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RTxtAciklama.Location = new System.Drawing.Point(376, 53);
            this.RTxtAciklama.MaxLength = 50;
            this.RTxtAciklama.Name = "RTxtAciklama";
            this.RTxtAciklama.Size = new System.Drawing.Size(189, 65);
            this.RTxtAciklama.TabIndex = 9;
            this.RTxtAciklama.Text = "";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(18, 143);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(85, 30);
            this.BtnKaydet.TabIndex = 10;
            this.BtnKaydet.Text = "&Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnDuzenle
            // 
            this.BtnDuzenle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDuzenle.Location = new System.Drawing.Point(134, 143);
            this.BtnDuzenle.Name = "BtnDuzenle";
            this.BtnDuzenle.Size = new System.Drawing.Size(85, 30);
            this.BtnDuzenle.TabIndex = 11;
            this.BtnDuzenle.Text = "&Düzenle";
            this.BtnDuzenle.UseVisualStyleBackColor = true;
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(251, 143);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(85, 30);
            this.BtnSil.TabIndex = 12;
            this.BtnSil.Text = "&Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Location = new System.Drawing.Point(368, 143);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(85, 30);
            this.BtnTemizle.TabIndex = 13;
            this.BtnTemizle.Text = "&Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(480, 143);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(85, 30);
            this.BtnCikis.TabIndex = 14;
            this.BtnCikis.Text = "&Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // FrmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 182);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnDuzenle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.RTxtAciklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbKurum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbKullanici);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri Menüsü";
            this.Load += new System.EventHandler(this.FrmKullanici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbKullanici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKullanici;
        private System.Windows.Forms.TextBox TxtParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbKurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RTxtAciklama;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnDuzenle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnCikis;
    }
}