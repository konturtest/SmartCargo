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

			List<string> unsortedCargoList = new List<string>();

				while (true)
					{
						var line = Console.ReadLine();
						if (line == "END") break;
					unsortedCargoList.Add(line);
					}

				string [][] unsortedCargoSplitList = new string[unsortedCargoList.Count][];

				foreach (var item in unsortedCargoList)
				{

					string[] param = item.Split(new char[] { ';' });
			}

			// Следующие шаги:в цикле foreach сохранять Param, потому что в следующем цикле он пропадёт. Сохранить можно в list2

			foreach (var item in unsortedCargoList)
				Console.WriteLine(item);
			//этот foreach нужен будет после сортировки

			//сделать так, чтобы после парсинга по ; распарсенные данные сохранялись в массив
			//попробовать сортировку - отсортироват по одному типу параметорв (колонке)

		}
	}
}



