using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.TestTools
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void Scrabble_GetScore_ScoresWorth1()
    {
      ScrabbleGame tester = new ScrabbleGame();
      int score = tester.GetScore("aeioulnrst");
      Assert.AreEqual(10, score);
    }
    [TestMethod]
    public void Scrabble_GetScore_ScoresWorth2()
    {
      ScrabbleGame tester = new ScrabbleGame();
      int score = tester.GetScore("dog");
      Assert.AreEqual(5, score);
    }
    [TestMethod]
    public void Scrabble_GetScore_ScoresWorth3()
    {
      ScrabbleGame tester = new ScrabbleGame();
      int score = tester.GetScore("bcmp");
      Assert.AreEqual(12, score);
    }
    [TestMethod]
    public void Scrabble_GetScore_ScoresWorth4()
    {
      ScrabbleGame tester = new ScrabbleGame();
      int score = tester.GetScore("fhvwy");
      Assert.AreEqual(20, score);
    }
    [TestMethod]
    public void Scrabble_GetScore_ScoresWorth5()
    {
      ScrabbleGame tester = new ScrabbleGame();
      int score = tester.GetScore("k");
      Assert.AreEqual(5, score);
    }
    [TestMethod]
    public void Scrabble_GetScore_ScoresWorth8()
    {
      ScrabbleGame tester = new ScrabbleGame();
      int score = tester.GetScore("jx");
      Assert.AreEqual(16, score);
    }
    [TestMethod]
    public void Scrabble_GetScore_ScoresWorth10()
    {
      ScrabbleGame tester = new ScrabbleGame();
      int score = tester.GetScore("qz");
      Assert.AreEqual(20, score);
    }
  }
}