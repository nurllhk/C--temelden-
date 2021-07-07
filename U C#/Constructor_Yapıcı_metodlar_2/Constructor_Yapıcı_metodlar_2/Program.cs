using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Yapıcı_metodlar_2
{
    class Program
    {
        static void Main(string[] args)
        {

            kimlik kml = new kimlik();

            kml.AD = "NURULLAH";
            kml.SOYAD = "KAYA";
            kml.MEMLEKET = "DİYARBAKIR";
            kml.CİNSİYET = 'E';


            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CİNSİYET);
            Console.WriteLine(kml.MEMLEKET);


            Console.Read();
        }
    }
}
