using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Bread b = new Bread (5, 2, 1);
      Pastry p = new Pastry (2, 3, 1);
      bool done = false;
      int pQuantity = 0;
      int bQuantity = 0;
      while(!done) {
        Console.WriteLine("Welcome to Pierre's Bakery!");
        Console.WriteLine("Would you like to buy some bread or pastries? ['P'] for pastries, ['B'] for bread or ['F'] for finished");
      string answer = Console.ReadLine();
        if (answer == "p" || answer == "P") 
        {
          Console.WriteLine("How many pastries would you like? They are $2 each or 'Buy 3, get 1 FREE'");
          string stringPQuantity = Console.ReadLine();
          pQuantity = int.Parse(stringPQuantity);
          Console.WriteLine("Your pastries will cost $" + p.GetCostForQuantity(pQuantity));
        } else if (answer == "b" || answer == "B") 
        {
          Console.WriteLine("How many breads would you like? They are $5 each or 'Buy 2, get 1 FREE'");
          string stringBQuantity = Console.ReadLine();
          bQuantity = int.Parse(stringBQuantity);
          Console.WriteLine("Your bread will cost $" + b.GetCostForQuantity(bQuantity));
        } else if (answer == "f" || answer == "F") 
        {
          Console.WriteLine("Here's your cost for bread $" + b.GetCostForQuantity(bQuantity) + " and your cost for pastries $" + p.GetCostForQuantity(pQuantity) + ".");
          Console.WriteLine("Making your total $" + (b.GetCostForQuantity(bQuantity) + p.GetCostForQuantity(pQuantity)) + ". Thank you for shopping at Pierre's!");
          done=true;
        }
      }
    }
  }
}

