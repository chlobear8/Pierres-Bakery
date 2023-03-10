using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class BakeryItems
  {
    private int _cost { get; set; }
    private int _buyQuantity { get; set; }
    private int _discountQuantity { get; set; }

    public BakeryItems(int cost, int buyQuantity, int discountQuantity)
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

    public int BuyOneGetOne(int quantity)
    {
      Bread b = new Bread (5, 3, 1);
      Pastry p = new Pastry (2, 4, 1);
      return b.GetCostForQuantity(quantity) + p.GetCostForQuantity(quantity);
    }
  }
}