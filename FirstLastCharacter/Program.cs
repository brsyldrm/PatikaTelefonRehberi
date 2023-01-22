using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLastCharacter
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
                char lastChar = item[item.Length - 1];
                string input3 =item.Remove(item.Length - 1, 1).Remove(0, 1);
                string input4 = lastChar + input3 + firstChar;
                strings[i] = input4;
                i++;
            }
            foreach (var item in strings)
            {
                Console.Write(item);
                Console.Write(' ');
            }
            Console.ReadKey();
            
            Console.WriteLine(input);
        }
    }
}
