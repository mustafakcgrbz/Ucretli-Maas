using System;
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
    public partial class FrmHesapRapor : Form
    {
        public FrmHesapRapor()
        {
            InitializeComponent();
        }

        private void FrmHesapRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mustafa_gurbuz_dbDataSet.GeciciHesap' table. You can move, or remove it, as needed.
            this.GeciciHesapTableAdapter.Fill(this.mustafa_gurbuz_dbDataSet.GeciciHesap);

            this.reportViewer1.RefreshReport();
        }
    }
}
