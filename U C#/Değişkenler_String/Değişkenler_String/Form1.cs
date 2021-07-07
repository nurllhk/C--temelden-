using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değişkenler_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  string metin;
              metin = "Bugün 2 şubbat 2021";
              label1.Text = metin;
            
            string adsoyad, meslek;
            adsoyad = "Nurullah kaya";
            meslek = "Mühendis";
            label1.Text = adsoyad;
            label2.Text = meslek;*/
            string şehir;
            şehir = textBox1.Text;
            label1.Text = şehir;

        }
    }
}
