using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ücretli_Maaş
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        SqlConnection baglantiek = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
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

        private void güncelleVeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelGuncelle pguncellefrm = new FrmPersonelGuncelle();
            pguncellefrm.Show();
        }

        private void kullanıcıVeSifreislemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullanici Kullanici = new FrmKullanici();            
            Kullanici.Show();
        }

        private void FrmAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
        private void EkdersBordroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBordroAc bordrofrm = new FrmBordroAc();
            bordrofrm.Show();
        }

        private void Temizle()
        {
            LstPersonel.Items.Clear();

        }

        private void PersonelDoldur()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Personel Where Durum='1'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["PersonelId"].ToString();
                ekle.SubItems.Add(oku["KimlikNo"].ToString());
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());

            }
            baglanti.Close();
        }
        private void FrmAna_Load(object sender, EventArgs e)
        {
            
        }
    }
}
