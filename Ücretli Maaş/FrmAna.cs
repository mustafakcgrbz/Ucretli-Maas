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
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void maasAyarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAyar ayarform = new FrmAyar();
            ayarform.Show();

        }
    }
}
