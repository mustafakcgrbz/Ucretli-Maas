namespace Ücretli_Maaş
{
    partial class FrmKesinti
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
            this.label8 = new System.Windows.Forms.Label();
            this.LblAciklama = new System.Windows.Forms.Label();
            this.LblBordroNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtKimlikNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTur = new System.Windows.Forms.ComboBox();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstPersonel
            // 
            this.LstPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LstPersonel.Location = new System.Drawing.Point(12, 12);
            this.LstPersonel.Name = "LstPersonel";
            this.LstPersonel.Size = new System.Drawing.Size(448, 334);
            this.LstPersonel.TabIndex = 0;
            this.LstPersonel.UseCompatibleStateImageBehavior = false;
            this.LstPersonel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "T.C. Kimlik";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Çalıştığı Kurum";
            this.columnHeader4.Width = 194;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Açıklama :";
            // 
            // LblAciklama
            // 
            this.LblAciklama.AutoSize = true;
            this.LblAciklama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAciklama.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblAciklama.Location = new System.Drawing.Point(590, 53);
            this.LblAciklama.Name = "LblAciklama";
            this.LblAciklama.Size = new System.Drawing.Size(19, 21);
            this.LblAciklama.TabIndex = 37;
            this.LblAciklama.Text = "0";
            // 
            // LblBordroNo
            // 
            this.LblBordroNo.AutoSize = true;
            this.LblBordroNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBordroNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblBordroNo.Location = new System.Drawing.Point(495, 53);
            this.LblBordroNo.Name = "LblBordroNo";
            this.LblBordroNo.Size = new System.Drawing.Size(19, 21);
            this.LblBordroNo.TabIndex = 36;
            this.LblBordroNo.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Bordro No :";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.TxtSoyad.Enabled = false;
            this.TxtSoyad.Location = new System.Drawing.Point(591, 182);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(153, 20);
            this.TxtSoyad.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Soyadı :";
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.SystemColors.Info;
            this.TxtAd.Enabled = false;
            this.TxtAd.Location = new System.Drawing.Point(591, 141);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(153, 20);
            this.TxtAd.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Adı :";
            // 
            // TxtKimlikNo
            // 
            this.TxtKimlikNo.BackColor = System.Drawing.SystemColors.Info;
            this.TxtKimlikNo.Enabled = false;
            this.TxtKimlikNo.Location = new System.Drawing.Point(591, 96);
            this.TxtKimlikNo.Name = "TxtKimlikNo";
            this.TxtKimlikNo.Size = new System.Drawing.Size(153, 20);
            this.TxtKimlikNo.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Kimlik No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Kesinti Türü :";
            // 
            // CmbTur
            // 
            this.CmbTur.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbTur.FormattingEnabled = true;
            this.CmbTur.Items.AddRange(new object[] {
            "Icra",
            "Nafaka",
            "Diger"});
            this.CmbTur.Location = new System.Drawing.Point(591, 219);
            this.CmbTur.Name = "CmbTur";
            this.CmbTur.Size = new System.Drawing.Size(153, 25);
            this.CmbTur.TabIndex = 0;
            this.CmbTur.Text = "Kesinti Türü Seçiniz";
            // 
            // TxtTutar
            // 
            this.TxtTutar.BackColor = System.Drawing.SystemColors.Info;
            this.TxtTutar.Location = new System.Drawing.Point(591, 261);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(153, 20);
            this.TxtTutar.TabIndex = 1;
            this.TxtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tutar :";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(472, 313);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 33);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "&Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(580, 313);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 33);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "&Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnCikis
            // 
            this.BtnCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(691, 313);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(75, 33);
            this.BtnCikis.TabIndex = 4;
            this.BtnCikis.Text = "&Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmKesinti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(789, 359);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbTur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtKimlikNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblAciklama);
            this.Controls.Add(this.LblBordroNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LstPersonel);
            this.MaximizeBox = false;
            this.Name = "FrmKesinti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kesinti Menüsü";
            this.Load += new System.EventHandler(this.FrmKesinti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstPersonel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblAciklama;
        private System.Windows.Forms.Label LblBordroNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtKimlikNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTur;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnCikis;
    }
}