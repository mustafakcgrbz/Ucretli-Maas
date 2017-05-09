namespace Ücretli_Maaş
{
    partial class FrmOkul
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
            this.LstPersonel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.LblKurumAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblBordroNo = new System.Windows.Forms.Label();
            this.LblAciklama = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.DtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtKimlikNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEkders = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstPersonel
            // 
            this.LstPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LstPersonel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LstPersonel.Location = new System.Drawing.Point(8, 8);
            this.LstPersonel.Name = "LstPersonel";
            this.LstPersonel.Size = new System.Drawing.Size(509, 366);
            this.LstPersonel.TabIndex = 0;
            this.LstPersonel.UseCompatibleStateImageBehavior = false;
            this.LstPersonel.View = System.Windows.Forms.View.Details;
            this.LstPersonel.DoubleClick += new System.EventHandler(this.LstPersonel_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "P. No";
            this.columnHeader1.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "T.C. Kimlik No";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adı";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Soyadı";
            this.columnHeader4.Width = 138;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ders Saati";
            this.columnHeader5.Width = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kurum Adı :";
            // 
            // LblKurumAd
            // 
            this.LblKurumAd.AutoSize = true;
            this.LblKurumAd.Location = new System.Drawing.Point(100, 379);
            this.LblKurumAd.Name = "LblKurumAd";
            this.LblKurumAd.Size = new System.Drawing.Size(0, 20);
            this.LblKurumAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bordro No :";
            // 
            // LblBordroNo
            // 
            this.LblBordroNo.AutoSize = true;
            this.LblBordroNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBordroNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblBordroNo.Location = new System.Drawing.Point(529, 52);
            this.LblBordroNo.Name = "LblBordroNo";
            this.LblBordroNo.Size = new System.Drawing.Size(19, 21);
            this.LblBordroNo.TabIndex = 4;
            this.LblBordroNo.Text = "0";
            // 
            // LblAciklama
            // 
            this.LblAciklama.AutoSize = true;
            this.LblAciklama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAciklama.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblAciklama.Location = new System.Drawing.Point(754, 52);
            this.LblAciklama.Name = "LblAciklama";
            this.LblAciklama.Size = new System.Drawing.Size(19, 21);
            this.LblAciklama.TabIndex = 5;
            this.LblAciklama.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Başlangıç Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(754, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bitiş Tarihi :";
            // 
            // DtpBaslangic
            // 
            this.DtpBaslangic.Enabled = false;
            this.DtpBaslangic.Location = new System.Drawing.Point(531, 124);
            this.DtpBaslangic.Name = "DtpBaslangic";
            this.DtpBaslangic.Size = new System.Drawing.Size(200, 27);
            this.DtpBaslangic.TabIndex = 8;
            // 
            // DtpBitis
            // 
            this.DtpBitis.Enabled = false;
            this.DtpBitis.Location = new System.Drawing.Point(756, 124);
            this.DtpBitis.Name = "DtpBitis";
            this.DtpBitis.Size = new System.Drawing.Size(200, 27);
            this.DtpBitis.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kimlik No :";
            // 
            // TxtKimlikNo
            // 
            this.TxtKimlikNo.BackColor = System.Drawing.SystemColors.Info;
            this.TxtKimlikNo.Enabled = false;
            this.TxtKimlikNo.Location = new System.Drawing.Point(632, 170);
            this.TxtKimlikNo.Name = "TxtKimlikNo";
            this.TxtKimlikNo.Size = new System.Drawing.Size(153, 27);
            this.TxtKimlikNo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adı :";
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.SystemColors.Info;
            this.TxtAd.Enabled = false;
            this.TxtAd.Location = new System.Drawing.Point(632, 215);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(153, 27);
            this.TxtAd.TabIndex = 13;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.TxtSoyad.Enabled = false;
            this.TxtSoyad.Location = new System.Drawing.Point(632, 260);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(153, 27);
            this.TxtSoyad.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Soyadı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(752, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Açıklama :";
            // 
            // TxtEkders
            // 
            this.TxtEkders.BackColor = System.Drawing.SystemColors.Info;
            this.TxtEkders.Location = new System.Drawing.Point(632, 306);
            this.TxtEkders.MaxLength = 3;
            this.TxtEkders.Name = "TxtEkders";
            this.TxtEkders.Size = new System.Drawing.Size(153, 27);
            this.TxtEkders.TabIndex = 18;
            this.TxtEkders.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(527, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ekders Saati :";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(577, 359);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(117, 33);
            this.BtnGuncelle.TabIndex = 19;
            this.BtnGuncelle.Text = "&Kaydet";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(814, 359);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(117, 33);
            this.BtnCikis.TabIndex = 20;
            this.BtnCikis.Text = "&Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // FrmOkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 406);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtEkders);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtKimlikNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtpBitis);
            this.Controls.Add(this.DtpBaslangic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblAciklama);
            this.Controls.Add(this.LblBordroNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblKurumAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstPersonel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmOkul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okul İşlemleri Menüsü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOkul_FormClosed);
            this.Load += new System.EventHandler(this.FrmOkul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstPersonel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LblKurumAd;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblBordroNo;
        private System.Windows.Forms.Label LblAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpBaslangic;
        private System.Windows.Forms.DateTimePicker DtpBitis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtKimlikNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEkders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnCikis;
    }
}