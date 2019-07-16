using System;

  class Palabra
  {
    public string StringPalabra;
    public Palabra(string palabra)
    {
      StringPalabra = palabra;
    }

    public bool truePal()
    {
      char [] arrayPalabra = StringPalabra.ToCharArray();
      char [] reverseCopy = (char[]) arrayPalabra.Clone();

      Array.Reverse(reverseCopy);

      string stringPalabra = string.Join(",", arrayPalabra);
      string stringReverse = string.Join(",", reverseCopy);

      if (stringPalabra == stringReverse)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Palindrome Tracker");
      Console.WriteLine("Enter a word: ");
      string userPalabra = Console.ReadLine();

      Palabra newPalabra = new Palabra (userPalabra);

      if (newPalabra.truePal())
      {
        Console.WriteLine("This is a palindrome!");
      }
      else
      {
        Console.WriteLine("That is not a palindrome!");
      }
      Main ();
      }
   }
