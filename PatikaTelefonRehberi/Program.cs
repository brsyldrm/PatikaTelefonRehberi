using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PatikaTelefonRehberi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperationG operation= new OperationG();
            while (true)
            {
                
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
                Console.WriteLine("*****************************************");
                Console.WriteLine("(1) Yeni numara kaydetmek");
                Console.WriteLine("(2) Varolan numarayı silmek");
                Console.WriteLine("(3) Varolan numarayı güncellemek");
                Console.WriteLine("(4) Rehberi listelemek");
                Console.WriteLine("(5) Rehberde arama yapmak");
                int input = Convert.ToInt32(Console.ReadLine());
                if(input == 1)
                {
                    Guide phone = new Guide();
                    Console.Write("Lütfen isim giriniz: ");
                    phone.Name = Console.ReadLine();
                    Console.Write("Lütfen soyisim giriniz: ");
                    phone.SurName = Console.ReadLine();
                    Console.Write("Lütfen telefon numarası giriniz : ");
                    phone.Telephone = Console.ReadLine();
                    operation.Add(phone);
                    Console.WriteLine("Numara ekleme işleminiz başarıyla gerçekleştirildi.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }
                else if (input == 2)
                {
                    operation.Delete();
                }
                else if (input == 3)
                {
                    operation.Update();
                }
                else if(input == 4)
                {
                    operation.List();
                }
                else if(input == 5)
                {
                    Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                    Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                    Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                    string preferredAction = Console.ReadLine();
                    if (preferredAction == "1")
                    {
                        operation.searchName();
                    }
                    if (preferredAction == "2")
                    {
                        operation.searchTelephone();
                    }
                }
                else
                {
                    Console.WriteLine("Hata!!");
                    Console.Clear();
                }
            }
        }
    }
}
