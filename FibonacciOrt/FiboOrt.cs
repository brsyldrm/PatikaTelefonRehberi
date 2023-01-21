using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciOrt
{
    public class FiboOrt
    {
        
        public static double ortalamaHesapla(List<int> fiboListe)
        {
            double toplam = 0;
            double listeUzunluk;
            listeUzunluk = fiboListe.Count;
            for (int i = 0; i < fiboListe.Count; i++)
            {
                toplam += fiboListe[i];
            }
            return toplam / listeUzunluk;
        }
    }
}
