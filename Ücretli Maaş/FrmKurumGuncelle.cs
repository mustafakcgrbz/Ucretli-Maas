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
        private void Temizle()
        {
            CmbKurum.Items.Clear();
            TxtKurum.Clear();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ACER-LAPTOP;Initial Catalog=UcretliMaas;Integrated Security=True");
        private void VeriOku()
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
            
        }
        private void Guncelle()
        {
            if (CmbKurum.Text!="Kurum Seçiniz :")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update KurumBilgi Set KurumAd='" + TxtKurum.Text + "' Where KurumAd='" + CmbKurum.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Güncellendi!!");
                Temizle();
                VeriOku();
                CmbKurum.Text = "Kurum Seçiniz :";
                TxtKurum.Select();
                
            }
            else
            {
                MessageBox.Show("Lütfen Kurum Seçiniz!!");
            }
        }
        private void FrmKurumGuncelle_Load(object sender, EventArgs e)
        {
            Temizle();
            VeriOku();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}
