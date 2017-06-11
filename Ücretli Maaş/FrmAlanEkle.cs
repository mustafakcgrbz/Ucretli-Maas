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
    public partial class FrmAlanEkle : Form
    {
        public FrmAlanEkle()
        {
            InitializeComponent();
        }
        //SQL Bağlantısı Yapılıyor
        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        //Text Alanları Temizleniyor
        private void Temizle()
        {
            TxtAlan.Clear();
            RtxtAciklama.Clear();
            TxtAlan.Select();
        }

        //Database Kayıt Ekleme
        private void VeriEkle()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into AlanBilgi Values('" + TxtAlan.Text + "','" + RtxtAciklama.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarıyla Eklendi!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Esnasında Hata Oluştu");
            }
            finally
            {
                baglanti.Close();
                Temizle();
            }

        }
        //Form Çıkışı
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Çıkmak İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmAlanEkle_Load(object sender, EventArgs e)
        {

        }

        //Kaydet Butonu VeriEkle Fonksiyonunu Çağırıyor.
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            VeriEkle();
        }
    }
}
