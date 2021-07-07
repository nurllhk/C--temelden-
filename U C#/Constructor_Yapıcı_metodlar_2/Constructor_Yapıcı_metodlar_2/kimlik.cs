using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Yapıcı_metodlar_2
{
    class kimlik
    {
        string ad;
        string soayd;
        string memleket;
        int yaş;
        char cinsiyet;

        public string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }

        public string SOYAD
        {
            get { return soayd; }
            set { soayd = value.ToUpper(); }

        }
        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value.ToUpper(); }
        }

        public int YAS
        {


            get { return yaş; }
            set { yaş = Math.Abs(value); }



        }
        public char CİNSİYET
        {

            get { return cinsiyet; }
            set { cinsiyet = value; }

        }

        public kimlik()
        {

            ad = "";
            soayd = "";
            yaş = 18;
            cinsiyet = ' ';
            memleket = " ";


        }


    }
}
