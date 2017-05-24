namespace Ücretli_Maaş
{
    partial class FrmHesapRapor
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
            this.mustafa_gurbuz_dbDataSet = new Ücretli_Maaş.mustafa_gurbuz_dbDataSet();
            this.GeciciHesapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GeciciHesapTableAdapter = new Ücretli_Maaş.mustafa_gurbuz_dbDataSetTableAdapters.GeciciHesapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mustafa_gurbuz_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeciciHesapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GeciciHesapBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ücretli_Maaş.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1121, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // mustafa_gurbuz_dbDataSet
            // 
            this.mustafa_gurbuz_dbDataSet.DataSetName = "mustafa_gurbuz_dbDataSet";
            this.mustafa_gurbuz_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GeciciHesapBindingSource
            // 
            this.GeciciHesapBindingSource.DataMember = "GeciciHesap";
            this.GeciciHesapBindingSource.DataSource = this.mustafa_gurbuz_dbDataSet;
            // 
            // GeciciHesapTableAdapter
            // 
            this.GeciciHesapTableAdapter.ClearBeforeFill = true;
            // 
            // FrmHesapRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 470);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmHesapRapor";
            this.Text = "FrmHesapRapor";
            this.Load += new System.EventHandler(this.FrmHesapRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mustafa_gurbuz_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeciciHesapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GeciciHesapBindingSource;
        private mustafa_gurbuz_dbDataSet mustafa_gurbuz_dbDataSet;
        private mustafa_gurbuz_dbDataSetTableAdapters.GeciciHesapTableAdapter GeciciHesapTableAdapter;
    }
}