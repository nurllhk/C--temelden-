using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_yarışması_projem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, doğru = 0, yanlış = 0;

        private void btnb_Click(object sender, EventArgs e)
        {

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;


            label5.Text = btnb.Text;
            if (label4.Text==label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;            }

        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btnc.Text;
            
            if (label4 == label5)
            {
                doğru++;

                lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text =btnd.Text;
            if (label4 == label5)
            {
                doğru++;

                lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btna_Click(object sender, EventArgs e)
        {

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btna.Text;
            if (label4==label5)
            {
                doğru++;
              
                lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnsonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruno++;
            lblsoruno.Text = soruno.ToString();
            if (soruno == 1 )
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                btna.Text = "1920";
                btnb.Text = "1921";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label4.Text = "1923";

            }
            if (soruno==2)
            {
                richTextBox1.Text = "Hangi il ege bölgesinde bulunmaz ?";
                btna.Text = "izmir";
                btnb.Text = "Diyarbakır";
                btnc.Text = "aydın";
                btnd.Text = "manisa";
                label4.Text = "Diyarbakır";

            }
            if (soruno==3)
            {
                richTextBox1.Text = "son kuşlar hangi yazarımıza aittir ?";
                btna.Text = "sait faik";
                btnb.Text = "cemal süreyya";
                btnc.Text = "reşat nuri";
                btnd.Text = "cahit sıtkı";
                label4.Text = "sait faik";


            }
            if (soruno==5)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnsonraki.Enabled = false;

                MessageBox.Show("Doğru : " + doğru + "\n" + "Yanlış : " + yanlış);
            }
        }

    }
}
