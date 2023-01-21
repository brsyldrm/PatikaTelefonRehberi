using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Draw draw = new Draw();
            Console.WriteLine("Yükseklik giriniz.");
            int size = Convert.ToInt32(Console.ReadLine());
            draw.drawTri(size);
            Console.ReadKey();
        }
    }
}
