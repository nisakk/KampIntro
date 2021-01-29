using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
	class SepetManager
	{
		//maning converntion
		//syntax
		public void Add(Product product) 
		{
			Console.WriteLine("Tebrikler. Sepete Eklendi: " + product.Adi);
		
		}

		public void Add2(string productAdi, string acıklama, double fiyat, int stokAdeti)
		{
			Console.WriteLine("Tebrikler. sepete eklendi : " + productAdi);
		}
	}
}
