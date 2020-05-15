using System;

namespace WordCounter.Models
{
  public static class RepeatCounter
  {
    public static bool VerifyWord(string word)
    {
      word = word.ToLower();
      string[] wordArr = word.Split(' ');
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
  }

}