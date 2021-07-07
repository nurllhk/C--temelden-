using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {


            
        }
        delegate int islem(int k1, int k2);
        
        void fark(int s1, int s2)
        {
            Console.WriteLine(s1-s2);
        }
        void topla(int x1, int x2)
        {
            Console.WriteLine(x1 - x2);
        }
        void carp(int a1, int a2)
        {
            Console.WriteLine(a1 - a2);
        }
        void bol(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }
    }
}
