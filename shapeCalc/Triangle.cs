using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalc
{
    public class Triangle
    {
        public void environment(int a,int b,int c)
        {
            int e =a+b+c;
            Console.WriteLine(e);
        }
        public void area(int h, int t)
        {
            decimal a = (h * t) / 2;
            Console.WriteLine(a);
        }
        public void capacity()
        {
            Console.WriteLine("Hesaplanır bir ara");
        }
    }
}
