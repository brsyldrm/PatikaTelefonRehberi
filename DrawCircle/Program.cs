using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Draw draw = new Draw();
            Console.WriteLine("Yarı çap giriniz.");
            int radius = Convert.ToInt32(Console.ReadLine());
            draw.Circle(radius);
            Console.ReadKey();
        }
    }
}
