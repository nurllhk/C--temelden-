﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_dijital_saat_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat = 0, saniye = 0, dakika = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text = saniye.ToString();

            if (saniye==60)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;


                if (dakika==60)
                {
                    saat++;
                    label3.Text = saat.ToString();
                    dakika = 0;
                }
            }







                
        }
    }
}
