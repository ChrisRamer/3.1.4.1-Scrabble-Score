using System;
using System.Collections.Generic;

namespace Scrabble
{
	public class ScrabbleScore
	{
		public string WordPlayed {get; set;}
		Dictionary<int, List<char>> lettersWithScores = new Dictionary<int, List<char>>()
		{
			{ 1, new List<char>() { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' } },
			{ 2, new List<char>() { 'D', 'G' } },
			{ 3, new List<char>() { 'B', 'C', 'M', 'P' } },
			{ 4, new List<char>() { 'F', 'H', 'V', 'W', 'Y' } },
			{ 5, new List<char>() { 'K' } },
			{ 8, new List<char>() { 'J', 'X' } },
			{ 10, new List<char>() { 'Q', 'Z' } },
		};

		public ScrabbleScore(string word)
		{
			this.WordPlayed = word;
		}

		public int GetScore()
		{
			int score = 0;

			for (int i = 0; i < WordPlayed.Length; i++)
			{
				foreach (KeyValuePair<int, List<char>> kvp in lettersWithScores)
				{
					for (int j = 0; j < kvp.Value.Count; j++)
					{
						if (kvp.Value[j] == WordPlayed[i]) score += kvp.Key;
					}
				}
			}

			return score;
		}
	}
}