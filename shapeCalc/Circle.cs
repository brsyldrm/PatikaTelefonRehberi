using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalc
{
    public class Circle
    {
        public void environment(int r)
        {
            int e = 2 * 3 * r;
            Console.WriteLine(e);
        }
        public void area(int r)
        {
            int a = 3 * (r * r);
            Console.WriteLine(a);
        }
        public void capacity(int r)
        {
            int c = (4 / 3) * 3 * (r * r * r);
            Console.WriteLine(c);
        }
    }
}
