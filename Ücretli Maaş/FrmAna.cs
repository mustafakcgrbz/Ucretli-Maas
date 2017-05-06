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

        private void kurumEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KurumEkle KurumEkleFrm = new KurumEkle();
            KurumEkleFrm.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKurumGuncelle frmguncelle = new FrmKurumGuncelle();
            frmguncelle.Show();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelEkle frmperekle = new FrmPersonelEkle();
            frmperekle.Show();
        }

        private void alanEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlanEkle AlanEkleFrm = new FrmAlanEkle();
            AlanEkleFrm.Show();
        }

        private void güncelleVeyaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlanGuncelle AlanGuncelleFrm = new FrmAlanGuncelle();
            AlanGuncelleFrm.Show();
        }
    }
}
