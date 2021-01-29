using System;

namespace OOP2
{
	class Program
	{
		static void Main(string[] args)
		{
			GercekMusteri musteri1 = new GercekMusteri();
			musteri1.MusteriNO = "12345";
			musteri1.Adi = "Nisa";
			musteri1.Soyadi = "Küçükkömürcü";
			musteri1.TcNO = "11111111111";



			//Gerçek  - Tüzel  Müşteri birbirine benziyor diye birbirnin yerine kullanılmazlar 



			TuzelMusteri musteri2 = new TuzelMusteri();
			musteri2.Id = 12;
			musteri2.MusteriNO = "12222";
			musteri2.SirketAdi = "Kodlama";
			musteri2.VergiNO = "132432354345";


			Musteri musteri3 = new GercekMusteri();
			Musteri musteri4 = new TuzelMusteri();

			CustomerManager customerManager = new CustomerManager();
			customerManager Add ()

		}
	}
}
