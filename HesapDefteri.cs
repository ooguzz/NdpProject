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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpProject
{
    public class HesapDefteri
    {
        public Satis Satıslar = new Satis();
        public Dukkan Dukkanimiz = new Dukkan();
        private int toplamurunadedi;

        public int ToplamUrunAdedi
        {
            get
            {
                UrunAdediHesapla();
                return toplamurunadedi; 
            }
            
            
        }
        public void stoksifirla()
        {
            toplamurunadedi = 0;

        }
        
        public void UrunAdediHesapla()
        {
            toplamurunadedi = 0;
            foreach (Urun u in Form3.UrunKatalogu.Dukkanimiz.UrunlerListesi)
            {
                toplamurunadedi += u.Tanım.UrunAdet;
            }
            
            
        }

        private decimal toplamsatistutari;

        public decimal ToplamSatisTutari
        {
            get { return toplamsatistutari; }
        }

        public void ToplamSatisTutariHesapla()
        {
            toplamsatistutari = Satıslar.KrediliOdeme.OdemeMiktari + Satıslar.NakitOdeme.OdemeMiktari;
        }
        
    }
}
