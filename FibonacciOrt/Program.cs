using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciOrt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Derinliği:");
            string derinlik;
            derinlik = Console.ReadLine();

            List<int> fibo = new List<int>();
            fibo = Fibo.seriOlustur(Convert.ToInt32(derinlik));
            Console.WriteLine("Ortalama:" + FiboOrt.ortalamaHesapla(fibo));
            Console.ReadKey();
        }
    }
}
