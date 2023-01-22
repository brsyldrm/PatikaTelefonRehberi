using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İşlem Yapmak istediğiniz şekli giriniz.");
            Console.WriteLine("(1) Daire");
            Console.WriteLine("(2) Üçgen");
            Console.WriteLine("(3) Kare");
            Console.WriteLine("(4) Dikdörtgen");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hesaplamak istediğiniz tür nedir?");
            Console.WriteLine("(1) Çevre");
            Console.WriteLine("(2) Alan");
            Console.WriteLine("(3) Hacim");
            int secim2 = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Circle circle = new Circle();
                Console.WriteLine("Yarı çap giriniz.");
                int r = Convert.ToInt32(Console.ReadLine());
                switch (secim2)
                {
                    
                    case 1:
                        circle.environment(r);
                        break;
                    case 2:
                        circle.area(r);
                        break;
                    case 3:
                        circle.capacity(r); 
                        break;

                }
                    

            }
            else if (secim == 2)
            {
                Triangle triangle= new Triangle();
                switch (secim2)
                {

                    case 1:
                        Console.WriteLine("Üç kenarın uzunluğunu teker teker giriniz.");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        triangle.environment(a,b,c);
                        break;
                    case 2:
                        Console.WriteLine("Taban ve yükseklik giriniz.");
                        int h = Convert.ToInt32(Console.ReadLine());
                        int t = Convert.ToInt32(Console.ReadLine());
                        triangle.area(h,t);
                        break;
                    case 3:
                        triangle.capacity();
                        break;

                }
            }
            else if (secim == 3)
            {
                Square square=new Square();
                Console.WriteLine("Kenar uzunluğu giriniz.");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (secim2)
                {

                    case 1:
                        square.environment(a);
                        break;
                    case 2:
                        square.area(a);
                        break;
                    case 3:
                        square.capacity(a);
                        break;

                }
            }
            else if(secim == 4)
            {
                Rectangle rectangle=new Rectangle();
                switch (secim2)
                {

                    case 1:
                        Console.WriteLine("Uzun kenar ve Kısa kenar giriniz.");
                        int h = Convert.ToInt32(Console.ReadLine());
                        int t = Convert.ToInt32(Console.ReadLine());
                        rectangle.environment(h,t);
                        break;
                    case 2:
                        Console.WriteLine("Uzun kenar ve Kısa kenar giriniz.");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        rectangle.area(a,b);
                        break;
                    case 3:
                        Console.WriteLine("Uzun kenar, Kısa kenar ve yükseklik giriniz.");
                        int c = Convert.ToInt32(Console.ReadLine());
                        int d = Convert.ToInt32(Console.ReadLine());
                        int e = Convert.ToInt32(Console.ReadLine());
                        rectangle.capacity(c,d,e);
                        break;

                }
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama");
            }
            Console.ReadKey();
        }
    }
}
