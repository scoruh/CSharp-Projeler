using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_IndexOf_Kullanımı
{
	class Program
	{
		static void Main()
		{

			// Tamsayı dizisini girdik.

			int[] Dizi = new int[6];
			Dizi[0] = 1;
			Dizi[1] = 3;
			Dizi[2] = 5;
			Dizi[3] = 7;
			Dizi[4] = 8;
			Dizi[5] = 5;

			// 5 değerine sahip elemanı bulduk.

			int index1 = Array.IndexOf(Dizi, 5);

			// 3 değerine sahip indeksi bulduk.

			int index2 = Array.IndexOf<int>(Dizi, 3);

			// 5'in son indeksini bulduk.

			int index3 = Array.LastIndexOf(Dizi, 5);

			// Sonucu yazdırdık.

			Console.WriteLine(index1);
			Console.WriteLine(index2);
			Console.WriteLine(index3);
			Console.ReadLine();
		}
	}
}