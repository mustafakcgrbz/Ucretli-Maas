﻿namespace Ücretli_Maaş
{
    partial class FrmAna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maaşAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maasAyarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurumİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurumEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alanBilgisiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alanEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleVeyaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıVeSifreislemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleVeSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maaşİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçiciMaaşBordrosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EkdersBordroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maaşRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LstPersonel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maaşAyarlarıToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem,
            this.maaşİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // maaşAyarlarıToolStripMenuItem
            // 
            this.maaşAyarlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maasAyarToolStripMenuItem,
            this.kurumİşlemleriToolStripMenuItem,
            this.alanBilgisiİşlemleriToolStripMenuItem,
            this.kullanıcıVeSifreislemleriToolStripMenuItem});
            this.maaşAyarlarıToolStripMenuItem.Name = "maaşAyarlarıToolStripMenuItem";
            this.maaşAyarlarıToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.maaşAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(73, 30);
            this.maaşAyarlarıToolStripMenuItem.Text = "Ayarlar";
            // 
            // maasAyarToolStripMenuItem
            // 
            this.maasAyarToolStripMenuItem.Name = "maasAyarToolStripMenuItem";
            this.maasAyarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.maasAyarToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.maasAyarToolStripMenuItem.Text = "Maaş Ayar";
            this.maasAyarToolStripMenuItem.Click += new System.EventHandler(this.maasAyarToolStripMenuItem_Click);
            // 
            // kurumİşlemleriToolStripMenuItem
            // 
            this.kurumİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kurumEkleToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.kurumİşlemleriToolStripMenuItem.Name = "kurumİşlemleriToolStripMenuItem";
            this.kurumİşlemleriToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.kurumİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.kurumİşlemleriToolStripMenuItem.Text = "Kurum İşlemleri";
            // 
            // kurumEkleToolStripMenuItem
            // 
            this.kurumEkleToolStripMenuItem.Name = "kurumEkleToolStripMenuItem";
            this.kurumEkleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.kurumEkleToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.kurumEkleToolStripMenuItem.Text = "Yeni Ekle";
            this.kurumEkleToolStripMenuItem.Click += new System.EventHandler(this.kurumEkleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.güncelleToolStripMenuItem.Text = "Güncelle veya Sil";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // alanBilgisiİşlemleriToolStripMenuItem
            // 
            this.alanBilgisiİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alanEklemeToolStripMenuItem,
            this.güncelleVeyaSilToolStripMenuItem});
            this.alanBilgisiİşlemleriToolStripMenuItem.Name = "alanBilgisiİşlemleriToolStripMenuItem";
            this.alanBilgisiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.alanBilgisiİşlemleriToolStripMenuItem.Text = "Alan Bilgisi İşlemleri";
            // 
            // alanEklemeToolStripMenuItem
            // 
            this.alanEklemeToolStripMenuItem.Name = "alanEklemeToolStripMenuItem";
            this.alanEklemeToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.alanEklemeToolStripMenuItem.Text = "Yeni Alan Ekle";
            this.alanEklemeToolStripMenuItem.Click += new System.EventHandler(this.alanEklemeToolStripMenuItem_Click);
            // 
            // güncelleVeyaSilToolStripMenuItem
            // 
            this.güncelleVeyaSilToolStripMenuItem.Name = "güncelleVeyaSilToolStripMenuItem";
            this.güncelleVeyaSilToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.güncelleVeyaSilToolStripMenuItem.Text = "Güncelle veya Sil";
            this.güncelleVeyaSilToolStripMenuItem.Click += new System.EventHandler(this.güncelleVeyaSilToolStripMenuItem_Click);
            // 
            // kullanıcıVeSifreislemleriToolStripMenuItem
            // 
            this.kullanıcıVeSifreislemleriToolStripMenuItem.Name = "kullanıcıVeSifreislemleriToolStripMenuItem";
            this.kullanıcıVeSifreislemleriToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.kullanıcıVeSifreislemleriToolStripMenuItem.Text = "Kullanıcı ve Şifre İşlemleri";
            this.kullanıcıVeSifreislemleriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıVeSifreislemleriToolStripMenuItem_Click);
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.güncelleVeSilToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // güncelleVeSilToolStripMenuItem
            // 
            this.güncelleVeSilToolStripMenuItem.Name = "güncelleVeSilToolStripMenuItem";
            this.güncelleVeSilToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.güncelleVeSilToolStripMenuItem.Text = "Güncelle ve Sil";
            this.güncelleVeSilToolStripMenuItem.Click += new System.EventHandler(this.güncelleVeSilToolStripMenuItem_Click);
            // 
            // maaşİşlemleriToolStripMenuItem
            // 
            this.maaşİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geçiciMaaşBordrosuToolStripMenuItem,
            this.EkdersBordroToolStripMenuItem,
            this.maaşRaporlarıToolStripMenuItem});
            this.maaşİşlemleriToolStripMenuItem.Name = "maaşİşlemleriToolStripMenuItem";
            this.maaşİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(118, 30);
            this.maaşİşlemleriToolStripMenuItem.Text = "Maaş İşlemleri";
            // 
            // geçiciMaaşBordrosuToolStripMenuItem
            // 
            this.geçiciMaaşBordrosuToolStripMenuItem.Name = "geçiciMaaşBordrosuToolStripMenuItem";
            this.geçiciMaaşBordrosuToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.geçiciMaaşBordrosuToolStripMenuItem.Text = "Maaş Hesaplama";
            // 
            // EkdersBordroToolStripMenuItem
            // 
            this.EkdersBordroToolStripMenuItem.Name = "EkdersBordroToolStripMenuItem";
            this.EkdersBordroToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.EkdersBordroToolStripMenuItem.Text = "Ekders Bordrosu Açma";
            this.EkdersBordroToolStripMenuItem.Click += new System.EventHandler(this.EkdersBordroToolStripMenuItem_Click);
            // 
            // maaşRaporlarıToolStripMenuItem
            // 
            this.maaşRaporlarıToolStripMenuItem.Name = "maaşRaporlarıToolStripMenuItem";
            this.maaşRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.maaşRaporlarıToolStripMenuItem.Text = "Maaş Raporları";
            // 
            // LstPersonel
            // 
            this.LstPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LstPersonel.Location = new System.Drawing.Point(3, 42);
            this.LstPersonel.Name = "LstPersonel";
            this.LstPersonel.Size = new System.Drawing.Size(660, 425);
            this.LstPersonel.TabIndex = 1;
            this.LstPersonel.UseCompatibleStateImageBehavior = false;
            this.LstPersonel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Personel No";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "T.C. Kimlik No";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adı";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Soyadı";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ekders";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Çalıştığı Kurum";
            this.columnHeader6.Width = 187;
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 465);
            this.Controls.Add(this.LstPersonel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ücretli Maaş Ana Menü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAna_FormClosed);
            this.Load += new System.EventHandler(this.FrmAna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maaşAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maasAyarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurumİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurumEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alanBilgisiİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alanEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleVeyaSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maaşİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geçiciMaaşBordrosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EkdersBordroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maaşRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleVeSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıVeSifreislemleriToolStripMenuItem;
        private System.Windows.Forms.ListView LstPersonel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

