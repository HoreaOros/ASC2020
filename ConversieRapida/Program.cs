using System;
using System.Collections.Generic;
using System.Text;


/* 10    16      2    4    8
 * ---------------------------
 * 0     0    0000   00    00
 * 1     1    0001   01    01
 * 2     2    0010   02    02
 * 3     3    0011   03    03
 * 4     4    0100   10    04
 * 5     5    0101   11    05
 * 6     6    0110   12    06
 * 7     7    0111   13    07
 * 8     8    1000   20    10
 * 9     9    1001   21    11
 * 10    A    1010   22    12
 * 11    B    1011   23    13
 * 12    C    1100   30    14
 * 13    D    1101   31    15
 * 14    E    1110   32    16
 * 15    F    1111   33    17
 * */
namespace ConversieRapida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar in baza 2");
            string number2;

            number2 = Console.ReadLine();
            number2 = number2.TrimStart('0');

            Console.WriteLine("Introduceti baza in care vreti sa faceti conversia (4, 8, 16):");
            int baza;
            baza = int.Parse(Console.ReadLine());


            // 0001 0010 => 12(16)
            // 1010 1111 => AF(16)
            // 10 10 11 11 => 2233(4)
            // 10 101 111 => 257(8)

            Dictionary<string, string> base16 = new Dictionary<string, string>();
            base16.Add("0000", "0");
            base16.Add("0001", "1");
            base16.Add("0010", "2");
            base16.Add("0011", "3");

            base16.Add("0100", "4");
            base16.Add("0101", "5");
            base16.Add("0110", "6");
            base16.Add("0111", "7");

            base16.Add("1000", "8");
            base16.Add("1001", "9");
            base16.Add("1010", "A");
            base16.Add("1011", "B");

            base16.Add("1100", "C");
            base16.Add("1101", "D");
            base16.Add("1110", "E");
            base16.Add("1111", "F");


            Dictionary<string, string> base8 = new Dictionary<string, string>();
            base8.Add("000", "0");
            base8.Add("001", "1");
            base8.Add("010", "2");
            base8.Add("011", "3");

            base8.Add("100", "4");
            base8.Add("101", "5");
            base8.Add("110", "6");
            base8.Add("111", "7");

            Dictionary<string, string> base4 = new Dictionary<string, string>();
            base4.Add("00", "0");
            base4.Add("01", "1");
            base4.Add("10", "2");
            base4.Add("11", "3");



            //foreach (var item in base16.Keys)
            //{
            //    Console.WriteLine($"{item} - {base16[item]}");
            //}
            int nrCifre = 0;
            switch (baza)
            {
                case 4:
                    nrCifre = 2;
                    break;
                case 8:
                    nrCifre = 3;
                    break;
                case 16:
                    nrCifre = 4;
                    break;
                default:
                    Console.WriteLine("Baza tinta nu este corecta.");
                    throw new IncorrectBaseException("Baza nu este corecta");
            }

            int lungimeNumarB2;
            lungimeNumarB2 = number2.Length;

            int nrZerouriDeAdaugat = 0;

            if (lungimeNumarB2 % nrCifre > 0)
            {
                nrZerouriDeAdaugat = nrCifre - lungimeNumarB2 % nrCifre;
            }

            number2 = number2.PadLeft(nrZerouriDeAdaugat + lungimeNumarB2, '0');

            // Console.WriteLine(number2);

            StringBuilder sb = new StringBuilder();
            int i = 0;
            string key;
            while (i < number2.Length / nrCifre)
            {
                key = number2.Substring(i * nrCifre, nrCifre);
                switch (baza)
                {
                    case 4:
                        sb.Append(base4[key]);
                        break;
                    case 8:
                        sb.Append(base8[key]);
                        break;
                    case 16:
                        sb.Append(base16[key]);
                        break;
                }
                i++;
            }

            string result = sb.ToString();

            result = result.TrimStart('0');
            Console.WriteLine(result);
        }
    }
}
