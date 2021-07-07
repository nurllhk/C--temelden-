using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi_elemanlarını_listeleme_döngü
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
            string[] şehirler = { "Diyarbakır", "antalya", "istanbul", "elazığ" };

            for (int i = 0; i < şehirler.Length; i++) 
            {

                listBox1.Items.Add(şehirler[i]);

            }


        }
    }
}
