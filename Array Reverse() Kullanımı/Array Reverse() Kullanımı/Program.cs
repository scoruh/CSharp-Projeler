using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Reverse_Kullanımı
{
    class Dizi
    {
        static void Main(string[] args)
        {
            // Dizimizi tanımladık.
            int[] Dizi = { 25, 53, 45, 76 };
            int[] tmp = Dizi;
            //Dizimizin orijinal halini yazdırdık.
            Console.Write("Orijinal Dizi: ");
            foreach (int i in Dizi)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // Dizi terse dönüyor.
            Array.Reverse(tmp);
            //Dizimizin ters halini yazdırdık.
            Console.Write("Dizinin Tersi: ");
            foreach (int i in tmp)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
