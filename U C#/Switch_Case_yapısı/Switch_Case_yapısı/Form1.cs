using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox1.Text);

            switch (ay)
            {
                case 1: label2.Text = "ocak"; break;
                case 2: label2.Text = "şubat"; break;
                case 3: label2.Text = "mart"; break;
                case 4: label2.Text = "nisan"; break;
                case 5: label2.Text = "mayıs"; break;
                case 6: label2.Text = "haziran"; break;
                case 7: label2.Text = "temmuz"; break;
                case 8: label2.Text = "ağustos"; break;
                case 9: label2.Text = "eylül"; break;
                case 10: label2.Text = "ekim"; break;
                case 11: label2.Text = "kasım"; break;
                case 12: label2.Text = "aralık"; break;

                default: label2.Text = "Hatalı giriş yapıldı !"; break;

               


            }
            

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mevsim = textBox2.Text;
            switch (mevsim)
            {
                case "yaz": label3.Text = "haziran temmuz ağustos"; 
                    break;
                case "kış": label3.Text = "aralık ocak şubat";
                    break;
                case "sonbahar":label3.Text = "eylül ekim kasım";
                    break;
                case "ilkbahar":label3.Text = "mart nisan mayıs";
                    break;
                default: label3.Text = "Hatalı giriş !";
                    break;













                
                    
            }
        }
    }
}
