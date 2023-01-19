using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PatikaTelefonRehberi
{
    public class OperationG
    {
        List<Guide> guides = new List<Guide>()
            {
                new Guide() {Name="Barış",SurName="Yıldırım",Telephone="050505050505"},
                new Guide() {Name="Sena",SurName="Yıldırım",Telephone="05050606060"},
                new Guide() {Name="Tufan",SurName="Talay",Telephone="05050707070"},
                new Guide() {Name="Mustafa",SurName="Bilgi",Telephone="05050808080"},
                new Guide() {Name="Umut",SurName="Konmus",Telephone="05050909090"}
            };
        public void Add(Guide phone)
        {
            guides.Add(phone);
        }
        public void Delete()
        {
            Console.Clear();
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            var input2 = Console.ReadLine();
            Guide phone = new Guide();
            foreach (Guide item in guides)
            {
                if (item.Name.ToLower() == input2.ToLower() || item.SurName.ToLower() == input2.ToLower())
                {
                    phone = item;
                }
            }
            if (phone.Name == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için : (2)");
                string againDelete = Console.ReadLine();
                if (againDelete == "1")
                {
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (againDelete == "2")
                {
                    Delete();
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız. Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                }
            }
            else
            {
                Console.WriteLine($"{phone.Name} {phone.SurName} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string userDecision = Console.ReadLine().ToLower();
                if (userDecision == "y")
                {
                    guides.Remove(phone);
                    Console.WriteLine("Silme işlemi başarıyla gerçekleştirildi.");
                    System.Threading.Thread.Sleep(3000);
                }
                else if (userDecision == "n")
                {
                    Console.WriteLine("Silme işlemi iptal edildi.");
                    System.Threading.Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yapıldı. Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }
        public void Update()
        {
            Console.Clear();
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            var input = Console.ReadLine();
            Guide phone = new Guide();
            foreach (Guide item in guides)
            {
                if (item.Name.ToLower() == input.ToLower() || item.SurName.ToLower() == input.ToLower())
                {
                    phone = item;
                }
            }
            if (phone.Name == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Güncellemeyi sonlandırmak için : (1)\r\nYeniden denemek için      : (2)");
                string preferredAction = Console.ReadLine();
                if (preferredAction == "1")
                {
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (preferredAction == "2")
                {
                    Update();
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız. Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                }
            }
            else
            {
                Console.WriteLine($"{phone.Name} {phone.SurName} isimli kişiyi güncellemek istiyor musunuz ?(y/n)");
                string userDecision = Console.ReadLine().ToLower();
                if (userDecision == "y")
                {
                    Console.Write("İsim: ");
                    phone.Name = Console.ReadLine();
                    Console.Write("Soyisim: ");
                    phone.SurName = Console.ReadLine();
                    Console.Write("Telefon: ");
                    phone.Telephone = Console.ReadLine();
                    Console.WriteLine("Güncelleme işlemi başarıyla gerçekleştirildi.");
                    System.Threading.Thread.Sleep(3000);
                }
                else if (userDecision == "n")
                {
                    Console.WriteLine("Güncelleme işlemi iptal edildi.");
                    System.Threading.Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yapıldı. Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }
        public void List()
        {
            Console.Clear();
            Console.WriteLine("*************************  Telefon Rehberi  *********************");
            foreach (Guide item in guides)
            {
                Console.WriteLine($"isim: {item.Name}");
                Console.WriteLine($"Soyisim: {item.SurName}");
                Console.WriteLine($"Telefon Numarası: {item.Telephone}");
            }

        }
        public void searchName()
        {
            Console.Clear();
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            var input = Console.ReadLine();
            Guide phone = new Guide();
            foreach (Guide item in guides)
            {
                if (item.Name.ToLower() == input.ToLower() || item.SurName.ToLower() == input.ToLower())
                {
                    phone = item;
                }
            }
            if (phone.Name == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Güncellemeyi sonlandırmak için : (1)\r\nYeniden denemek için      : (2)");
                string preferredAction = Console.ReadLine();
                if (preferredAction == "1")
                {
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (preferredAction == "2")
                {
                    searchName();
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız. Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                }
            }
            else
            {
                Console.WriteLine($"Arama Sonuçlarınız:");
                Console.WriteLine($"İsim Soyisim = {phone.Name} {phone.SurName} Telefon Numarası={phone.Telephone} ");
                System.Threading.Thread.Sleep(3000);
            }
        }
        public void searchTelephone()
        {
            Console.Clear();
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            var input = Console.ReadLine();
            Guide phone = new Guide();
            foreach (Guide item in guides)
            {
                if (item.Telephone == input)
                {
                    phone = item;
                }
            }
            if (phone.Telephone == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Güncellemeyi sonlandırmak için : (1)\r\nYeniden denemek için      : (2)");
                string preferredAction = Console.ReadLine();
                if (preferredAction == "1")
                {
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (preferredAction == "2")
                {
                    searchTelephone();
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız. Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                }
            }
            else
            {
                Console.WriteLine($"Arama Sonuçlarınız:");
                Console.WriteLine($"İsim Soyisim = {phone.Name} {phone.SurName} Telefon Numarası={phone.Telephone} ");
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}
