using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangle
{
    public class Draw
    {
        public void drawTri(int size)
        {
            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j <i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
