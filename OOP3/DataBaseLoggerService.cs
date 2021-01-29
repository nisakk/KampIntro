using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
	class DataBaseLoggerService : ILoggerService
	{
		public void Log() 
		
		{
			Console.WriteLine("VeriTabanına Loglandı");
		
		}



	}

	namespace OOP3
	{
		class FileLoggerService : ILoggerService
		{
			public void Log()

			{
				Console.WriteLine("Dosyaya  Loglandı");

			}



		}

	}
