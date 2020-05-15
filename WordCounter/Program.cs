using System;
using Scrabble.Models;

namespace Program
{
  public class ScrabbleCalculator
  {
    public static void Type(string str)
    {
      for (int i = 0; i < str.Length; i++)
      {
        Console.Write(str[i]);
        System.Threading.Thread.Sleep(50);
      }
      Console.WriteLine();
    }
    static void Main()
    {
      ScrabbleGame game = new ScrabbleGame();
    repeat:
      try
      {
        Type("Enter a word to check it's scrabble point value:");
        string userInput = Console.ReadLine();
        int score = game.GetScore(userInput);
        int allowed = 1 / score;
        Type("Your score is: " + score);
      }
      catch
      {
        Type("Enter a valid input please you no-instructions reading ass");
        goto repeat;
      }

    }
  }
}