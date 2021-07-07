using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARAC_KULLANIMLARI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Nurullah.k";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Nurullah";
            label7.Text = "Kaya";
            label8.Text = "Mühendis";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazılım M ühendisliği";
            label9.Text = textBox1.Text;

        }
    }
}
