using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalc
{
    public class Square
    {
        public void environment(int h)
        {
            int e = h * 4;
            Console.WriteLine(e);
        }
        public void area(int h)
        {
            int a = h * h;
            Console.WriteLine(a);
        }
        public void capacity(int h)
        {
            int c = h * h * h;
            Console.WriteLine(c);
        }
    }
}
