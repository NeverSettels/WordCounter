using System;
using WordCounter.Models;


namespace Program
{
  public class Run
  {
    public static void TypeSlow(string str)
    {
      for (int i = 0; i < str.Length; i++)
      {
        Console.Write(str[i]);
        System.Threading.Thread.Sleep(50);
      }
      Console.WriteLine();
    }
    public static void TypeFast(string str)
    {
      for (int i = 0; i < str.Length; i++)
      {
        Console.Write(str[i]);
        System.Threading.Thread.Sleep(5);
      }
      Console.WriteLine();
    }
    public static string Validate()
    {
      TypeSlow("Enter a word to count: ");
      string word = Console.ReadLine();
      if (RepeatCounter.VerifyWord(word))
      {
        return word;
      }
      else
      {
        TypeSlow("Sorry! that wont work! try again....");
        return Validate();
      }

    }

    public static void RunIt()
    {
      TypeSlow("Enter a Sentence to count words in: ");
      string sentence = Console.ReadLine();
      string word = Validate();
      int counted = RepeatCounter.CountWords(word, sentence);
      double percent = RepeatCounter.Percent(counted, RepeatCounter.CountTotalWords(sentence));
      TypeFast("----------------------------------------------------------------------");
      TypeSlow($"{word} appears {counted} times and makes up {percent}% of the total sentence");
      TypeFast("----------------------------------------------------------------------");
      TypeSlow("Would you like to do antoher? Y/N ");
      string response = Console.ReadLine().ToLower();
      if (response == "y") RunIt();
      else
      {
        TypeSlow("Glad I could Help!");
        TypeFast("----------------------------------------------------------------------");
        TypeSlow("Have a great day!");
      }
    }
    public static void Main()
    {
      RunIt();
    }
  }
}