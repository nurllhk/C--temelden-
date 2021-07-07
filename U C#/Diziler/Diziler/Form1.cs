using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
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
            //  string[] kişiler = { "Bıngıl", "Nurullah", "gorgea", "Ali" };
            //label1.Text = kişiler[1];

            char[] karakterler = { 'N', 'K', 'B', };
            label1.Text = karakterler[0].ToString();
        }
    }
}
