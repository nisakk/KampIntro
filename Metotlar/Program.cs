using System;

namespace Metotlar
{
	class Program
	{
		static void Main(string[] args)
		{
			Product product1 = new Product();
			product1.Adi = "Elma";
			product1.Fiyati = 15;
			product1.Aciklama = "Amasya Elması";

			Product product2 = new Product();
			product2.Adi = "Karpuz";
			product2.Fiyati = 80;
			product2.Aciklama = "Diyarbakır Karpuzu";


			Product[] products = new Product[] {product1,product2 };

			foreach (Product product in products)
			{
				Console.WriteLine(product.Adi);
				Console.WriteLine(product.Fiyati);
				Console.WriteLine(product.Aciklama);
				Console.WriteLine("----------------");
			}
			Console.WriteLine("--------Metotlar------");

			//instance örnek
			//encapsulation 

			SepetManager sepetManager = new SepetManager();
			sepetManager.Add(product1);
			sepetManager.Add(product2);

			sepetManager.Add2("Armut", "Yeşil armut", 12,10);
			sepetManager.Add2("ELma", "Yeşil Elma", 12,20);
			sepetManager.Add2("karpuz", "Diyarbakır karpuzu", 12,9);
		}
	}
}
