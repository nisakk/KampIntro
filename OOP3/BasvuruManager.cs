using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
	class BasvuruManager
	{
		public void BasvuruYap(IKrediManager krediManager) 
		{
			// Basvuran bilgilerini  değerlendirme 

			//Krediyi Hesapla

			//KonutKrediManager konutKrediManager = new KonutKrediManager();
			//konutKrediManager.Hesapla(); 

			krediManager.Hesapla();
		}

		public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
		{
			foreach (var kredi in krediler)
			{
				kredi.Hesapla();
			}
		
		}
	}
}
