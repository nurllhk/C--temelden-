using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consol_tanıtım
{
    class Program
    {
        static void Main(string[] args)
        {


            
            // komut isteminin (CMD) ekranda durmasını sağlıyor

            Console.WriteLine("CONSOLUM");
            Console.WriteLine("UYGULAMAM");

            //WRİTE OLUNCA NORMAL DÜMDÜZ SATIRA YAZDIRIR. WRİTELİNE OLUNCA SONRA GELECEK OLAN YAZIYI BİR ALT SATIRA İNDİRİR.

            string isim;
            isim = "Nurullah K.";
            Console.WriteLine(isim);

            int sayi;
            sayi= 6;
            Console.Write(sayi);

            Console.Read();
        }
    }
}
