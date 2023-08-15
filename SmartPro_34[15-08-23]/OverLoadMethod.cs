using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_34_15_08_23_
{
    internal class OverLoadMethod
    {
        public void Topla(int n1, int n2)
        {
            int last = n1 + n2;
            Console.Write("Toplama Methodu\n");
            Console.WriteLine("Toplam: {0} + {1} = {2}\n" ,n1,n2,last);

        }
        public void Topla(int n1, int n2, int n3)
        {
            int last = n1 + n2 + n3;
            Console.Write("Toplama Methodu\n");
            Console.WriteLine("Toplam: {0} + {1} + {2} = {3}\n", n1, n2, n3, last);
        }
        public void Topla(double n1, double n2)
        {
            double last = n1 + n2;
            Console.Write("Toplama Methodu\n");
            Console.WriteLine("Toplam: {0} + {1} = {2}\n", n1, n2, last);
        }
        public void Topla(double n1, double n2, double n3)
        {
            double last = n1 + n2 + n3;
            Console.Write("Toplama Methodu\n");
            Console.WriteLine("Toplam: {0} + {1} + {2} = {3}\n", n1, n2, n3, last);
        }
        public void Topla()
        {
            Console.Write("Bir değer girmediniz.");        
        }
    }
}
