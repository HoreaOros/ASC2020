using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using System;

namespace proiect1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Angajati Magazin");
            Console.WriteLine("Introduceti numarul de angajati: ");

            int numarAngajati;
            try
            {
                numarAngajati = int.Parse(Console.ReadLine());
                Console.WriteLine($"Aveti {numarAngajati} numar elevi");
            }
            catch (Exception)
            {
                Console.WriteLine("Va rugam sa folositi doar numere intregi!");
                return;
            }



        }
    }
}