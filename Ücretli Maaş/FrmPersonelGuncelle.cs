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
    public partial class FrmPersonelGuncelle : Form
    {
        public FrmPersonelGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ACER-LAPTOP;Initial Catalog=UcretliMaas;Integrated Security=True");
        string id;
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

        }
        private void PersonelDoldur()
        {
            LstPersonel.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select PersonelId, KimlikNo, Adi, Soyadi From Personel Order By Adi", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["PersonelId"].ToString();
                ekle.SubItems.Add(oku["KimlikNo"].ToString());
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                LstPersonel.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void MedeniDurum()
        {
            baglanti.Open();
            SqlCommand komutm = new SqlCommand("Select DurumAd From MedeniDurum Where DurumId=(Select MedeniHal From Personel Where PersonelId='" + id + "')", baglanti);
            komutm.ExecuteNonQuery();
            SqlDataReader okum = komutm.ExecuteReader();
            if (okum.Read())
            {
                CmbMedeniDurum.Text = okum["DurumAd"].ToString();
            }

            baglanti.Close();

        }

        private void CalismaDurumu()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select DurumAd From CalismaDurumu Where DurumId=(Select Durum From Personel Where PersonelId='" + id + "')", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                CmbCalisma.Text = oku["DurumAd"].ToString();
            }
            baglanti.Close();
        }

        private void AlanGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select AlanAd From AlanBilgi Where AlanId=(Select Alan From Personel Where PersonelId='" + id + "')", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                CmbAlan.Text = oku["AlanAd"].ToString();
            }
            baglanti.Close();

        }

        private void KurumGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KurumAd From KurumBilgi Where KurumId=(Select Kurum From Personel Where PersonelId='" + id + "')", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                CmbKurum.Text = oku["KurumAd"].ToString();
            }
            baglanti.Close();
        }
        private void PersonelGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Personel Where PersonelId='" + id + "'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                TxtKimlik.Text = oku["KimlikNo"].ToString();
                TxtAd.Text = oku["Adi"].ToString();
                TxtSoyad.Text = oku["Soyadi"].ToString();
                TxtCocuk.Text = oku["CocukSayi"].ToString();
                MskCep.Text = oku["CepTelefonu"].ToString();
                MskSabit.Text = oku["SabitTelefon"].ToString();
                TxtEposta.Text = oku["EPosta"].ToString();
                DtpBaslama.Text = oku["BaslamaTarihi"].ToString();
                DtpAyrilma.Text = oku["AyrilmaTarihi"].ToString();
                TxtBes.Text = oku["BireyselEmeklilik"].ToString();
                RtxtAdres.Text = oku["Adres"].ToString();
                baglanti.Close();
                MedeniDurum();
                CalismaDurumu();
                AlanGetir();
                KurumGetir();

            }
            else
            {
                baglanti.Close();
            }
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
            PersonelDoldur();
            TxtKimlik.Select();
        }
        private void PersonelSil()
        {

            DialogResult cevap = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Personel Where PersonelId='" + id + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Silindi!!");
                Temizle();
                VeriOku();
            }
        }
    private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPersonelGuncelle_Load(object sender, EventArgs e)
        {
            Temizle();
            VeriOku();
        }

        private void LstPersonel_DoubleClick(object sender, EventArgs e)
        {
            id = LstPersonel.SelectedItems[0].SubItems[0].Text;
            PersonelGetir();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            PersonelSil();
        }
    }
}
