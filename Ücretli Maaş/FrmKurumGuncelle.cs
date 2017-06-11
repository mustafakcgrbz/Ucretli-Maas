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
    public partial class FrmKurumGuncelle : Form
    {
        public FrmKurumGuncelle()
        {
            InitializeComponent();
        }

        //SQL Bağlantısı yapılıyor
        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");

        //Form alanları temizleniyor
        private void Temizle()
        {
            CmbKurum.Items.Clear();
            TxtKurum.Clear();
        }
        
        //Kurumlar ComboBox' a ekleniyor
        private void VeriOku()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select KurumAd From KurumBilgi Order By KurumAd", baglanti);
                komut.ExecuteNonQuery();
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    CmbKurum.Items.Add(oku["KurumAd"].ToString());
                }

                baglanti.Close();
                CmbKurum.Text = "Kurum Seçiniz :";
                TxtKurum.Select();
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }

        }

        //Kurum Adı güncelleniyor
        private void Guncelle()
        {
            if (CmbKurum.Text!="Kurum Seçiniz :")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update KurumBilgi Set KurumAd='" + TxtKurum.Text + "' Where KurumAd='" + CmbKurum.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Başarıyla Güncellendi!!");
                    Temizle();
                    VeriOku();
                }
                catch
                {
                    MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kurum Seçiniz!!");
            }
        }

        //Kurum Siliniyor
        private void VeriSil()
        {
            DialogResult cevap = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat!!!", MessageBoxButtons.YesNo);
            if (cevap==DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Delete From KurumBilgi Where KurumAd='" + CmbKurum.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Silindi!!");
                    baglanti.Close();
                    Temizle();
                    VeriOku();
                }
                catch
                {
                    MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
                }
            }
        }

        //Form çalıştığında gerekli fonksiyonlar çalıştırılıyor
        private void FrmKurumGuncelle_Load(object sender, EventArgs e)
        {
            Temizle();
            VeriOku();
        }

        //Form çıkışı
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Güncelle butonu 
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }


        //Sil butonu
        private void BtnSil_Click(object sender, EventArgs e)
        {
            VeriSil();
        }
    }
}
