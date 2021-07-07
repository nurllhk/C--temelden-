using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ıf__else_karar_yapıları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  if (textBox1.Text == "nurullah") 
              {
                  label1.Text = "doğru";

              }
              else
              {
                  label1.Text = "yanlış";
           

            int sayi = Convert.ToInt16(textBox1.Text);
            if (sayi==5)
            {
                label1.Text = "DOĞRU";

            }
            else
            {
                label1.Text = "YANLIŞ";
            }
             
            int sayi = Convert.ToInt16(textBox1.Text);
            if (sayi % 2 == 0) 

            {
                label1.Text = "DOĞRU";  
            }
            else
            {
                label1.Text = "YANLIŞ";
            }
            */
            int sayi = Convert.ToInt16(textBox1.Text);
            if (sayi % 2 == 0 && sayi >= 10) 
                // && ve anlamına gelir || veya anlamın agelir
            {
                label1.Text = " 10 dan büyük ve çift";
            }
            else
            {
                label1.Text = "10 dan küçük ve çift";
            }










        }

    }
}
