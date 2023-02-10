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
        BakeryItems newBakeryItems = new BakeryItems();
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
        int Cost = 5;
        Bread b = new Bread(Cost, 1, 4);
        Assert.AreEqual(b.Cost, Cost);
      }
      [TestMethod]
      public void PastryCost_CalculateCost_Cost()
      {
        int Cost = 2;
        Pastry p = new Pastry(Cost, 1, 3);
        Assert.AreEqual(p.Cost, Cost);
      }
      [TestMethod]
      //amount needed before discount
      public void BuyQuantity_CalculateCost_Cost()
      {
        int Quantity = 1;
        Bread q = new Bread(1, Quantity, 4);
        Assert.AreEqual(q.BuyQuantity, Quantity);
      }
      [TestMethod]
      //amount needed before discount
      public void BuyQuantityPastry_CalculateCost_Cost()
      {
        int Quantity = 1;
        Pastry q = new Pastry(1, Quantity, 3);
        Assert.AreEqual(q.BuyQuantity, Quantity);
      }
      [TestMethod]
      //amount needed after discount
      public void BuyQuantityDiscount_CalculateDiscountedCost_Cost()
      {
        int Quantity = 3;
        Bread q = new Bread(3, 3, Quantity);
        Assert.AreEqual(q.DiscountQuantity, Quantity);
      }
      [TestMethod]
      //amount needed after discount
      public void BuyQuantityDiscountPastry_CalculateDiscountedCost_Cost()
      {
        int Quantity = 4;
        Pastry q = new Pastry(3, 3, Quantity);
        Assert.AreEqual(q.DiscountQuantity, Quantity);
      }
    }
  }
