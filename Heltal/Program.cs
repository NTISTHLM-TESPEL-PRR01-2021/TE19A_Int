using System;

namespace Heltal
{
  class Program
  {
    static void Main(string[] args)
    {

      string name = "77" + "33";

      int health = 100;

      health = health - 10;

      int points = 0;

      points = points + 1;

      points += 10;

      points++;

      if (points > 10)
      {
        Console.WriteLine("#winning");
      }
      else if (points > 5)
      {
        Console.WriteLine("#almostwinning");
      }
      else
      {
        Console.WriteLine("#notwinning");
      }


      Console.WriteLine("Points: " + points);

      Console.WriteLine(health);
      //Console.WriteLine(newHealth);

      Console.ReadLine();
    }
  }
}
