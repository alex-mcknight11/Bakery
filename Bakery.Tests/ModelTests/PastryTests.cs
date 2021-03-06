using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }
  
    // Test methods go here
    [TestMethod]
    public void PastryConstructor_CreatesPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1, "Bear Claw");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void PastryCount_ReturnPastryCount_Int()
    {
      Pastry newPastry = new Pastry(1, "Croissant");
      int pastryNumber = newPastry.PastryCount;
      Assert.AreEqual(pastryNumber,1);
    }
  }
}