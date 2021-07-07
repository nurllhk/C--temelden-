using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değişkenler_Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         /*   double sayi1;
            sayi1 = 3.04;
            label1.Text = sayi1.ToString();
         */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* double s1, s2, s3, ortalama;

             s1 = 40;
             s2 = 50;
             s3 = 80;
             ortalama = (s1 + s2 +s3)/3;
             label1.Text = ortalama.ToString("0.00");
            */
            double sayi1;
            sayi1 = Convert.ToDouble(textBox1.Text);
            label1.Text = sayi1.ToString();


              
        }

    }
}
