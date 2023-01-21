using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kelime ve kaçıncı karakteri çıkarmak istiyorsanız sıra numarasını giriniz.(Aralarında virgül kullanınız.):");
            string input = Console.ReadLine();

            string[] str = input.Split(','); //verileni , ile ayırdık
            string kelime = str[0]; //kelimeyi aldık
            int index = Convert.ToInt32(str[1])-1; //sıra sayısından indexini aldık
            string algStr = kelime.Remove(index,1);//silme işlemini yaptık
            Console.WriteLine(algStr);
            Console.ReadKey();
        }
    }
}
