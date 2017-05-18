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
    public partial class FrmMaasHesapla : Form
    {
        public FrmMaasHesapla()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        SqlConnection baglantim = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        SqlConnection baglantip = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        Double Icra, Nafaka;
        String BordroNo, KimlikNo;

        private void BordroCek()
        {
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

        private void BordroDoldur()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Bordro Where BordroDurum='Acik Bordro' And Aciklama='"+CmbBordro.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                BordroNo = oku["BordroId"].ToString();                
                DtpBaslangic.Text = oku["BaslangicTarihi"].ToString();
                DtpBitis.Text = oku["BitisTarihi"].ToString();
                TxtAciklama.Text = oku["Aciklama"].ToString();
            }
            baglanti.Close();
        }

        private void FrmMaasHesapla_Load(object sender, EventArgs e)
        {
            BordroCek();
        }

        private void CmbBordro_SelectedIndexChanged(object sender, EventArgs e)
        {
            BordroDoldur();
        }

        private void IcraTopla()
        {
            //İcra Toplamı bulunacak
            baglantip.Open();
            SqlCommand komutp = new SqlCommand("Select Tutar From Kesinti Where BordroId='" + BordroNo + "' And KimlikNo='" + KimlikNo + "' And KesintiTuru='Icra'", baglantip);
            komutp.ExecuteNonQuery();
            SqlDataReader okup = komutp.ExecuteReader();
            while (okup.Read())
            {
                Icra += Convert.ToDouble(okup["Tutar"].ToString());
            }
            baglantip.Close();

        }

        private void NafakaTopla()
        {
            //Nafaka Toplamı bulunacak
        }
        private void GeciciHesap()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Puantaj Where BordroId=(Select BordroId From Bordro Where BordroDurum='Acik Bordro' And Aciklama='" + CmbBordro.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                baglantim.Open();
                SqlCommand komutm = new SqlCommand("Select * From MaasAyar", baglantim);
                komutm.ExecuteNonQuery();
                SqlDataReader okum = komutm.ExecuteReader();
                if (okum.Read())
                {
                    Double SaatUcreti, AylikTutar, SGKDevlet, Tahakkuk, SGKKesMatrah, SGKKisi, YVergiMatrah, AVergiMatrah, GelirVergi, DamgaVergi, ToplamKesinti, AGI, NetTutar;
                    int DersSaati, SGKGun;
                    SaatUcreti = Convert.ToDouble(okum["MaasKatsayi"].ToString()) * Convert.ToDouble(okum["EkdersKatsayi"].ToString());
                    DersSaati = Convert.ToInt32(oku["DersSaati"].ToString());
                    SGKGun = Convert.ToInt32( DersSaati / 7.5);
                    AylikTutar = SaatUcreti * DersSaati;
                    SGKDevlet = AylikTutar * Convert.ToDouble(okum["SGKDevlet"].ToString());
                    Tahakkuk = AylikTutar + SGKDevlet;
                    SGKKesMatrah = AylikTutar;
                    SGKKisi = AylikTutar * Convert.ToDouble(okum["SgkKisi"].ToString());
                    baglantip.Open();
                    SqlCommand komutp = new SqlCommand("Select KimlikNo, VergiMatrah From Personel Where PersonelId='" + oku["PersonelId"].ToString() + "'", baglantip);
                    komutp.ExecuteNonQuery();
                    SqlDataReader okup = komutp.ExecuteReader();
                    if (okup.Read())
                    {
                        KimlikNo = okup["KimlikNo"].ToString();
                        YVergiMatrah = Convert.ToDouble(okup["VergiMatrah"].ToString());
                    }
                    baglantip.Close();
                    AVergiMatrah = AylikTutar - SGKKisi;
                    GelirVergi = AVergiMatrah * Convert.ToDouble(okum["GelirVergiOran"].ToString());
                    DamgaVergi = AylikTutar * Convert.ToDouble(okum["DamgaVergiOran"].ToString());
                    Icra = 0;
                    IcraTopla();
                    MessageBox.Show(Icra.ToString());
                    Nafaka = 0;
                    NafakaTopla();


                }
                //SqlCommand komutp = new SqlCommand("Insert Into GeciciHesap (KimlikNo, SaatUcreti, DersSaati, SGKGun, AylikTutar, SGKDevlet, Tahakkuk, SGKKesMatrah, SGKKisi, YVergiMatrah, AVergiMatrah, DamgaVergi, Icra, Nafaka, ToplamKesinti, AGI, NetTutar) Values ((Select KimlikNo From Personel Where PersonelId='"+oku["PersonelId"].ToString()+"'), ((Select MaasKatsayi From MaasAyar)))");
                
                baglantim.Close();

            }
            baglanti.Close();
        }
        private void BtnGecici_Click(object sender, EventArgs e)
        {
            if (CmbBordro.Text != "Bordro Seçiniz :")
            {
                GeciciHesap();
            }
            else
            {
                MessageBox.Show("Lütfen Bordro Seçiniz!!");
            }
        }
    }
}
