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
    public partial class FrmKesinti : Form
    {
        public FrmKesinti()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        SqlConnection baglantiek = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");

        private void BordroKontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Bordro Where BordroDurum='Acik Bordro'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                LblBordroNo.Text = oku["BordroId"].ToString();
                LblAciklama.Text = oku["Aciklama"].ToString();
            }
            else
            {
                LblAciklama.Text = "Açık Bordro Yok!!";
                TxtTutar.Enabled = false;
            }
            baglanti.Close();
        }
        private void PersonelDoldur()
        {
            LstPersonel.Items.Clear();
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select KimlikNo, Adi, Soyadi, Kurum From Personel Where Durum='1' Order By Adi,Soyadi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {                
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["KimlikNo"].ToString();                
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                baglantiek.Open();
                SqlCommand komutek = new SqlCommand("Select KurumAd From KurumBilgi Where KurumId='" + oku["Kurum"].ToString() + "'", baglantiek);
                komutek.ExecuteNonQuery();
                SqlDataReader okuek = komutek.ExecuteReader();
                if (okuek.Read())
                {
                    ekle.SubItems.Add(okuek["KurumAd"].ToString());

                }
                LstPersonel.Items.Add(ekle);
                baglantiek.Close();
            }
            baglanti.Close();
        }
        private void FrmKesinti_Load(object sender, EventArgs e)
        {
            BordroKontrol();
            PersonelDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Çıkmak İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
