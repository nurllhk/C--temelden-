using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_döngü_aracı_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayaç = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /* sayaç++;
             label1.Text = sayaç.ToString();
             if (sayaç == 50)
             {
                 timer1.Stop();
                 this.BackColor = Color.Red;
             }*/


            sayaç++;
            label1.Text = sayaç.ToString();
            if (sayaç==15)
            {
                this.BackColor = Color.Green;

            }
            if (sayaç==30)
            {
                this.BackColor = Color.Red;
                sayaç = 0;
            }
            if (sayaç==0)
            {
                this.BackColor = Color.Cyan;
                sayaç = 0;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
          
        }
    }
}
