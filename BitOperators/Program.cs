using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operatori pe biti
            // &, |, ^, <<, >>, ~


            // cout << (1 << 2); asta e o expresie in C++;

            int n = 1;
            // n = 0000.....000001
            Console.WriteLine(n);

            n = n << 2; // deplasare la stanga a bitilor lui n cu 2 pozitii
            // n = 000...0000100
            Console.WriteLine(n);


            n = n >> 2; // deplasare la drepta cu 2 pozitii a bitilor lui n;
            Console.WriteLine(n);

            n = ~n; // complementarea bitilor
            // 11111...1111110 = secventa obtinuta prin complementare
            Console.WriteLine(n);


            // SI pe biti
            // & | 0 1
            // 0 | 0 0 
            // 1 | 0 1

            // SAU pe biti
            // | | 0 1
            // 0 | 0 1 
            // 1 | 1 1


            // SAU exclusiv pe biti - XOR (eXclusive OR)
            // ^ | 0 1
            // 0 | 0 1 
            // 1 | 1 0


            // m = 0011 XOR
            // k = 0101
            // -----------
            // c = 0110 XOR
            // k = 0101
            // -----------
            // m = 0011
            // Criptosistem.

            // BH-01-XOR
            // BH-02-XOR









        }
    }
}
