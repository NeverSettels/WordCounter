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
  }

}