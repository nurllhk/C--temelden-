using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar_geriye_değer_döndürenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int çarpım(int s1, int s2, int s3)
        {
            int s4 = s1 * s2 * s3;
            return s4;

        }

        int kup(int sayi)
        {
            int sonuc = sayi * sayi * sayi;

            return sonuc;



        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = çarpım(3, 4, 6).ToString();
            label2.Text = çarpım(5, 6, 2).ToString();
            label3.Text = çarpım(1, 2, 3).ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(textBox1.Text);

            label4.Text = kup(s).ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {


           
        }
    }
}
