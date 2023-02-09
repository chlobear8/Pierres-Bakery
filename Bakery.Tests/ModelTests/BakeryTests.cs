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
        BakeryItems newBakeryItems = new BakeryItems(1);
        Assert.AreEqual(typeof(BakeryItems), newBakeryItems.GetType());
      }
      [TestMethod]
      public void GetBakeryType_ReturnsBread_Bread()
      {
        int bread = 1;
        BakeryItems newItem = new BakeryItems(1);
        string result = newItem;
        Assert.AreEqual(result, bread);
      }
    }
  }
