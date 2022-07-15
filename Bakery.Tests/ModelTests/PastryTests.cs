using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    // Test methods go here
    [TestMethod]
    public void PastryConstructor_CreatesPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1, "Bear Claw");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
      
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("Behavior is behaving", ClassName.Method("Behavior"));
    }
  }
}