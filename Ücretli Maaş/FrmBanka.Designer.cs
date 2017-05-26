namespace Ücretli_Maaş
{
    partial class FrmBanka
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbDataSetBanka = new Ücretli_Maaş.dbDataSetBanka();
            this.BankaListeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankaListeTableAdapter = new Ücretli_Maaş.dbDataSetBankaTableAdapters.BankaListeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBanka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankaListeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetBanka";
            reportDataSource1.Value = this.BankaListeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ücretli_Maaş.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 7);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(638, 448);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbDataSetBanka
            // 
            this.dbDataSetBanka.DataSetName = "dbDataSetBanka";
            this.dbDataSetBanka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BankaListeBindingSource
            // 
            this.BankaListeBindingSource.DataMember = "BankaListe";
            this.BankaListeBindingSource.DataSource = this.dbDataSetBanka;
            // 
            // BankaListeTableAdapter
            // 
            this.BankaListeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBanka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(649, 461);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "FrmBanka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Listesi";
            this.Load += new System.EventHandler(this.FrmBanka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBanka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankaListeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BankaListeBindingSource;
        private dbDataSetBanka dbDataSetBanka;
        private dbDataSetBankaTableAdapters.BankaListeTableAdapter BankaListeTableAdapter;
    }
}