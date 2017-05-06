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
        SqlConnection baglanti = new SqlConnection("Data Source=ACER-LAPTOP;Initial Catalog=UcretliMaas;Integrated Security=True");
        private void Temizle()
        {
            TxtAlan.Clear();
            RtxtAciklama.Clear();
            TxtAlan.Select();
        }

        private void VeriEkle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into AlanBilgi Values('" + TxtAlan.Text + "','" + RtxtAciklama.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıyla Eklendi!!");

            baglanti.Close();
            Temizle();

        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAlanEkle_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            VeriEkle();
        }
    }
}
