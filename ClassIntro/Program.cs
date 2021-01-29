using System;

namespace ClassIntro
{
	class Program
	{
		static void Main(string[] args)
		{

			string adi = "Nisa";
			int yasi = 32;

			kurs kurs1 = new kurs();
			kurs1.kursAdi = "C#";
			kurs1.Egitmen = "Engin";
			kurs1.izlenmeOrani = 68;

			kurs kurs2 = new kurs();
			kurs2.kursAdi = "Java";
			kurs2.Egitmen = "Kerim";
			kurs2.izlenmeOrani = 68;

			kurs kurs3 = new kurs();
			kurs3.kursAdi = "Python";
			kurs3.Egitmen = "Berkay";
			kurs3.izlenmeOrani = 68;


			//Console.WriteLine(kurs1.kursAdi + " :" + kurs1.Egitmen);
			kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

			foreach (var kurs in kurslar)
			{
				Console.WriteLine(kurs.kursAdi + ":" +kurs.Egitmen);
			}

			
		}
	}

	class kurs
	{
		public string kursAdi { get; set; }
		
		public string Egitmen { get; set; }

		public int izlenmeOrani { get; set; }
	}
}
