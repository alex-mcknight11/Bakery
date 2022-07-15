using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable;
  {
    // Test methods go here
    [TestMethod]
    public void BreadConstructor_CreatesBread_Bread()
    {
      Bread newBread = new Bread(1, "White");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
}