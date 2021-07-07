using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodlar_geriye_değer_döndürmeyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox1.Focus();
        }
        private void renklendir()
        {
            textBox1.BackColor = Color.Red;
            textBox2.BackColor = Color.Blue;
            textBox3.BackColor = Color.FloralWhite;
            textBox4.BackColor = Color.ForestGreen;



        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();

        }
        void bilgilerim()
        {
            textBox1.Text = "Nurullah";
            textBox2.Text = "Kaya";
            textBox3.Text = "03/04/2000";
            textBox4.Text = "Diyarbakırlı";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bilgilerim();
        }
    }
}
