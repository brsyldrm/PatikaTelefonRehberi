using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciOrt
{
    public class Fibo
    {
        public static List<int> seriOlustur(int seri)
        {
            List<int> fiboList = new List<int>();
            fiboList.Add(1);
            fiboList.Add(1);
            if (seri < 3)
            {
                return fiboList;
            }
            for (int i = 2; i < seri; i++)
            {
                fiboList.Add(fiboList[i - 1] + fiboList[i - 2]);
            }

            return fiboList;
        }
    }
}
