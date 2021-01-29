using System;

namespace KampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			//type safety- tip güvenliği
			// Do not repeat yourself 
			// değer tutucu- alias

			string kategoriEtiketi = "Kategoriler";
			int ogrenciSayisi = 32000;
			double faizOrani = 1.45;
			bool sistemeGirisYapmısMı = true;
			double dolarDun = 7.35;
			double dolarBugun = 7.45;


			if (dolarDun> dolarBugun)
			{
				Console.WriteLine("Azalış oku");

			}


			else if (dolarDun< dolarBugun)
			{
				Console.WriteLine("Artış oku");
			}

			else
			{
				Console.WriteLine("Değişmedi butonu");
			}



			if (sistemeGirisYapmısMı == true)
			{
				Console.WriteLine("kullanıcı Ayarları Butonu");

			}

			else
			{
				Console.WriteLine("Giriş yap Butonu");
			}

			Console.WriteLine(kategoriEtiketi);
		}
	}
}
