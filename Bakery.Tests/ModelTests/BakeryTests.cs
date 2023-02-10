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
        Bread newBread = new Bread();
        Assert.AreEqual(typeof(Bread), newBread.GetType());
      }
      [TestMethod]
      public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
      {
        Pastry newPastry = new Pastry();
        Assert.AreEqual(typeof(Pastry), newPastry.GetType());
      }
    }
  }
