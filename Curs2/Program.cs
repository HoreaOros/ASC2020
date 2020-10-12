using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1500000000, b = 2000000000;
            // cum aflu mijlocul intervalului [a, b]???

            int mijloc;

            // mijloc = (a + b) / 2; // gresit

            mijloc = a + (b - a) / 2; //corect


            Console.WriteLine(a + b);


            float f = 0.0f;
            for (int i = 0; i < 1000000; i++)
            {
                f = f + 0.001f;
            }
            Console.WriteLine(f);

        }
    }
}
