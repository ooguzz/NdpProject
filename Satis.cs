﻿/****************************************************************************
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
    public class Satis
    {
        public DateTime Tarih { get; set; }
        public SatisKalemi Satiskalemi = new SatisKalemi();
        public decimal  ToplamTutar { get; set; }

        public NakitOdeme NakitOdeme = new NakitOdeme();
        public KrediKartiIleOdeme KrediliOdeme = new KrediKartiIleOdeme();
    }
}
