using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }
  
    // Test methods go here
    [TestMethod]
    public void BreadConstructor_CreatesBread_Bread()
    {
      Bread newBread = new Bread(1, "White");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void BreadCount_ReturnBreadCount_Int()
    {
      Bread newBread = new Bread(1, "White");
      int BreadNumber = newBread.BreadCount;
      Assert.AreEqual(BreadNumber, 1);
    }
  }
}