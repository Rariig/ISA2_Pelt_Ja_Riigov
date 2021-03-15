using System;

namespace Kordamine_Bob_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] numbers = new int[5];

			numbers[0] = 4;
			numbers[1] = 8;
			numbers[2] = 15;
			numbers[3] = 16;
			numbers[4] = 23;
			//numbers[5] = 43;

			Console.WriteLine(numbers[1]);
			Console.WriteLine(numbers.Length);

			int[] nrs = new int[] { 1, 5, 35, 65, 76 };
			string[] names = new string[] { "Kris", "Aleks", "Markus", "Rocco" };

			string quote = "Kristjan õpib programmeerimist";
			char[] charArray = quote.ToCharArray();
			Array.Reverse(charArray);

			foreach (char quoteChar in charArray)
			{
				Console.Write(quoteChar);
			}
		}
    }
}
