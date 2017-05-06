namespace Ücretli_Maaş
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
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maaşAyarlarıToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // maaşAyarlarıToolStripMenuItem
            // 
            this.maaşAyarlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maasAyarToolStripMenuItem,
            this.kurumİşlemleriToolStripMenuItem});
            this.maaşAyarlarıToolStripMenuItem.Name = "maaşAyarlarıToolStripMenuItem";
            this.maaşAyarlarıToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.maaşAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(73, 30);
            this.maaşAyarlarıToolStripMenuItem.Text = "Ayarlar";
            // 
            // maasAyarToolStripMenuItem
            // 
            this.maasAyarToolStripMenuItem.Name = "maasAyarToolStripMenuItem";
            this.maasAyarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.maasAyarToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
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
            this.kurumİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
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
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(666, 377);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ücretli Maaş Ana Menü";
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
    }
}

