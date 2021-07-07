using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i<=5)
            {
                i++;
                listBox1.Items.Add("merhaba Diyarbakır");
                listBox2.Items.Add(i);
            }
            int n=1;
            int toplam = 0;
            while (n<=5)
            {
                n++;
                toplam = toplam + n;




            }
            MessageBox.Show(toplam.ToString());

        }
    }
}
