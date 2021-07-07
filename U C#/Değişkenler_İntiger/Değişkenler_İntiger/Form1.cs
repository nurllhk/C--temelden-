using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Değişkenler_İntiger
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
            /*   int sayi;
               sayi = 5;
               label1.Text = sayi.ToString();
            int sayi1, sayi2, toplam;
            sayi1 = 4;
            sayi2 = 6;
            toplam = sayi1 + sayi2;
            label1.Text = toplam.ToString();*/
            int kenar, alan, çevre;
            kenar = 10;
            alan = kenar * kenar;
            çevre = kenar * 4;
            label1.Text = " Alan :" + alan+" Çevre :"+çevre;
            //eğer string ifadeyi bir kere kullandıysan intiger değeri tostring() komutuyla strine çevirmene gerek kalmaz



        }
    }
}
