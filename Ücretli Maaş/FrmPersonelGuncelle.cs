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

        //SQL bağlantısı yapılıyor
        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        string id;

        //Formda bulunan Textboxlar ve Açılır Kutular Temizleniyor.
        private void Temizle()
        {            
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

        //Personeller ListView' e ekleniyor
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


        //Seçilen personelin medeni durum bilgisi ilgili ComboBox' a getiriliyor
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

        //Seçilen personelin çalışma durumu bilgisi ilgili ComboBox' a getiriliyor
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

        //Seçilen personelin alan bilgisi ilgili ComboBox' a getiriliyor
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

        //Seçilen personelin kurum bilgisi ilgili ComboBox' a getiriliyor
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

        //Seçili personelin bilgileri form alanlarına getiriliyor
        private void PersonelGetir()
        {
            try
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
                    TxtIban.Text = oku["IbanNo"].ToString();
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
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
        }

        //MedeniDurum ilgili ComboBox' a ekleniyor
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


        //Çalışma Durumu ilgili ComboBox' a ekleniyor
        private void CDurumOku()
        {            
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

        //Alan bilgisi ilgili ComboBox' a ekleniyor
        private void AlanOku()
        {            
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

        //Kurum bilgisi ilgili ComboBox' a ekleniyor
        private void KurumOku()
        {            
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

        //ComboBoxlar ilgili bilgilerle dolduruluyor
        private void VeriOku()
        {
            try
            {
                MDurumOku();
                CDurumOku();
                AlanOku();
                KurumOku();
                PersonelDoldur();
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
            finally
            {
                TxtKimlik.Select();
            }
        }

        //Seçili personel siliniyor
        private void PersonelSil()
        {

            DialogResult cevap = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Delete From Personel Where PersonelId='" + id + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Başarıyla Silindi!!");
                    Temizle();
                    VeriOku();
                }
                catch
                {
                    MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
                }
            }
        }

        //Form çıkışı
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Güncelle butonu
        private void FrmPersonelGuncelle_Load(object sender, EventArgs e)
        {
            Temizle();
            VeriOku();
        }


        //ListView çift tıklama ile personel seçiyor
        private void LstPersonel_DoubleClick(object sender, EventArgs e)
        {
            id = LstPersonel.SelectedItems[0].SubItems[0].Text;
            PersonelGetir();
        }


        //Seçili personel bilgileri güncelleniyor
        private void PersonelGuncelle()
        {
            if (CmbMedeniDurum.Text == "Durum Seçiniz :" | CmbCalisma.Text == "Durum Seçiniz :" | CmbAlan.Text == "Alan Seçiniz :" | CmbKurum.Text == "Kurum Seçiniz :")
            {
                MessageBox.Show("Lütfen Gerekli Bölümleri Seçiniz!!");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update Personel Set KimlikNo='" + TxtKimlik.Text + "', Adi='" + TxtAd.Text + "', Soyadi='" + TxtSoyad.Text + "', MedeniHal=(select DurumId From MedeniDurum Where DurumAd='" + CmbMedeniDurum.Text + "'), CocukSayi='" + TxtCocuk.Text + "', CepTelefonu='" + MskCep.Text + "', SabitTelefon='" + MskSabit.Text + "', EPosta='" + TxtEposta.Text + "', Durum=(Select DurumId From CalismaDurumu Where DurumAd='" + CmbCalisma.Text + "'), Alan=(Select AlanId From AlanBilgi Where AlanAd='" + CmbAlan.Text + "'), Kurum=(Select KurumId From KurumBilgi Where KurumAd='" + CmbKurum.Text + "'), BaslamaTarihi='" + DtpBaslama.Value.ToString("yyyy-MM-dd") + "', AyrilmaTarihi='" + DtpAyrilma.Value.ToString("yyyy-MM-dd") + "', BireyselEmeklilik='" + TxtBes.Text + "',IbanNo='" + TxtIban.Text + "', Adres='" + RtxtAdres.Text + "' Where PersonelId='" + id + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Başarıyla Güncellendi!!");
                }
                catch
                {
                    MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
                }

            }
        }

        //Güncelle butonu
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            PersonelGuncelle();
            Temizle();
            VeriOku();
            PersonelGetir();
        }

        //Sil butonu
        private void BtnSil_Click(object sender, EventArgs e)
        {
            PersonelSil();
        }
    }
}
