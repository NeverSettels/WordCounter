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
      string tester = "Well";
      bool length = RepeatCounter.VerifyWord(tester);
      Assert.AreEqual(false, length);

    }
  }
}