using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sort_Kullanımı
{
    public class Program
    {
        public static void Main()
        {
            // Dizimizi tanımladık.
            int[] Dizi = new int[5] { 68, 53, 34, 16, 25 };

            // Diziyi artan sistemde sıraladık.
            Array.Sort(Dizi);

            foreach (int val in Dizi)
            { // Yeni sıralamayı yazdırdık.
                Console.WriteLine(val);
            }
            Console.ReadLine();
        }
    }
}
