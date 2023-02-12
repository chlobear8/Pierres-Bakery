using System;
using System.Collections.Generic;
using Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.Writeline("Welcome to Pierre's Bakery!");
      Console.Writeline("Would you like to buy some bread or pastries? [B] for bread or [P] for pastries");
      string answer = Console.ReadLine();
      if (answer == "B" || answer == "b")
      {
        Console.Writeline("How many breads would you like?");
        string stringBQuantity = Console.ReadLine();
        int bQuantity = int.Parse(stringBQuantity);
        {
          Console.Writeline(bQuantity.BuyOneGetOne())
        }
      }
    }
  }
}