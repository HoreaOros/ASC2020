
using System;

namespace Adelina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salutare dragi colegi!!");
            Console.WriteLine("Introduceti nr de elevi: ");

            int numarElevi;
            try
            {
                numarElevi = int.Parse(Console.ReadLine());
                Console.WriteLine($"Aveti {numarElevi} numar elevi");
            }
            catch (Exception)
            {
                Console.WriteLine("Va rugam sa folositi doar numere intregi!");
                return;
            }



        }
    }
}
