using System;

namespace app013_vowel_count
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("========================================================================");
			Console.WriteLine("Подсчет количества гласных букв в введенной пользователем строке");
			Console.WriteLine("========================================================================");
			Console.WriteLine();

			Console.WriteLine("Введите строку: ");
			String s = Console.ReadLine();
			Console.WriteLine(GetVowelCount(s));

			Console.WriteLine();
			Console.WriteLine("========================================================================");
			Console.WriteLine("Для выхода из программы нажмите любую клавишу...");
			Console.ReadKey();
		}


		public static int GetVowelCount(string str)
		{
			int vowelCount = 0;

			char [] vowels = { 'a', 'e', 'i', 'o', 'u' };
			// Разделяю строку на массив символов в строковом формате
			char[] array = str.ToCharArray();

			//пробегаюсь по массиву и сравниваю каждый элемент в массивве vowels с элементом в array
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < vowels.Length; j++)
				{
					if (array[i] == vowels[j]) 
					{
						vowelCount++;
					}
				}
			}
			return vowelCount;
		}
	}
}
