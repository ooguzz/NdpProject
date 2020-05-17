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
    public class UrunTanimi
    {
        public string Tanım { get; set; }
        public string Ad { get; set; }
        public int UrunKodu { get; set; }
        public decimal Fiyatı { get; set; }
        public int UrunAdet { get; set; }
        public decimal  Tutar { get; set; }
        public int Miktar { get; set; }


        public List<Urun> Urunler { get; set; }
       
        public decimal tutarhesapla()
        {

            this.Tutar = this.Miktar * this.Fiyatı;
           
            return Tutar;
        }

    }
}
