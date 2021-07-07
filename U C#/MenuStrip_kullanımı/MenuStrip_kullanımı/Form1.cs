using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void renklerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void hakkımdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu projeyi Nurullah Kaya oluşturmuştur","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void görevimizTehlikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=aAWVHwBGTD4");
        }

        private void intersepterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=vVJeYMRam0o");
        }

        private void psILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CZzW6_hR068");
        }

        private void cubpeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/8_oOES_uKPI?list=RD8_oOES_uKPI");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
