﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 1000000, b = 1000000;
            try
            {
                checked
                {
                    Console.WriteLine(a * b); // 10^{12} 
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }


            // short circuit evaluation
            int[] v = new int[4] {0, 5, 6, 7};
            int n = 7;
            if(n < v.Length && v[n] == 6) // A SI B <==> B SI A 
            {
                Console.WriteLine("Great!");
            }
            else
            {
                Console.WriteLine("Indexul nu este corect");
            }
        }
    }
}
