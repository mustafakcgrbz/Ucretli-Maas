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
    public partial class FrmKullanici : Form
    {
        public FrmKullanici()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");

        private void Temizle()
        {
            CmbKullanici.Items.Clear();
            TxtKullanici.Clear();
            TxtParola.Clear();
            CmbKurum.Items.Clear();
            RTxtAciklama.Clear();
            CmbKullanici.Text = "Kullanıcı Seçiniz";
            CmbKurum.Text = "Kurum Seçiniz";
        }

        private void KullaniciDoldur()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KullaniciAd From Kullanicilar Order By KullaniciAd", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbKullanici.Items.Add(oku["KullaniciAd"].ToString());
            }
            baglanti.Close();
        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKullanici_Load(object sender, EventArgs e)
        {
            Temizle();
            KullaniciDoldur();
        }
    }
}
