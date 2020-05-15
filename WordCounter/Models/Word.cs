using System;

namespace Scrabble.Models
{
  public class ScrabbleGame
  {
    public int GetScore(string word)
    {
      word = word.ToLower();
      int score = 0;
      for (int i = 0; i < word.Length; i++)
      {
        if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'l' || word[i] == 'n' || word[i] == 'r' || word[i] == 's' || word[i] == 't')
        {
          score++;
        }
        else if (word[i] == 'd' || word[i] == 'g')
        {
          score += 2;
        }
        else if (word[i] == 'b' || word[i] == 'c' || word[i] == 'm' || word[i] == 'p')
        {
          score += 3;
        }
        else if (word[i] == 'f' || word[i] == 'h' || word[i] == 'v' || word[i] == 'w' || word[i] == 'y')
        {
          score += 4;
        }
        else if (word[i] == 'k')
        {
          score += 5;
        }
        else if (word[i] == 'j' || word[i] == 'x')
        {
          score += 8;
        }
        else if (word[i] == 'q' || word[i] == 'z')
        {
          score += 10;
        }
        else
        {
          score = 0;
          break;
        }
      }
      return score;
    }
  }
}