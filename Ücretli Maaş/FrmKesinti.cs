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
        String Kimlik;
        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        SqlConnection baglantiek = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");

        private void Temizle()
        {
            TxtKimlikNo.Clear();
            TxtAd.Clear();
            TxtSoyad.Clear();
            TxtTutar.Clear();
            RtxtAciklama.Clear();
            CmbKesinti.Items.Clear();
            CmbKesinti.Text = "Kesinti Seçiniz :";
            CmbTur.Text = "Kesinti Türü Seçiniz";

        }
        private void BordroKontrol()
        {
            try
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
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
        }
        private void PersonelDoldur()
        {
            try
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
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
        }

        private void IcraGetir()
        {
            CmbKesinti.Items.Clear();
            CmbKesinti.Text = "Kesinti Seçiniz :";
            //Personele ait icraları getirecek
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Kesinti Where KimlikNo = '" + Kimlik + "' And BordroId='" + LblBordroNo.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    CmbKesinti.Items.Add(oku["Aciklama"].ToString());
                }
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
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

        private void IcraKaydet()
        {
            if (TxtKimlikNo.Text != "")
            {
                if (CmbTur.Text == "Kesinti Türü Seçiniz" | RtxtAciklama.Text == "" | TxtTutar.Text == "")
                {
                    MessageBox.Show("Lütfen Alanları Boş Bırakmayınız");
                }
                else
                {
                    try
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Insert Into Kesinti (KimlikNo, BordroId, Tutar, KesintiTuru, Aciklama) Values ('" + TxtKimlikNo.Text + "', '" + LblBordroNo.Text + "', '" + TxtTutar.Text + "', '" + CmbTur.Text + "', '" + RtxtAciklama.Text + "')", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kayıt Tamamlandı!!");
                        Temizle();
                        PersonelGetir();
                        IcraGetir();
                    }
                    catch
                    {
                        MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
                    }
                }
            }
            else
            {
                MessageBox.Show("Önce Personel Seçiniz");
            }
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            IcraKaydet();
        }
        private void PersonelGetir()
        {
            Temizle();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Personel Where KimlikNo='" + Kimlik + "'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    TxtKimlikNo.Text = oku["KimlikNo"].ToString();
                    TxtAd.Text = oku["Adi"].ToString();
                    TxtSoyad.Text = oku["Soyadi"].ToString();
                    baglanti.Close();
                    IcraGetir();

                }
                else
                {
                    baglanti.Close();
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }

        }
        private void LstPersonel_DoubleClick(object sender, EventArgs e)
        {
            Kimlik = LstPersonel.SelectedItems[0].SubItems[0].Text;
            PersonelGetir();
        }
         private void IcraDoldur()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Kesinti Where KimlikNo='" + TxtKimlikNo.Text + "' And BordroId='" + LblBordroNo.Text + "' And Aciklama='" + CmbKesinti.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    CmbTur.Text = oku["KesintiTuru"].ToString();
                    TxtTutar.Text = oku["Tutar"].ToString();
                    RtxtAciklama.Text = oku["Aciklama"].ToString();
                    baglanti.Close();
                }
                else
                {
                    baglanti.Close();
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }

        }
        private void CmbKesinti_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbKesinti_SelectedValueChanged(object sender, EventArgs e)
        {
            IcraDoldur();
        }

        private void IcraSil()
        {
            DialogResult cevap = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Delete From Kesinti Where KimlikNo='" + TxtKimlikNo.Text + "' And BordroId='" + LblBordroNo.Text + "' And Aciklama='" + CmbKesinti.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Temizle();
                    PersonelGetir();
                    IcraDoldur();
                    MessageBox.Show("Seçilen İcra Kaydı Silindi!!");
                }
                catch
                {
                    MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
                }

            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            IcraSil();
        }
    }
}
