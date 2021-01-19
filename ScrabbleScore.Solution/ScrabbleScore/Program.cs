using System;
using System.Text.RegularExpressions;

namespace Scrabble
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Give me a word and I will tell you its Scrabble score!");

			string word = Console.ReadLine();
			if (!Regex.IsMatch(word, @"^[a-zA-Z]+$"))
			{
				Console.WriteLine("ERROR: Must give one word in English characters.");
				return;
			}

			ScrabbleScore scrabble = new ScrabbleScore(word.ToUpper());

			Console.WriteLine("-------------------------");
			Console.WriteLine("The word '" + word + "' scores you " + scrabble.GetScore() + " points!");
		}
	}
}