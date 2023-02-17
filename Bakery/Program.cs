using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery.Models
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
          Console.WriteLine("How many breads would you like? They are $5 each or 'Buy 2, get 1 Free'");
          string stringBQuantity = Console.ReadLine();
          int bQuantity = int.Parse(stringBQuantity);
          {
            Bread b = new Bread (5, 2, 1);
            Console.WriteLine("Your bread will cost $" + b.GetCostForQuantity(bQuantity));
          }
        }
          else if (answer == "P" || answer == "p")
        {
          Console.WriteLine("How many pastries would you like? They are $2 each or 'Buy 3, get 1 Free'");
          string stringPQuantity = Console.ReadLine();
          int pQuantity = int.Parse(stringPQuantity);
          {
            Pastry p = new Pastry (2, 3, 1);
            Console.WriteLine("Your pastries will cost $" + p.GetCostForQuantity(pQuantity));
          }
        }
        else
        {
          Console.WriteLine("Are you finished shopping? ['Y' for yes, 'Enter' for no]");
          string finished = Console.ReadLine();
          if (finished == "Y" || finished == "y")
          {
            Console.WriteLine("Thanks for shopping with us!");
          }
          else
          {
            Main();
          }
        }
      }
    }
  }


