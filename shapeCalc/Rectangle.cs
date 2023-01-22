using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalc
{
    public class Rectangle
    {
        public void environment(int h,int v)
        {
            int e = (2*h)+(2*v);
            Console.WriteLine(e);
        }
        public void area(int h,int v)
        {
            int a = h * v;
            Console.WriteLine(a);
        }
        public void capacity(int h, int v,int l)
        {
            int c = h * v * l;
            Console.WriteLine(c);
        }
    }
}
