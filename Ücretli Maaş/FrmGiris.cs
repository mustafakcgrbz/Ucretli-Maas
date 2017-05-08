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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        string KurumId;
        private void Giris()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KurumId From Kullanicilar Where KullaniciAd='" + TxtKullanici.Text + "' And Parola='" + TxtParola.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                 KurumId= oku["KurumId"].ToString();
                if (oku["KurumId"].ToString() == "1")
                {
                    FrmAna AnaFrm = new FrmAna();
                    AnaFrm.Show();
                    this.Visible = false;
                }
                else
                {
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komutk = new SqlCommand("Select KurumAd From KurumBilgi Where KurumId='" + KurumId + "'", baglanti);
                    komutk.ExecuteNonQuery();
                    SqlDataReader okuk = komutk.ExecuteReader();
                    if (okuk.Read())
                    {
                        FrmOkul OkulFrm = new FrmOkul();
                        OkulFrm.LblKurumAd.Text = okuk["KurumAd"].ToString();
                        OkulFrm.Show();
                        this.Visible = false;
                    }
                    
                }
                
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı!!");
            }
            baglanti.Close();
        }
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            Giris();            
            
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
