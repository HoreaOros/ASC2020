using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = .0314f;
            double d = 3.14;

            Console.WriteLine($"{f:F3}{Environment.NewLine}{d:E}");

            // TODO
            // Se cere sa se afiseze secventa binara corespunzatoare unei valori 
            // de tip float respectiv double. 
            // probabil ar trebui sa folositi operatori pe biti &,|,^,<<,>>,~ 

        }
    }
}
