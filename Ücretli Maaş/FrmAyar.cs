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
    public partial class FrmAyar : Form
    {
        public FrmAyar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        private void VeriGoster()
        {            
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("Select * From MaasAyar",baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                TxtMaasKatsayi.Text = oku["MaasKatsayi"].ToString();
                TxtEkdersKatsayi.Text = oku["EkdersKatsayi"].ToString();
                TxtAsgariUcret.Text = oku["AsgariUcret"].ToString();
                TxtGVergi.Text = oku["GelirVergiOran"].ToString();
                TxtDVergi.Text = oku["DamgaVergiOran"].ToString();
                TxtSgkDevlet.Text = oku["SgkDevlet"].ToString();
                TxtSgkKisi.Text = oku["SgkKisi"].ToString();
                TxtBesOran.Text = oku["BESOran"].ToString();
                TxtVergi20.Text = oku["Vergi20"].ToString();
                TxtVergi27.Text = oku["Vergi27"].ToString();
            }
            baglanti.Close();
        }
        private void VeriKaydet()
        {   
                     
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into MaasAyar (MaasKatsayi, EkdersKatsayi, AsgariUcret, GelirVergiOran, DamgaVergiOran, SgkDevlet, SgkKisi, BESOran, Vergi20, Vergi27) Values ('"+ TxtMaasKatsayi.Text + "','"+ TxtEkdersKatsayi.Text+"','"+ TxtAsgariUcret.Text+"','"+ TxtGVergi.Text+"','"+TxtDVergi.Text+"','"+TxtSgkDevlet.Text+"','"+TxtSgkKisi.Text+"','"+TxtBesOran.Text+"','"+TxtVergi20.Text+"','"+TxtVergi27.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ayarlar Başarıyla Güncellendi!!");
            baglanti.Close();
        }
        private void VeriTemizle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Truncate Table MaasAyar", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Temizle()
        {
            TxtMaasKatsayi.Clear();
            TxtEkdersKatsayi.Clear();
            TxtAsgariUcret.Clear();
            TxtGVergi.Clear();
            TxtDVergi.Clear();
            TxtSgkDevlet.Clear();
            TxtSgkKisi.Clear();
            TxtBesOran.Clear();
            TxtVergi20.Clear();
            TxtVergi27.Clear();
        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void FrmAyar_Load(object sender, EventArgs e)
        {
            VeriGoster();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            VeriTemizle();
            VeriKaydet();
            Temizle();
            VeriGoster();
        }
    }
}
