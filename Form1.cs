/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** PROJE NUMARASI.........: 01
** ÖĞRENCİ ADI............: Orhan Oğuz Tan
** ÖĞRENCİ NUMARASI.......: b141200034
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NdpProject
{
    public partial class Form1 : Form
    {
        Form2 SecimIslemi = new Form2();
        Form4 DukkanIslemleri=new Form4();
        public Form1()
        {
            InitializeComponent();
        }
        public static KasaGorevlisi yeniKasiyer = new KasaGorevlisi();
        public static KasaGorevlisi GirisYapanKasaGorevlisi = new KasaGorevlisi();
        public static KasaGorevlisi KasaGorevlisi1 = new KasaGorevlisi("AHMET", "YILMAZ", "1" , 11612783927);
        public static KasaGorevlisi KasaGorevlisi2 = new KasaGorevlisi("ERAY", "KÜTÜK","2",18263739672);
        public static KasaGorevlisi KasaGorevlisi3 = new KasaGorevlisi("FATİH", "KALKANLI","3",93678163906);

        private void btnKasiyerGiris_Click(object sender, EventArgs e)
        {
            GirisYapanKasaGorevlisi.Ad = txtKasiyerAd.Text.ToUpper();
            GirisYapanKasaGorevlisi.Soyad = txtKasiyerSoyadi.Text.ToUpper();
            GirisYapanKasaGorevlisi.SigortaNo = txtSigortaNo.Text.ToUpper();


            if (GirisYapanKasaGorevlisi.Ad==KasaGorevlisi1.Ad && GirisYapanKasaGorevlisi.Soyad == KasaGorevlisi1.Soyad && GirisYapanKasaGorevlisi.SigortaNo == KasaGorevlisi1.SigortaNo)
            {
                GirisYapanKasaGorevlisi.KisiBilgisiDoldur(txtKasiyerAd.Text, txtKasiyerSoyadi.Text, txtSigortaNo.Text);
                SecimIslemi.Show();
                this.Hide();
            }
            else if (GirisYapanKasaGorevlisi.Ad == KasaGorevlisi2.Ad && GirisYapanKasaGorevlisi.Soyad == KasaGorevlisi2.Soyad && GirisYapanKasaGorevlisi.SigortaNo == KasaGorevlisi2.SigortaNo)
            {
                GirisYapanKasaGorevlisi.KisiBilgisiDoldur(txtKasiyerAd.Text, txtKasiyerSoyadi.Text, txtSigortaNo.Text);
                SecimIslemi.Show();
                this.Hide();
            }
            else if (GirisYapanKasaGorevlisi.Ad == KasaGorevlisi3.Ad && GirisYapanKasaGorevlisi.Soyad == KasaGorevlisi3.Soyad && GirisYapanKasaGorevlisi.SigortaNo == KasaGorevlisi3.SigortaNo)
            {
                GirisYapanKasaGorevlisi.KisiBilgisiDoldur(txtKasiyerAd.Text, txtKasiyerSoyadi.Text, txtSigortaNo.Text);
                SecimIslemi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen Kasiyer Bilgileri Yanlış. Lütfen Tekrar Deneyin.");
                txtKasiyerAd.Text = "";
                txtKasiyerSoyadi.Text = "";
                txtSigortaNo.Text = "";
            }


        }

       
    }
}
