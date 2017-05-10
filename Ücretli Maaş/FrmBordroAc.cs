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
    public partial class FrmBordroAc : Form
    {
        public FrmBordroAc()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        SqlConnection baglantip = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        private void Olustur()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into Bordro (BordroDurum, BaslangicTarihi, BitisTarihi, Aciklama) Values ('Acik Bordro', '" + DtpBaslangic.Value.ToString("yyyy-MM-dd") + "','" + DtpBitis.Value.ToString("yyyy-MM-dd") + "','" + TxtAciklama.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            PuantajOlustur();
            MessageBox.Show("Bordro Başarıyla Oluşturuldu!!");
        }

        private void PuantajOlustur()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select PersonelId, From Personel Where Durum='1'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                baglantip.Open();
                SqlCommand komutp = new SqlCommand("Insert Into Puantaj (BordroId, PersonelId, KurumId, KullaniciAd, DersSaati) Values ((Select BordroId From Bordro Where BordroDurum='Acik Bordro'), '" + oku["PersonelId"].ToString() + "','0', '', '0')", baglantip);
                komutp.ExecuteNonQuery();
                baglantip.Close();
            }
            baglanti.Close();
        }
        private void Kontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Aciklama From Bordro Where BordroDurum='Acik Bordro'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Şu Anda Açık Bordro Bulunmaktadır ve Kapatılmadan Yeni Bordro Açılamaz!!");
            }
            else
            {
                baglanti.Close();
                Olustur();
            }
            baglanti.Close();
        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BordroOku()
        {
            CmbBordro.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Bordro Where BordroDurum='Acik Bordro'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                CmbBordro.Items.Add(oku["Aciklama"].ToString());
                
            }
            baglanti.Close();
        }
        private void FrmBordroAc_Load(object sender, EventArgs e)
        {
            BordroOku();
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            Kontrol();
        }

        private void Temizle()
        {
            DtpBaslangic.Text = "";
            DtpBitis.Text = "";
            TxtAciklama.Clear();
            BordroOku();
            CmbBordro.Text = "Bordro Seçiniz :";
        }
        private void BordroDoldur()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Bordro Where Aciklama='" + CmbBordro.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                DtpBaslangic.Text = oku["BaslangicTarihi"].ToString();
                DtpBitis.Text = oku["BitisTarihi"].ToString();
                TxtAciklama.Text = oku["Aciklama"].ToString();
            }
            baglanti.Close();
        }

        private void BordroSil()
        {
            DialogResult cevap = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                baglanti.Open();
                baglantip.Open();
                SqlCommand komut = new SqlCommand("Delete From Puantaj Where BordroId=(Select BordroId From Bordro Where Aciklama='" + CmbBordro.Text + "' And BordroDurum='Acik Bordro')", baglanti);
                komut.ExecuteNonQuery();
                SqlCommand komutp = new SqlCommand("Delete From Bordro Where Aciklama ='" + CmbBordro.Text + "' And BordroDurum='Acik Bordro'", baglantip);
                komutp.ExecuteNonQuery();

                baglanti.Close();
                baglantip.Close();
                Temizle();
                MessageBox.Show("Bordro Başarıyla Silindi!!");

            }
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (CmbBordro.Text!="Bordro Seçiniz :")
            {
                BordroSil();
            }
            else
            {
                MessageBox.Show("Bordro Seçiniz!!");
            }
            
        }

        private void CmbBordro_SelectedIndexChanged(object sender, EventArgs e)
        {
            BordroDoldur();
        }
    }
}
