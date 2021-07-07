using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string[] kişiler = { "bıngıl", "ceren", "Nurullah", "muhammet" };
             foreach(string N in kişiler)
             {
                 listBox1.Items.Add(N);
             }*/
            int toplam = 0;
            int[] sınavlar = { 60, 40, 70, 85, 100, 95 };

            foreach (int n in sınavlar)
            {
                listBox1.Items.Add(n);

                toplam = toplam + n;

            }
            label1.Text = toplam.ToString();
            int ortalama = toplam / sınavlar.Length;

            label2.Text = ortalama.ToString();








        }
    }
}
