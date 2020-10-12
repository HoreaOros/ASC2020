﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversie
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Conversia unui numar din baza 10 intro-o baza tinta.
            /// 

            Console.WriteLine("*****************************************");
            Console.WriteLine("*Conversie din baza 10 intr-o baza tinta*");
            Console.WriteLine("*****************************************");

            
            // creati nume de identificatori expresivi
            string line;

            // Citim numarul in baza 10 pe care vrem sa il convertim
            Console.WriteLine("Introduceti numarul in baza 10 pe care vreti sa il convertiti: ");
            line = Console.ReadLine();
            int numar;
            numar = int.Parse(line);

            //TODO tratarea exceptiilor la introducerea numerelor

            //Introducem baza tinta
            Console.WriteLine("Introduceti baza tinta (un numar natural intre 2 si 16)");
            line = Console.ReadLine();
            int bazaTinta;
            bazaTinta = int.Parse(line);

            //TODO trebuie sa ne asiguram ca numarul introdus ca si baza tinta intre 2 si 16

            int rest, cat;

            string result = "";
            Stack<int> stiva = new Stack<int>();

            while (numar > 0)
            {
                cat = numar / bazaTinta;
                rest = numar % bazaTinta;

                stiva.Push(rest);

                
                numar = numar / bazaTinta;
            }
            // TODO afisarea corecta a cifrelor atunci cand baza tinta > 10

            while (stiva.Count > 0)
            {
                result = result + stiva.Pop();
             
            }
            Console.WriteLine(result);

        }
    }
    
}
