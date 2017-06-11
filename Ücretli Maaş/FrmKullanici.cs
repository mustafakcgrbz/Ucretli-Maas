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

        //SQL bağlantısı yapılıyor
        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");


        //Form üzerindeki alanlar temizleniyor
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

        //Database' de kayıtlı kullanıcılar ComboBox' a ekleniyor
        private void KullaniciDoldur()
        {
            try
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
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
        }

        //Database' de kayıtlı Kurumlar ilgili ComboBox' a dolduruluyor
        private void KurumDoldur()
        {
            try
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
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
        }

        //Seçili kullanıcının bilgileri form alanlarına getiriliyor
        private void KullaniciGetir()
        {
            try
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
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
        }

        //Seçilen kullanıcıya ait Kurum bilgisi getiriliyor
        private void KurumGetir()
        {
            try
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
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
        }


        //Kullanıcı Kaydı yapılıyor
        private void KullaniciKaydet()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Kullanicilar (KullaniciAd, Parola, KurumId, Aciklama) Values ('" + TxtKullanici.Text + "', '" + TxtParola.Text + "', (Select KurumId From KurumBilgi Where KurumAd='" + CmbKurum.Text + "'), '" + RTxtAciklama.Text + "')", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kullanıcı Kaydı Yapıldı");
                Temizle();
                KullaniciDoldur();
                KurumDoldur();
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }

        }

        //Kullanıcı adı database' de kontrol ediliyor
        private void Kontrol()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select KullaniciAd From Kullanicilar Where KullaniciAd='" + TxtKullanici.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    MessageBox.Show("Aynı Kullanıcı Adı Sistemde Mevcut!!!");
                    baglanti.Close();
                }
                else
                {
                    baglanti.Close();
                    KullaniciKaydet();
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }

        }

        //Form çıkışı
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Form çalıştığında gerekli fonksiyonlar çağrılıyor
        private void FrmKullanici_Load(object sender, EventArgs e)
        {
            Temizle();
            KullaniciDoldur();
            KurumDoldur();
        }

        //Kaydet butonu
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Kontrol();
        }

        //ComboBox değiştiğinde seçili kullanıcı bilgileri için KullaniciGetir fonksiyonu çağrılıyor
        private void CmbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            KullaniciGetir();
        }

        //Form üzerindeki alanlar temizleniyor
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            KullaniciDoldur();
            KurumDoldur();
        }


        //Kullanıcı bilgileri güncelleniyor
        private void KullaniciGuncelle()
        {
            if (TxtKullanici.Text=="" | TxtParola.Text=="" | CmbKurum.Text=="")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun!!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update Kullanicilar Set KullaniciAd='" + TxtKullanici.Text + "', Parola='" + TxtParola.Text + "', KurumId=(Select KurumId From KurumBilgi Where KurumAd='" + CmbKurum.Text + "'), Aciklama='" + RTxtAciklama.Text + "' Where KullaniciAd='" + CmbKullanici.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Güncellendi!!");
                }
                catch
                {
                    MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
                }
            }
        }

        //Güncelle butonu kontrol ediliyor
        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Kullanıcıyı Güncellemek İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                KullaniciGuncelle();
            }
        }


        //Seçili kullanıcı siliniyor
        private void KullaniciSil()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Kullanicilar Where KullaniciAd='" + CmbKullanici.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kullanıcı Silindi!!");
                Temizle();
                KullaniciDoldur();
                KurumDoldur();
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
        }

        //Sil butonu kontrolü
        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Kullanıcıyı Silmek İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                KullaniciSil();
            }
        }
    }
}
