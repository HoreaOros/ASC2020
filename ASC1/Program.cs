using System;

namespace ASC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of C#!!");
            Console.WriteLine("Introduceti numarul de pantof: ");

            int numarPantof;
            try {
                numarPantof = int.Parse(Console.ReadLine());
                Console.WriteLine($"Aveti {numarPantof} numarul la pantof");
            } catch (Exception e) {
                Console.WriteLine("Va rugam sa folositi doar numere intregi!");
                return;
            }

            Console.WriteLine("Isus al meu prieten bun");

            //int.TryParse(line, out numarPantof);

            // mica schimbare in pull request

        }
    }
}
