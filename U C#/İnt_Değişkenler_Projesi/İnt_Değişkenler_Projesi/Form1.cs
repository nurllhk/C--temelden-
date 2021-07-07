using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnt_Değişkenler_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, çarpım, toplam, bölüm, fark;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            çarpım = sayi1 * sayi2;
            bölüm = sayi1 / sayi2;
            MessageBox.Show("Toplam :" + toplam + "\n" + "Fark :" + fark + "\n" + "Çarpım" + çarpım + "\n" + "Bölüm" + bölüm );
        }
    }
}
