using System;

namespace SomyaiAlexandra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salut, sunt Alexandra");
            Console.WriteLine("Introduceti inaltimea");

            int inaltime;
            try
            {
                inaltime = int.Parse(Console.ReadLine());
                Console.WriteLine($"Aveti {inaltime} inaltime");
            }
            catch (Exception)
            {
                Console.WriteLine("Va rugam sa folositi doar numere intregi!");
                return;
            }



        }
    }
}
