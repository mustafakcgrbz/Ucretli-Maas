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
    public partial class FrmPersonelEkle : Form
    {
        public FrmPersonelEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");

        private void Temizle()
        {
            //Formda bulunan Textboxlar ve Açılır Kutular Temizleniyor.
            TxtKimlik.Clear();
            TxtAd.Clear();
            TxtSoyad.Clear();
            CmbMedeniDurum.Items.Clear();
            TxtCocuk.Clear();
            MskCep.Clear();
            MskSabit.Clear();
            TxtEposta.Clear();
            CmbCalisma.Items.Clear();
            CmbAlan.Items.Clear();
            CmbKurum.Items.Clear();
            TxtBes.Clear();
            TxtIban.Clear();
            RtxtAdres.Clear();
            DtpBaslama.Text = "";
            DtpAyrilma.Text = "";
            
        }
        private void MDurumOku()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select DurumAd From MedeniDurum", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbMedeniDurum.Items.Add(oku["DurumAd"].ToString());
            }

            baglanti.Close();
            CmbMedeniDurum.Text = "Durum Seçiniz :";
        }

        private void CDurumOku()
        {
            //Çalışma Durumu Okunuyor.
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select DurumAd From CalismaDurumu", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbCalisma.Items.Add(oku["DurumAd"].ToString());
            }
            baglanti.Close();
            CmbCalisma.Text = "Durum Seçiniz :";
        }

        private void AlanOku()
        {
            //Alan Bilgisi Okunuyor.
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select AlanAd From AlanBilgi", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbAlan.Items.Add(oku["AlanAd"].ToString());
            }
            baglanti.Close();
            CmbAlan.Text = "Alan Seçiniz :";
        }

        private void KurumOku()
        {
            //Kurum Bilgisi Okunuyor.
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KurumAd From KurumBilgi", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbKurum.Items.Add(oku["KurumAd"].ToString());
            }
            baglanti.Close();
            CmbKurum.Text = "Kurum Seçiniz :";
        }
        private void VeriOku()
        {
            MDurumOku();
            CDurumOku();
            AlanOku();
            KurumOku();
            TxtKimlik.Select();
        }

        private void VeriKaydet()
        {
            //Personel Bilgileri Kaydediliyor.
            if (CmbMedeniDurum.Text == "Durum Seçiniz :" | CmbCalisma.Text == "Durum Seçiniz :" | CmbAlan.Text == "Alan Seçiniz :" | CmbKurum.Text == "Kurum Seçiniz :")
            {
                MessageBox.Show("Lütfen Gerekli Bölümleri Seçiniz!!");

            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Personel (KimlikNo, Adi, Soyadi, MedeniHal, CocukSayi, CepTelefonu, SabitTelefon, Eposta, Durum, Alan, Kurum, BaslamaTarihi, AyrilmaTarihi, BireyselEmeklilik, IbanNo, Adres) Values ('" + TxtKimlik.Text + "','" + TxtAd.Text + "','" + TxtSoyad.Text + "',(select DurumId From MedeniDurum Where DurumAd='" + CmbMedeniDurum.Text + "'),'" + TxtCocuk.Text + "','" + MskCep.Text + "','" + MskSabit.Text + "','" + TxtEposta.Text + "',(Select DurumId From CalismaDurumu Where DurumAd='" + CmbCalisma.Text + "'),(Select AlanId From AlanBilgi Where AlanAd='" + CmbAlan.Text + "'),(Select KurumId From KurumBilgi Where KurumAd='" + CmbKurum.Text + "'),'" + DtpBaslama.Value.ToString("yyyy-MM-dd") + "','" + DtpAyrilma.Value.ToString("yyyy-MM-dd") + "','" + TxtBes.Text + "','" + TxtIban.Text + "','" + RtxtAdres.Text + "') ", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Personel Başarılı Bir Şekilde Kaydedildi!!");
                Temizle();
                VeriOku();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPersonelEkle_Load(object sender, EventArgs e)
        {
            Temizle();
            VeriOku();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            VeriKaydet();
        }
    }
}
