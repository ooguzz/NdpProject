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
    public partial class Form2 : Form
    {
       
        Form3 Satisİslemleri = new Form3();
        Form4 DukkanIslemleri = new Form4();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSatisIslemleri_Click(object sender, EventArgs e)
        {
            Satisİslemleri.Show();
            this.Hide();
        }

        private void btnDukkanIslemleri_Click(object sender, EventArgs e)
        {
            DukkanIslemleri.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
