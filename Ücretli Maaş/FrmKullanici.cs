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
        private void KurumDoldur()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KurumAd From KurumBilgi Order By KurumAd", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbKurum.Items.Add(oku["KurumAd"].ToString());
            }
            baglanti.Close();
        }

        private void KullaniciGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KullaniciAd, Parola, Aciklama From Kullanicilar Where KullaniciAd='" + CmbKullanici.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                TxtKullanici.Text = oku["KullaniciAd"].ToString();
                TxtParola.Text = oku["Parola"].ToString();
                RTxtAciklama.Text = oku["Aciklama"].ToString();
                baglanti.Close();
                KurumGetir();
            }
            else
            {
                baglanti.Close();
            }
            
        }

        private void KurumGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KurumAd From KurumBilgi Where KurumId=(Select KurumId From Kullanicilar Where KullaniciAd='" + CmbKullanici.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                CmbKurum.Text = oku["KurumAd"].ToString();
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
            KurumDoldur();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void CmbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            KullaniciGetir();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            KullaniciDoldur();
            KurumDoldur();
        }
    }
}
