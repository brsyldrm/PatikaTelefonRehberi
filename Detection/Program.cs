using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cümleyi giriniz");
            string input = Console.ReadLine();
            string[] strings = input.Split(' ');
            foreach (var item in strings)
            {
                bool result = Kontrol(item);
                Console.Write(result);
                Console.Write(" ");
            }
            
            Console.ReadKey();

        }
        static bool Kontrol(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (!Sesli(input[i]) && !Sesli(input[i + 1]))
                {
                    return true;
                }
            }
            return false;
        }

        static bool Sesli(char c)
        {
            return c == 'a' || c == 'e' || c == 'ı' || c == 'i' || c == 'o' || c == 'ö' || c == 'u' || c == 'ü' || c == 'A' || c == 'E' || c == 'I' || c == 'İ' || c == 'O' || c == 'Ö' || c == 'U' || c == 'Ü';
        }
    }
}

