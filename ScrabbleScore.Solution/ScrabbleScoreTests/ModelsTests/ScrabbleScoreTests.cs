using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace ScrabbleScoreTests
{
	[TestClass]
	public class ScrabbleTests
	{
		[TestMethod]
		public void GetScore_Score1_Int()
		{
			ScrabbleScore scrabble = new ScrabbleScore("aeioulnrst");
			int result = scrabble.GetScore();
			Assert.AreEqual(result, 10);
		}

		[TestMethod]
		public void GetScore_Score2_Int()
		{
			ScrabbleScore scrabble = new ScrabbleScore("dg");
			int result = scrabble.GetScore();
			Assert.AreEqual(result, 4);
		}

		[TestMethod]
		public void GetScore_Score3_Int()
		{
			ScrabbleScore scrabble = new ScrabbleScore("bcmp");
			int result = scrabble.GetScore();
			Assert.AreEqual(result, 12);
		}

		[TestMethod]
		public void GetScore_Score4_Int()
		{
			ScrabbleScore scrabble = new ScrabbleScore("fhvwy");
			int result = scrabble.GetScore();
			Assert.AreEqual(result, 20);
		}

		[TestMethod]
		public void GetScore_Score5_Int()
		{
			ScrabbleScore scrabble = new ScrabbleScore("k");
			int result = scrabble.GetScore();
			Assert.AreEqual(result, 5);
		}

		[TestMethod]
		public void GetScore_Score8_Int()
		{
			ScrabbleScore scrabble = new ScrabbleScore("jx");
			int result = scrabble.GetScore();
			Assert.AreEqual(result, 16);
		}

		[TestMethod]
		public void GetScore_Score10_Int()
		{
			ScrabbleScore scrabble = new ScrabbleScore("qz");
			int result = scrabble.GetScore();
			Assert.AreEqual(result, 20);
		}

		[TestMethod]
		public void GetScore_ScoreAll_Int()
		{
			ScrabbleScore scrabble = new ScrabbleScore("adbfkjq");
			int result = scrabble.GetScore();
			Assert.AreEqual(result, 33);
		}
	}
}