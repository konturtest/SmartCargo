using System;
using System.Collections.Generic;

namespace SmartCargo
{
	class Program
	{
		public static void Main()
		{

			Console.WriteLine("Введите необходимую информацию о грузах — через ; без пробелов. Если вы закончили, введите слово END.");

			string[] cargoParams = new string[] { "NAME", "WEIGHT", "DATE_BEGIN", "DATE_END", "IMPORTANCE_LEVEL" };

			List<string> unsortedList = new List<string>();

				while (true)
					{
						var line = Console.ReadLine();
						if (line == "END") break;
					unsortedList.Add(line);
					}

				foreach (var item in unsortedList)
					Console.WriteLine(item);
				//этот foreach нужен будет после сортировки

				string [][] list2 = new string[unsortedList.Count][];

				foreach (var item in unsortedList)
				{

					string[] param = item.Split(new char[] { ';' });
			}
				
// Следующие шаги:в цикле foreach сохранять Param, потому что в следующем цикле он пропадёт. Сохранить можно в list2


		}
	}
}



