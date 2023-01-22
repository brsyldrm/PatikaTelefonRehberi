using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkılılerınToplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıları arasında bir boşluk bırakarak giriniz.");
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            int n = inputs.Length/2;

            int[] sums = new int[n];
            for(int i=0; i<n; i++)
            {
                int x = int.Parse(inputs[2*i]);
                int y = int.Parse(inputs[2*i+1]);
                if (x == y)
                {
                    sums[i] = (x+y)*(x+y);
                }
                else
                {
                    sums[i] = x + y;
                }
            }
            foreach (var item in sums)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
