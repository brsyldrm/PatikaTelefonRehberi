using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutlakKareAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıları giriniz.");
            string input = Console.ReadLine();
            string[] strings = input.Split(' ');
            int[] numbers = new int[strings.Length];

            int farkToplam = 0;
            int farkKareToplam = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                int x = int.Parse(strings[i]);
                numbers[i] = x;
                if (numbers[i] <= 67)
                {
                    farkToplam += 67 - numbers[i];
                }
                else
                {
                    int kare = numbers[i]-67;
                    farkKareToplam += (kare*kare);

                }
            }

            Console.WriteLine(" 67'den Küçük olanların farklarının toplamı :" + farkToplam);
            Console.WriteLine("67'den büyük farkların mutlak karelerini alarak toplamı : " + farkKareToplam);
        }
    }
}
