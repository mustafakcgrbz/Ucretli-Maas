﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ücretli_Maaş
{
    public partial class FrmBanka : Form
    {
        public FrmBanka()
        {
            InitializeComponent();
        }

        private void FrmBanka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSetBanka.BankaListe' table. You can move, or remove it, as needed.
            try
            {
                this.BankaListeTableAdapter.Fill(this.dbDataSetBanka.BankaListe);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }

        }
    }
}
