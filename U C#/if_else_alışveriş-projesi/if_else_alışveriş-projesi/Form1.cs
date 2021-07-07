using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_alışveriş_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadedi;
            double toplam;
            kitapadedi = Convert.ToInt16(textBox1.Text);
            if (kitapadedi>=0 && kitapadedi <= 20)
            {
                toplam = (kitapadedi * 8) - (kitapadedi * 8 * 0.20);


                // toplam = (kitapadedi * 8) - (kitapadedi * 8 * 0.20); demekki kitabı %20 eksik sattık
                label3.Text = toplam + " TL";
            }
            if (kitapadedi >=21 && kitapadedi <=41 )
            {
                toplam = (kitapadedi * 8) - (kitapadedi * 8 * 0.20);
                label3.Text = toplam + " TL";

            }
            if (kitapadedi >= 41)
            {

                toplam = (kitapadedi * 8) - (kitapadedi * 8 * 0.50);
                label3.Text = toplam + " TL";



            }
        }
    }
}
