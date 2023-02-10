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
        Bread newBread = new Bread(5, 1);
        Assert.AreEqual(typeof(Bread), newBread.GetType());
      }
      [TestMethod]
      public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
      {
        Pastry newPastry = new Pastry(2);
        Assert.AreEqual(typeof(Pastry), newPastry.GetType());
      }
      [TestMethod]
      public void BreadCost_CalculateCost_Cost()
      {
        int Cost = 5;
        Bread b = new Bread(Cost, 1);
        Assert.AreEqual(b.Cost, Cost);
      }
      [TestMethod]
      public void PastryCost_CalculateCost_Cost()
      {
        int Cost = 2;
        Pastry p = new Pastry(Cost);
        Assert.AreEqual(p.Cost, Cost);
      }
      [TestMethod]
      //amount needed before discount
      public void BuyQuantity_CalculateCost_Cost()
      {
        int Quantity = 1;
        Bread q = new Bread(1, Quantity);
        Assert.AreEqual(q.BuyQuantity, Quantity);
      }
      [TestMethod]
      //amount needed before discount
      public void BuyQuantity_CalculateCost_Cost()
      {
        int Quantity = 1;
        Pastry q = new Pastry(1, Quantity);
        Assert.AreEqual(q.BuyQuantity, Quantity);
      }
    }
  }
