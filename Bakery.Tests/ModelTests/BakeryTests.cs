using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
      public void BakeryConstructor_CreatesInstanceOfBakery_Bakery()
      {
        BakeryItems newBakeryItems = new BakeryItems(5, 3, 1);
        Assert.AreEqual(typeof(BakeryItems), newBakeryItems.GetType());
      }
      [TestMethod]
      public void BreadConstructor_CreatesInstanceOfBread_Bread()
      {
        Bread newBread = new Bread(5, 1, 5);
        Assert.AreEqual(typeof(Bread), newBread.GetType());
      }
      [TestMethod]
      public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
      {
        Pastry newPastry = new Pastry(2, 1, 3);
        Assert.AreEqual(typeof(Pastry), newPastry.GetType());
      }
      [TestMethod]
      public void BreadCost_CalculateCost_Cost()
      {
        int cost = 5;
        Bread b = new Bread(cost, 1, 4);
        Assert.AreEqual(b.GetCost(), cost);
      }
      [TestMethod]
      public void PastryCost_CalculateCost_Cost()
      {
        int cost = 2;
        Pastry p = new Pastry(cost, 1, 3);
        Assert.AreEqual(p.GetCost(), cost);
      }
      [TestMethod]
      //amount needed before discount
      public void BuyQuantity_CalculateCost_Cost()
      {
        int Quantity = 1;
        Bread q = new Bread(5, Quantity, 4);
        Assert.AreEqual(q.GetBuyQuantity(), Quantity);
      }
      [TestMethod]
      //amount needed before discount
      public void BuyQuantityPastry_CalculateCost_Cost()
      {
        int Quantity = 1;
        Pastry q = new Pastry(2, Quantity, 3);
        Assert.AreEqual(q.GetBuyQuantity(), Quantity);
      }
      [TestMethod]
      //amount needed after discount
      public void BuyQuantityDiscount_CalculateDiscountedCost_Cost()
      {
        int Quantity = 3;
        Bread q = new Bread(5, 3, Quantity);
        Assert.AreEqual(q.GetDiscountQuantity(), Quantity);
      }
      [TestMethod]
      //amount needed after discount
      public void BuyQuantityDiscountPastry_CalculateDiscountedCost_Cost()
      {
        int Quantity = 4;
        Pastry q = new Pastry(3, 3, Quantity);
        Assert.AreEqual(q.GetDiscountQuantity(), Quantity);
      }
      [TestMethod]
      public void GetCostForQuanity_CalculateCost_Cost()
      {
        Bread b = new Bread(5, 2, 1);
        Assert.AreEqual(b.GetCostForQuantity(3), 10);
      }
      [TestMethod]
      public void GetCostForQuanityPastry_CalculateCost_Cost()
      {
        Pastry p = new Pastry(2, 3, 1);
        Assert.AreEqual(p.GetCostForQuantity(4), 6);
      }
      [TestMethod]
      public void CreateDiscountedCost_CalculateDiscount_Cost()
      {
        Pastry p = new Pastry(2, 3, 1);
        Assert.AreEqual(p.BuyOneGetOne(3), 6);
      }
      [TestMethod]
      public void CreateDiscountedCostBread_CalculateDiscount_Cost()
      {
        Bread b = new Bread(5, 2, 1);
        Assert.AreEqual(b.BuyOneGetOne(2), 10);
      }
    }
  }


