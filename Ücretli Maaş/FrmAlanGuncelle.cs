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
    public partial class FrmAlanGuncelle : Form
    {
        public FrmAlanGuncelle()
        {
            InitializeComponent();
        }

        //SQL Bağlantısı Yapılıyor.
        SqlConnection baglanti =new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");

        //Text Alanları Temizleniyor.
        private void Temizle()
        {
            CmbAlan.Items.Clear();
            TxtAlan.Clear();
            RtxtAciklama.Clear();            
            CmbAlan.Text = "Alan Seçiniz";
            CmbAlan.Select();
        }

        //Database Veri Okunuyor
        private void VeriOku()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select AlanAd From AlanBilgi Order By AlanAd", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    CmbAlan.Items.Add(oku["AlanAd"]);
                }

                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
        }

        //Kayıt Güncelleme
        private void VeriGuncelle()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update AlanBilgi Set AlanAd='" + TxtAlan.Text + "', Aciklama='" + RtxtAciklama.Text + "' Where AlanAd='" + CmbAlan.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                VeriOku();
                MessageBox.Show("Kayıt Başarıyla Güncellendi!!");
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
        }

        //Kayıt Silme
        private void VeriSil()
        {
            DialogResult cevap = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Delete From AlanBilgi Where AlanAd='" + CmbAlan.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Başarıyla Silindi!!");
                }
                catch
                {
                    MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
                }
                Temizle();
                VeriOku();
            }
        }

        //Form Çalıştığında Çağrılan Fonksiyonlar
        private void FrmAlanGuncelle_Load(object sender, EventArgs e)
        {
            Temizle();
            VeriOku();
        }


        //Form Çıkış
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Çıkmak İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                this.Close();
            }
        }


        //Güncelle Butonu ile VeriGuncelle Fonksiyonu çağrılıyor.
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            VeriGuncelle();
        }


        //Sil Fonksiyonu çağrılıyor.
        private void BtnSil_Click(object sender, EventArgs e)
        {
            VeriSil();
        }
    }
}
