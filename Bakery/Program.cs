using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Would you like to buy some bread or pastries? ['B'] for bread or ['P'] for pastries");
      string answer = Console.ReadLine();
        if (answer == "B" || answer == "b")
        {
          Console.WriteLine("How many breads would you like?");
          string stringBQuantity = Console.ReadLine();
          int bQuantity = int.Parse(stringBQuantity);
          {
            Console.WriteLine("Your bread will cost $" + Bakery.Models.BuyOneGetOne(bQuantity));
          }
        }
      }
    }
  }
