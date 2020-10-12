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

            

            // creati nume de identificatori expresivi
            string line;

            
            // Introducem numarul in baza 10 pe care vrem sa il convertim
            Console.WriteLine("Introduceti numarul in baza 10 pe care vreti sa-l convertiti: ");
            line = Console.ReadLine();
            int numar;
            try
            {
                numar = int.Parse(line);
            }
            catch (Exception)
            {

                Console.WriteLine("Va rugam sa folositi doar numere intregi!");
                return;
            }

            // ***TODO tratarea exceptiilor la introducerea numerelor*** (DONE)



            
            // Introducem baza tinta
            Console.WriteLine("Introduceti baza tinta (un numar natural intre 2 si 16):");
            int bazaTinta;

            // ***TODO trebuie sa ne asiguram ca numarul introdus ca si baza tinta este intre 2 si 16*** (DONE)
            bool isValid = false;
            try
            {
                do
                {
                    line = Console.ReadLine();
                    bazaTinta = int.Parse(line);
                    if (bazaTinta >= 2 && bazaTinta <= 16)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Baza trebuie sa fie intre 2 si 16!");
                        Console.WriteLine("Introduceti baza tinta (un numar natural intre 2 si 16):");
                    }
                } while (!isValid);
            }
            catch (Exception)
            {

                Console.WriteLine("Va rugam sa folositi doar numere intregi!");
                return;
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



            // ***TODO afisarea corecta a cifrelor atunci cand baza tinta e mai mare decat 10*** (DONE)
            while (stiva.Count > 0)
            {
                int numarCurent = stiva.Pop();
                if (numarCurent < 10)
                {
                    result = result + numarCurent;
                }
                else
                {
                    switch(numarCurent)
                    {
                        case 10: 
                            result = result + "A";
                            break;
                        case 11: 
                            result = result + "B";
                            break;
                        case 12:
                            result = result + "C";
                            break;
                        case 13:
                            result = result + "D";
                            break;
                        case 14:
                            result = result + "E";
                            break;
                        case 15:
                            result = result + "F";
                            break;
                    }
                }
            }

            Console.WriteLine(result);








        }
    }
}
