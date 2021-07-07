using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_sinema_büfe_satış_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, kola,toplam;
            misir = Convert.ToInt16(txtmisir.Text);
            bilet = Convert.ToInt16(txtbilet.Text);
            su = Convert.ToInt16(txtsu.Text);
            kola = Convert.ToInt16(txtkola.Text);

            toplam = misir * 5 + bilet * 12 + kola * 5 + su * 1;
            lbltoplam.Text = toplam.ToString()+" TL ";

            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString();

               
                

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text = "";
            txtkola.Text = "";
            txtmisir.Text = "";
            txtsu.Text = "";
            txtmisir.Focus();

            //   txtmisir.Focus(); iş bitinçe imleç yani yazacağim yer misira gelsin demek
        }
    }
}
