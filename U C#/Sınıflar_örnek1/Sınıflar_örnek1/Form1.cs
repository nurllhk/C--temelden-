using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıflar_örnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            araba rb = new araba();

            rb.renk = "Beyaz";
            rb.hız = 260;
            rb.motor = 3450.23;
            rb.fiyat = 560000;
            rb.durum = '0';
            rb.YIL = 2020;
            rb.markası = "BMW";
            rb.plaka = "21 NK 417";
            rb.muayene = 2021;
            rb.sahip = "Buse Zengin";


            label1.Text = rb.renk;
            label2.Text = rb.hız.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.markası;
            label8.Text = rb.plaka;
            label9.Text = rb.muayene.ToString();
            label10.Text = rb.sahip;






        }
    }
}
