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
    public partial class FrmOkul : Form
    {
        public FrmOkul()
        {
            InitializeComponent();
        }
        string id;
        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        SqlConnection baglantiek = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");

        private void PersonelDoldur()
        {
            LstPersonel.Items.Clear();
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("Select PersonelId, KimlikNo, Adi, Soyadi From Personel Where Kurum=(Select KurumId From KurumBilgi Where KurumAd='" + LblKurumAd.Text + "') And Durum='1' Order By Adi,Soyadi", baglanti);            
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                baglantiek.Open();
                SqlCommand komutek = new SqlCommand("Select DersSaati From Puantaj Where PersonelId='" + oku["PersonelId"].ToString() + "'And BordroId='"+LblBordroNo.Text+"'", baglantiek);
                komutek.ExecuteNonQuery();
                SqlDataReader okuek = komutek.ExecuteReader();
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["PersonelId"].ToString();
                ekle.SubItems.Add(oku["KimlikNo"].ToString());
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                if (okuek.Read())
                {
                    ekle.SubItems.Add(okuek["DersSaati"].ToString());
                    
                }
                LstPersonel.Items.Add(ekle);
                baglantiek.Close();
            }
            baglanti.Close();
        }
        private void BordroKontrol()
        {
            if (LblBordroNo.Text=="0")
            {
                MessageBox.Show("Açık Ekders Bordrosu Bulunamadı!!");
            }
            else
            {
                EkdersGuncelle();
            }
        }

        private void EkdersGuncelle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Puantaj Set DersSaati='" + TxtEkders.Text + "', KurumId=(Select KurumId From KurumBilgi Where KurumAd='"+LblKurumAd.Text + "'), KullaniciAd=(Select KullaniciAd From Kullanicilar Where KurumId=(Select KurumId From KurumBilgi Where KurumAd='" + LblKurumAd.Text + "'))  Where PersonelId='" + id + "' And BordroId='" + LblBordroNo.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            PersonelDoldur();
            MessageBox.Show("Ekders Başarıyla Güncellendi!!");
            
        }
        private void BordroGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select BordroId, BaslangicTarihi, BitisTarihi, Aciklama From Bordro Where BordroDurum='Acik Bordro'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                LblBordroNo.Text = oku["BordroId"].ToString();
                LblAciklama.Text = oku["Aciklama"].ToString();
                DtpBaslangic.Text = oku["BaslangicTarihi"].ToString();
                DtpBitis.Text = oku["BitisTarihi"].ToString();
                baglanti.Close();
            }
            
        }
        private void PersonelGetir()
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Personel Where PersonelId='" + id + "'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                TxtKimlikNo.Text = oku["KimlikNo"].ToString();
                TxtAd.Text = oku["Adi"].ToString();
                TxtSoyad.Text = oku["Soyadi"].ToString();
                

            }
            baglanti.Close();

        }
        private void Temizle()
        {
            TxtKimlikNo.Clear();
            TxtAd.Clear();
            TxtSoyad.Clear();
            TxtEkders.Clear();
        }
        private void FrmOkul_Load(object sender, EventArgs e)
        {
            BordroGetir();
            PersonelDoldur();
            
        }

        private void FrmOkul_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            BordroKontrol();
        }

        private void LstPersonel_DoubleClick(object sender, EventArgs e)
        {
            id = LstPersonel.SelectedItems[0].SubItems[0].Text;
            PersonelGetir();
        }
    }
}
