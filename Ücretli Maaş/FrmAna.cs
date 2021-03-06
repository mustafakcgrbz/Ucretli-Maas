﻿using System;
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
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        //Tanımlama ve SQL Bağlantıları
        String id;
        SqlConnection baglanti = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");
        SqlConnection baglantiek = new SqlConnection("Data Source=85.214.46.212;Initial Catalog=mustafa_gurbuz_db;User ID=mustafa_gurbuz_user;Password=mustafa_gurbuz_user");

        //Ayar Formu çağrılıyor
        private void maasAyarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAyar ayarform = new FrmAyar();
            ayarform.ShowDialog();            

        }

        //Kurum Ekle Formu çağrılıyor
        private void kurumEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KurumEkle KurumEkleFrm = new KurumEkle();
            KurumEkleFrm.ShowDialog();
        }

        //Kurum Güncelleme Formu çağrılıyor
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKurumGuncelle frmguncelle = new FrmKurumGuncelle();
            frmguncelle.ShowDialog();
        }

        //Personel Ekleme Formu çağrılıyor
        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelEkle frmperekle = new FrmPersonelEkle();
            frmperekle.ShowDialog();
            PersonelDoldur();

        }

        //Alan Bilgisi Ekleme Formu çağrılıyor
        private void alanEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlanEkle AlanEkleFrm = new FrmAlanEkle();
            AlanEkleFrm.ShowDialog();
        }

        //Alan Bilgisi Güncelleme ve Silme Formu çağrılıyor.
        private void güncelleVeyaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlanGuncelle AlanGuncelleFrm = new FrmAlanGuncelle();
            AlanGuncelleFrm.ShowDialog();
        }


        //Personel Güncelleme ve Silme Formu Çağrılıyor
        private void güncelleVeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelGuncelle pguncellefrm = new FrmPersonelGuncelle();
            pguncellefrm.ShowDialog();
            PersonelDoldur();
        }

        //Uygulama Kullanıcı İşlemleri Formu çağrılıyor
        private void kullanıcıVeSifreislemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullanici Kullanici = new FrmKullanici();            
            Kullanici.ShowDialog();
        }


        private void FrmAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Bordro Açma Formu çağrılıyor       
        private void EkdersBordroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBordroAc bordrofrm = new FrmBordroAc();
            bordrofrm.ShowDialog();
            BordroGetir();

        }

        //Text Alanları Temizleniyor
        private void Temizle()
        {
            TxtKimlikNo.Clear();
            TxtAd.Clear();
            TxtSoyad.Clear();
            TxtEkders.Clear();

        }

        //Database Kayıtlarından Personeller ListView' e çekiliyor
        public void PersonelDoldur()
        {
            try
            {
                LstPersonel.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Personel Where Durum='1' Order By Kurum, Adi, Soyadi", baglanti);
                komut.ExecuteNonQuery();
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["PersonelId"].ToString();
                    ekle.SubItems.Add(oku["KimlikNo"].ToString());
                    ekle.SubItems.Add(oku["Adi"].ToString());
                    ekle.SubItems.Add(oku["Soyadi"].ToString());
                    baglantiek.Open();
                    SqlCommand komutb = new SqlCommand("Select BordroDurum, BordroId From Bordro Where BordroDurum='Acik Bordro'", baglantiek);
                    komutb.ExecuteNonQuery();
                    SqlDataReader okub = komutb.ExecuteReader();
                    if (okub.Read())
                    {
                        string BordroNo = okub["BordroId"].ToString();
                        baglantiek.Close();
                        baglantiek.Open();
                        SqlCommand komutek = new SqlCommand("Select DersSaati From Puantaj Where PersonelId='" + oku["PersonelId"].ToString() + "' And BordroId='" + BordroNo + "'", baglantiek);
                        komutek.ExecuteNonQuery();
                        SqlDataReader okuek = komutek.ExecuteReader();
                        if (okuek.Read())
                        {
                            ekle.SubItems.Add(okuek["DersSaati"].ToString());
                        }
                        else
                        {
                            ekle.SubItems.Add("0");
                        }
                        baglantiek.Close();
                    }
                    else
                    {
                        ekle.SubItems.Add("0");
                        baglantiek.Close();

                    }


                    baglantiek.Open();
                    SqlCommand komutk = new SqlCommand("Select KurumAd From KurumBilgi Where KurumId='" + oku["Kurum"].ToString() + "'", baglantiek);
                    komutk.ExecuteNonQuery();
                    SqlDataReader okuk = komutk.ExecuteReader();
                    if (okuk.Read())
                    {
                        ekle.SubItems.Add(okuk["KurumAd"].ToString());
                    }
                    baglantiek.Close();
                    LstPersonel.Items.Add(ekle);


                }
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }
        }

        //Database' den açık olan bordro varsa getiriliyor
        private void BordroGetir()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select BordroId, BaslangicTarihi, BitisTarihi, Aciklama From Bordro Where BordroDurum='Acik Bordro'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    LblBordroNo.Text = oku["BordroId"].ToString();
                    LblAciklama.Text = oku["Aciklama"].ToString();
                    DtpBaslangic.Text = oku["BaslangicTarihi"].ToString();
                    DtpBitis.Text = oku["BitisTarihi"].ToString();
                    baglanti.Close();
                }
                else
                {
                    TxtEkders.Enabled = false;
                    baglanti.Close();
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }

        }

        //Ana Form çalıştığında BordroGetir ve PersonelDoldur fonksiyonları çağrılıyor
        private void FrmAna_Load(object sender, EventArgs e)
        {
            BordroGetir();         
            PersonelDoldur();
        }

        //Uygulama Çıkışı
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Çıkmak İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Açık Bordro Kontrolü yapılıyor
        private void BordroKontrol()
        {
            if (LblBordroNo.Text == "0")
            {
                MessageBox.Show("Açık Ekders Bordrosu Bulunamadı!!");
            }
            else
            {
                EkdersGuncelle();
            }
        }


        //ListView de bulanan personellerin Ekders güncellemesi yapılıyor
        private void EkdersGuncelle()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Puantaj Set DersSaati='" + TxtEkders.Text + "', KurumId=(Select KurumId From KurumBilgi Where KurumAd='" + LstPersonel.SelectedItems[0].SubItems[5].Text + "') Where PersonelId='" + id + "' And BordroId='" + LblBordroNo.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                PersonelDoldur();
                MessageBox.Show("Ekders Başarıyla Güncellendi!!");
            }
            catch
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu");
            }

        }

        //Güncelle Butonu önce BordroKontrolü yapılıyor
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            BordroKontrol();
        }


        //ListView de bulunan personellerden seçili olanın bilgilerini TextBox alanına getiriyor
        private void PersonelGetir()
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Personel Where PersonelId='" + id + "'", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                TxtKimlikNo.Text = oku["KimlikNo"].ToString();
                TxtAd.Text = oku["Adi"].ToString();
                TxtSoyad.Text = oku["Soyadi"].ToString();
                TxtEkders.Select();


            }
            baglanti.Close();
        }

        //ListView çift tıklama ile id değişkenine personel no getiriliyor ve PersonelGetir fonksiyonu çağrılıyor
        private void LstPersonel_DoubleClick(object sender, EventArgs e)
        {
            id = LstPersonel.SelectedItems[0].SubItems[0].Text;
            PersonelGetir();
        }


        //Kesinti Formu çağrılıyor
        private void kesintiEkleVeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKesinti frmkesinti = new FrmKesinti();
            frmkesinti.ShowDialog();
        }

        //Maaş Hesaplama Formu çağrılıyor
        private void MaasHesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaasHesapla frmMaas = new FrmMaasHesapla();
            frmMaas.ShowDialog();

        }
    }
}
