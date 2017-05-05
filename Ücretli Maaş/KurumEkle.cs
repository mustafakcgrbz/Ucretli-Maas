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
    public partial class KurumEkle : Form
    {
        public KurumEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ACER-LAPTOP;Initial Catalog=UcretliMaas;Integrated Security=True");
        private void VeriKaydet()
        {
            baglanti.Open();
            SqlCommand komutk = new SqlCommand("Select * From KurumBilgi Where KurumAd='"+TxtKurumAd.Text+"'",baglanti);
            komutk.ExecuteNonQuery();
            SqlDataReader oku = komutk.ExecuteReader();
            
            if (oku.Read())
            {
                MessageBox.Show("Eklemek İstediğiniz Kurum Sistemde Bulunmakta!!!");
            }
            else
            {
                baglanti.Close();
                baglanti.Open();

                SqlCommand komut = new SqlCommand("Insert Into KurumBilgi (KurumAd) Values ('" + TxtKurumAd.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kurum Başarıyla Kaydedilmiştir!!!");
                
            }
            baglanti.Close();
        }
        private void Temizle()
        {
            TxtKurumAd.Clear();
        }
        private void KurumEkle_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            VeriKaydet();
            Temizle();
            TxtKurumAd.Select();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
