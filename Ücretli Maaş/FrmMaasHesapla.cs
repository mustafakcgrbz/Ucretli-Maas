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
        Double AsgariUcret, AgiKatsayi, SaatUcreti, AylikTutar, SGKDevlet, Tahakkuk, SGKKesMatrah, SGKKisi, YVergiMatrah, AVergiMatrah, GelirVergi, DamgaVergi, Icra, Nafaka, ToplamKesinti, AGI, NetTutar;
        int DersSaati, SGKGun, CocukSayi;
        String BordroNo, KimlikNo, EsDurum;
        int Durum = 0;
        private void KesinHesap()
        {
            
            //Kesin Hesaplama Yapılacak ve Vergi Matrahları Toplanacak
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From GeciciHesap", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Double ToplamMatrah = 0;
                ToplamMatrah = Math.Round((Convert.ToDouble(oku["YVergiMatrah"].ToString()) + Convert.ToDouble(oku["AVergiMatrah"].ToString())), 2);
                KimlikNo = oku["KimlikNo"].ToString();
                NetTutar = Convert.ToDouble( oku["NetTutar"].ToString());
                baglantim.Open();
                SqlCommand komutm = new SqlCommand("Insert Into KesinHesap Values('"+BordroNo+"', '" + oku["KimlikNo"].ToString() + "', '" + oku["SaatUcreti"].ToString() + "','" + oku["DersSaati"].ToString() + "', '" + oku["SGKGun"].ToString() + "', '" + oku["AylikTutar"].ToString() + "', '" + oku["SGKDevlet"].ToString() + "', '" + oku["Tahakkuk"].ToString() + "', '" + oku["SGKKesMatrah"].ToString() + "', '" + oku["SGKKisi"].ToString() + "', '" + oku["YVergiMatrah"].ToString() + "', '" + oku["AVergiMatrah"].ToString() + "', '" + oku["GelirVergi"].ToString() + "', '" + oku["DamgaVergi"].ToString() + "', '" + oku["Icra"].ToString() + "', '" + oku["Nafaka"].ToString() + "', '" + oku["ToplamKesinti"].ToString() + "', '" + oku["AGI"].ToString() + "', '" + oku["NetTutar"].ToString() + "')", baglantim);
                komutm.ExecuteNonQuery();
                baglantim.Close();
                baglantip.Open();
                SqlCommand komutp = new SqlCommand("Update Personel Set VergiMatrah ='" + ToplamMatrah.ToString() + "' Where KimlikNo='" + oku["KimlikNo"].ToString() + "'", baglantip);
                komutp.ExecuteNonQuery();
                baglantip.Close();
                BankaListe();
                BordroKapat();
                BordroNo = null;
                BordroCek();

            }
            baglanti.Close();
            MessageBox.Show("Kesin Hesaplama Tamamlandı");


        }
        private void BtnKesin_Click(object sender, EventArgs e)
        {
            if (BordroNo!=null && Durum!=0)
            {
                DialogResult cevap = MessageBox.Show("Kesin Hesaplama Yapıldıktan Sonra Düzelme Yapılamayacaktır!!", "Dikkat", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.Yes)
                {
                    KesinHesap();
                }
                else
                {
                    MessageBox.Show("Kesin Hesaplama İptal Edildi!!");
                }
            }
            else
            {
                MessageBox.Show("Bordro Seçilmedi veya Geçici Hesaplama Yapılmadı");
            }
            
        }

        private void BankaListe()
        {
            //Banka Listesi Hazırlanıyor
            baglantim.Open();
            SqlCommand komutm = new SqlCommand("Select Adi, Soyadi, IbanNo From Personel Where KimlikNo='" + KimlikNo + "'", baglantim);
            komutm.ExecuteNonQuery();
            SqlDataReader okum = komutm.ExecuteReader();
            if (okum.Read())
            {
                baglantip.Open();
                SqlCommand komutp = new SqlCommand("Insert Into BankaListe Values('"+KimlikNo+"', '"+okum["Adi"].ToString()+"', '"+okum["Soyadi"].ToString()+"', '"+okum["IbanNo"].ToString()+"', '"+NetTutar.ToString()+"')",baglantip);
                komutp.ExecuteNonQuery();
                baglantip.Close();
            }
        
            baglantim.Close();
        }

        private void BordroKapat()
        {
            baglantip.Open();
            SqlCommand komutp = new SqlCommand("Update Bordro Set BordroDurum='Kapali Bordro' Where BordroId='" + BordroNo + "'", baglantip);
            komutp.ExecuteNonQuery();
            baglantip.Close();
        }
        private void BtnKontrol_Click(object sender, EventArgs e)
        {
            FrmHesapRapor raporfrm = new FrmHesapRapor();
            raporfrm.Show();
        }

        

        private void BordroCek()
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
            CmbBordro.Text = "Bordro Seçiniz :";
            TxtAciklama.Clear();
            
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
                Icra =Icra+ Math.Round(Convert.ToDouble(okup["Tutar"].ToString()), 2);
            }
            baglantip.Close();

        }

        private void NafakaTopla()
        {
            //Nafaka Toplamı Bulacak
            baglantip.Open();
            SqlCommand komutp= new SqlCommand("Select Tutar From Kesinti Where BordroId='" + BordroNo + "' And KimlikNo='" + KimlikNo + "' And KesintiTuru='Nafaka'", baglantip);
            komutp.ExecuteNonQuery();
            SqlDataReader okup = komutp.ExecuteReader();
            while (okup.Read())
            {
                Nafaka = Nafaka+Math.Round(Convert.ToDouble(okup["Tutar"].ToString()), 2);
            }
            baglantip.Close();
        }

        private void DegerSifirla()
        {
            SaatUcreti = 0;
            AylikTutar = 0;
            SGKDevlet = 0;
            Tahakkuk = 0;
            SGKKesMatrah = 0;
            SGKKisi = 0;
            YVergiMatrah = 0;
            AVergiMatrah = 0;
            GelirVergi = 0;
            DamgaVergi = 0;
            Icra = 0;
            Nafaka = 0;
            ToplamKesinti = 0;
            AGI = 0;
            NetTutar=0;
            DersSaati = 0;
            SGKGun=0;            
            KimlikNo="";
            EsDurum = "0";
            CocukSayi = 0;
        }

        private void GeciciKayit()
        {
            baglantip.Open();
            SqlCommand komutp = new SqlCommand("Insert Into GeciciHesap (KimlikNo, SaatUcreti, DersSaati, SGKGun, AylikTutar, SGKDevlet, Tahakkuk, SGKKesMatrah, SGKKisi, YVergiMatrah, AVergiMatrah, GelirVergi, DamgaVergi, Icra, Nafaka, ToplamKesinti, AGI, NetTutar) Values ('" + KimlikNo.ToString() + "', '" + SaatUcreti.ToString() + "', '" + DersSaati.ToString() + "', '" + SGKGun.ToString() + "', '" + AylikTutar.ToString() + "', '" + SGKDevlet.ToString() + "', '" + Tahakkuk.ToString() + "', '" + SGKKesMatrah.ToString() + "', '" + SGKKisi.ToString() + "', '" + YVergiMatrah.ToString() + "', '" + AVergiMatrah.ToString() + "', '" + GelirVergi.ToString() + "', '" + DamgaVergi.ToString() + "', '" + Icra.ToString() + "', '" + Nafaka.ToString() + "', '" + ToplamKesinti.ToString() + "', '" + AGI.ToString() + "', '" + NetTutar.ToString() + "')", baglantip);
            komutp.ExecuteNonQuery();            
            baglantip.Close();
        }

        private void TabloTemizle()
        {            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From GeciciHesap", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                baglanti.Close();
                baglanti.Open();
                SqlCommand komuts = new SqlCommand("Truncate Table GeciciHesap", baglanti);
                komuts.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Close();
            }
            baglantim.Open();
            SqlCommand komutm = new SqlCommand("Select * From BankaListe", baglantim);
            komutm.ExecuteNonQuery();
            SqlDataReader okum = komutm.ExecuteReader();
            if (okum.Read())
            {
                baglantim.Close();
                baglantim.Open();
                SqlCommand komuts = new SqlCommand("Truncate Table BankaListe", baglantim);
                komuts.ExecuteNonQuery();
                baglantim.Close();
            }
            else
            {
                baglantim.Close();
            }
            
        }

        
        private void AgiHesapla()
        {
            AgiKatsayi = 50;
            if (CocukSayi<3)
            {
                AgiKatsayi = AgiKatsayi + (CocukSayi * 7.5);
            }
            else if (CocukSayi==3)
            {
                AgiKatsayi += 25;
            }
            else if (CocukSayi==4)
            {
                AgiKatsayi += 30;
            }
            if (EsDurum=="3")
            {
                AgiKatsayi += 10;
            }
            else if (CocukSayi>4)
            {
                AgiKatsayi += 5;
            }
            AGI = Math.Round((AgiKatsayi * AsgariUcret / 100) * 15 / 100, 2);
            if (AGI>226.63)
            {
                AGI = 209.63;
            }
            if (AGI>GelirVergi)
            {
                AGI = GelirVergi;
            }
        }
        private void GeciciHesap()
        {
            TabloTemizle();
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
                    DegerSifirla();
                    AsgariUcret = Math.Round(Convert.ToDouble(okum["AsgariUcret"].ToString()),2);
                    SaatUcreti = Math.Round((Convert.ToDouble(okum["MaasKatsayi"].ToString()) * Convert.ToDouble(okum["EkdersKatsayi"].ToString())),2);
                    DersSaati = Convert.ToInt32(oku["DersSaati"].ToString());
                    SGKGun = Convert.ToInt32( DersSaati / 7.5);
                    AylikTutar = Math.Round((SaatUcreti * DersSaati),2);
                    SGKDevlet = Math.Round((AylikTutar * Convert.ToDouble(okum["SGKDevlet"].ToString())), 2);
                    Tahakkuk = Math.Round((AylikTutar + SGKDevlet),2);
                    SGKKesMatrah = Math.Round(AylikTutar,2);
                    SGKKisi = Math.Round((AylikTutar * Convert.ToDouble(okum["SgkKisi"].ToString())), 2);
                    baglantip.Open();
                    SqlCommand komutp = new SqlCommand("Select KimlikNo, MedeniHal, CocukSayi, VergiMatrah From Personel Where PersonelId='" + oku["PersonelId"].ToString() + "'", baglantip);
                    komutp.ExecuteNonQuery();
                    SqlDataReader okup = komutp.ExecuteReader();
                    if (okup.Read())
                    {
                        KimlikNo = okup["KimlikNo"].ToString();
                        EsDurum = okup["MedeniHal"].ToString();
                        CocukSayi = Convert.ToInt32(okup["CocukSayi"].ToString());
                        YVergiMatrah = Math.Round(Convert.ToDouble(okup["VergiMatrah"].ToString()),2);
                    }
                    baglantip.Close();
                    AVergiMatrah = Math.Round((AylikTutar - SGKKisi),2);
                    GelirVergi = Math.Round((AVergiMatrah * Convert.ToDouble(okum["GelirVergiOran"].ToString()) / 100), 2);
                    DamgaVergi = Math.Round((AylikTutar * Convert.ToDouble(okum["DamgaVergiOran"].ToString())), 2);                    
                    IcraTopla();                                      
                    NafakaTopla();
                    ToplamKesinti = Math.Round((GelirVergi + DamgaVergi + Icra + Nafaka), 2);
                    AgiHesapla();
                    NetTutar = Math.Round((Tahakkuk - ToplamKesinti + AGI), 2);
                    GeciciKayit();

                }
                //SqlCommand komutp = new SqlCommand("Insert Into GeciciHesap (KimlikNo, SaatUcreti, DersSaati, SGKGun, AylikTutar, SGKDevlet, Tahakkuk, SGKKesMatrah, SGKKisi, YVergiMatrah, AVergiMatrah, DamgaVergi, Icra, Nafaka, ToplamKesinti, AGI, NetTutar) Values ((Select KimlikNo From Personel Where PersonelId='"+oku["PersonelId"].ToString()+"'), ((Select MaasKatsayi From MaasAyar)))");
                
                baglantim.Close();

            }
            baglanti.Close();
            MessageBox.Show("Hesaplama Tamamlandı!!");
        }
        private void BtnGecici_Click(object sender, EventArgs e)
        {
            if (CmbBordro.Text != "Bordro Seçiniz :")
            {
                GeciciHesap();
                Durum = 1;
            }
            else
            {
                MessageBox.Show("Lütfen Bordro Seçiniz!!");
            }
        }
    }
}
