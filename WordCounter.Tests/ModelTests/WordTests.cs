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
  }
}