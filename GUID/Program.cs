using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUID
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid g = Guid.NewGuid();
            foreach (var item in g.ToByteArray())
            {
                Console.Write($"{item,3:X2} ");
            }

            Console.WriteLine();
            foreach (var item in g.ToByteArray())
            {
                Console.Write($"{item,3} ");
            }

        }
    }
}
