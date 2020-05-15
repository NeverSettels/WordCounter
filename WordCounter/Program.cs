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
    public static void Main()
    {

    }
  }
}