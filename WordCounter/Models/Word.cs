using System;

namespace WordCounter.Models
{
  public static class RepeatCounter
  {
    public static bool VerifyWord(string word)
    {
      word = word.ToLower();
      for (int i = 0; i < word.Length; i++)
      {
        if ((int)word[i] < 97 || (int)word[i] > 122)
        {
          return false;
        }
      }
      if (word.Length <= 1)
      {
        return false;
      }
      return true;
    }
    public static string RemoveSpecial(string word)
    {
      word = word.ToLower();
      string editedString = "";
      foreach (char character in word)
      {
        if ((int)character == 32)
        {
          editedString += character;
        }
        else if ((int)character >= 97 && (int)character <= 122)
        {
          editedString += character;
        }
      }
      return editedString;
    }
    public static double Percent(int found, int total)
    {
      double percentage = Math.Round(((double)found / (double)total * 100.0), 2);
      return percentage;
    }
    public static int CountTotalWords(string sentence)
    {
      int counter = 0;
      sentence = RemoveSpecial(sentence);
      string[] sentenceArr = sentence.Split(" ");
      counter = sentenceArr.Length;
      return counter;
    }
    public static int CountWords(string word, string sentence)
    {
      int counter = 0;
      sentence = RemoveSpecial(sentence);
      string[] sentenceArr = sentence.Split(" ");
      foreach (string wordTBChecked in sentenceArr)
      {
        if (word == wordTBChecked)
        {
          counter++;
        }
      }
      return counter;
    }
  }

}