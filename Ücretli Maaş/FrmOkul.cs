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

        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        
        private void PersonelDoldur()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select PersonelId, KimlikNo, Adi, Soyadi From Personel Where Kurum=(Select KurumId From KurumBilgi Where KurumAd='" + LblKurumAd.Text + "') And Durum='1' Order By Adi,Soyadi", baglanti);
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
        private void FrmOkul_Load(object sender, EventArgs e)
        {
            //LblKurumAd.Text = "İl Milli Eğitim Müdürlüğü";
            PersonelDoldur();
        }

        private void FrmOkul_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
