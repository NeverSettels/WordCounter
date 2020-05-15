using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.TestTools
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void WordCounter_VerifyWord_ReturnFalseIfLength1()
    {
      string tester = "W";
      bool length = RepeatCounter.VerifyWord(tester);
      Assert.AreEqual(false, length);
    }
    [TestMethod]
    public void WordCounter_VerifyWord_ReturnTrueIfvalid()
    {
      string tester = "well";
      bool length = RepeatCounter.VerifyWord(tester);
      Assert.AreEqual(true, length);
    }

    [TestMethod]
    public void WordCounter_VerifyWord_ReturnFlaseflaseIfSpecialChar()
    {
      string tester = "We.l.l";
      bool length = RepeatCounter.VerifyWord(tester);
      Assert.AreEqual(false, length);
    }

    [TestMethod]
    public void WordCounter_RemoveSpecail_TakeInvalidCharsOut()
    {
      string tester = "dogs, are great. companions!";
      string edited = RepeatCounter.RemoveSpecial(tester);
      Assert.AreEqual("dogs are great companions", edited);
    }

    [TestMethod]
    public void WordCounter_CountTotalWords_ReturnNumber()
    {
      string tester = "dogs, are great. companions! dogs are the best";
      int counted = RepeatCounter.CountTotalWords(tester);
      Assert.AreEqual(8, counted);
    }

    [TestMethod]
    public void WordCounter_CountWords_ReturnNumber()
    {
      string tester = "dogs, are great. companions! dogs are the best";
      int counted = RepeatCounter.CountWords("dogs", tester);
      Assert.AreEqual(2, counted);
    }

    [TestMethod]
    public void WordCounter_Percent_returnDouble()
    {
      string tester = "dogs, are great. companions! dogs are the best";
      double counted = RepeatCounter.Percent(1, 4);
      Assert.AreEqual(25, counted);

    }
  }
}