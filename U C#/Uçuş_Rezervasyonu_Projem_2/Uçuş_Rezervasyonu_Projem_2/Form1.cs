using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçuş_Rezervasyonu_Projem_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota :"+comboBox1.Text+" - "+comboBox2.Text+" Tarih : "+dateTimePicker1.Text+" Saat : "+maskedTextBox1+"Yolcu bilgileri > Adı :"+textBox1.Text+"TC :"+maskedTextBox2.Text+" Telefon : "+maskedTextBox3.Text);
            MessageBox.Show("Yolcu kaydı yapılmıştır");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label9.Text =comboBox2 .Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
