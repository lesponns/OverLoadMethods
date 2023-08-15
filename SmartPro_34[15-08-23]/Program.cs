using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_34_15_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OverLoadMethod yazdir = new OverLoadMethod();

            yazdir.Topla(5,6);
            yazdir.Topla(5,6,7);
            yazdir.Topla(5.3,2.5);
            yazdir.Topla(3.4,6.6,1.5);
            yazdir.Topla();

            Console.ReadKey();

        }
    }
}
