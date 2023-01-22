using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Lütfen girmek istediğiniz cümleleri aralarında boşluk olacak şekilde yazınız: ");

            string input = Console.ReadLine();
            string[] input2 = input.Split(' ');
            string[] strings = new string[input2.Length];
            int i = 0;
            foreach (var item in input2)
            {

                char firstChar = item[0];
                string modified = item.Substring(1) + firstChar;
                strings[i]= modified;
                i++;
            }
            foreach(var item in strings)
            {
                Console.Write(item);
                Console.Write(' ');
            }
            Console.ReadKey();

        }
    }
}
