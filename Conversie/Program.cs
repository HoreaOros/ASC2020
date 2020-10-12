using System;
using System.Collections.Generic;


namespace Conversie
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Conversia unui numar din baza 10 intr-o baza tinta. 

            Console.WriteLine("*****************************************");
            Console.WriteLine("*Conversie din baza 10 intr-o baza tinta*");
            Console.WriteLine("*****************************************");

            try
            {
                // creati nume de identificatori expresivi
                int numar, bazaTinta;

                // Introducem numarul in baza 10 pe care vrem sa il convertim
                Console.WriteLine("Introduceti numarul in baza 10 pe care vreti sa-l convertiti: ");
                
                if (!int.TryParse(Console.ReadLine(), out numar))
                {
                    throw new Exception("Nu ati introdus un numar !");
                }


                // Introducem baza tinta
                Console.WriteLine("Introduceti baza tinta (un numar natural intre 2 si 16):");

                if (!int.TryParse(Console.ReadLine(), out bazaTinta))
                {
                    throw new Exception("Nu ati introdus un numar !");
                }


                if (bazaTinta < 2 || bazaTinta > 16)
                {
                    throw new Exception("Baza tinta poate fi cuprinsa intre 2 si 16");
                }

                int cat, rest;

                string result = "";
                Stack<int> stiva = new Stack<int>();

                while (numar > 0)
                {
                    cat = numar / bazaTinta;
                    rest = numar % bazaTinta;

                    stiva.Push(rest);

                    numar = numar / bazaTinta;
                }


                string[] hex = { "A", "B", "C", "D", "E", "F" };
                while (stiva.Count > 0)
                {
                    int cifra = stiva.Pop();
                    if (cifra >= 10)
                    {
                        // metoda 1 - folosind ASCII
                        cifra += 55;
                        result = result + (char)cifra;

                        // metoda 2 - folosind un Array cu valorile
                        // result = result + hex[cifra - 10];
                    }
                    else
                    {
                        result = result + cifra;
                    }
                }

                Console.WriteLine(result);
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

      

        }
    }
}
