namespace Ücretli_Maaş
{
    partial class FrmAlanGuncelle
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
            this.CmbAlan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAlan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alan Adı :";
            // 
            // CmbAlan
            // 
            this.CmbAlan.BackColor = System.Drawing.SystemColors.Info;
            this.CmbAlan.FormattingEnabled = true;
            this.CmbAlan.Location = new System.Drawing.Point(129, 24);
            this.CmbAlan.Name = "CmbAlan";
            this.CmbAlan.Size = new System.Drawing.Size(260, 28);
            this.CmbAlan.TabIndex = 1;
            this.CmbAlan.Text = "Alan Seçiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Alan Adı :";
            // 
            // TxtAlan
            // 
            this.TxtAlan.BackColor = System.Drawing.SystemColors.Info;
            this.TxtAlan.Location = new System.Drawing.Point(129, 72);
            this.TxtAlan.Name = "TxtAlan";
            this.TxtAlan.Size = new System.Drawing.Size(260, 27);
            this.TxtAlan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yeni Açıklama :";
            // 
            // RtxtAciklama
            // 
            this.RtxtAciklama.BackColor = System.Drawing.SystemColors.Info;
            this.RtxtAciklama.Location = new System.Drawing.Point(129, 121);
            this.RtxtAciklama.Name = "RtxtAciklama";
            this.RtxtAciklama.Size = new System.Drawing.Size(260, 50);
            this.RtxtAciklama.TabIndex = 5;
            this.RtxtAciklama.Text = "";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(18, 203);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(110, 41);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.Text = "&Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(149, 203);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(110, 41);
            this.BtnSil.TabIndex = 7;
            this.BtnSil.Text = "&Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(279, 203);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(110, 41);
            this.BtnCikis.TabIndex = 8;
            this.BtnCikis.Text = "&Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // FrmAlanGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 259);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.RtxtAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAlan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbAlan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmAlanGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alan Güncelleme ve Silme Menüsü";
            this.Load += new System.EventHandler(this.FrmAlanGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbAlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RtxtAciklama;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnCikis;
    }
}