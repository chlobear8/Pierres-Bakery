using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class Bread
  {
    private int _cost { get; set; }
    private int _buyQuantity { get; set; }
    private int _discountQuantity { get; set; }

    public Bread(int cost, int buyQuantity, int discountQuantity)
    {
      _cost = cost;
      _buyQuantity = buyQuantity;
      _discountQuantity = discountQuantity;
    }

    public int GetCost()
    {
      return _cost;
    }

    public int GetBuyQuantity()
    {
      return _buyQuantity;
    }

    public int GetDiscountQuantity()
    {
      return _discountQuantity;
    }

    public int GetCostForQuantity(int quantity)
    {
      double CalculatedCost = Math.Ceiling(1.0*quantity*_buyQuantity/(_buyQuantity+_discountQuantity))*_cost;
      return (int)(CalculatedCost);
    }
  }
}