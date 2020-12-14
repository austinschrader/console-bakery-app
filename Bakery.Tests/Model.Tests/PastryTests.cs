using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;
using System.ComponentModel;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry("yummy!");
      string myTaste = "yummy!";
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
      Assert.AreEqual(myTaste, newPastry.Taste);
    }

    [TestMethod]
    public void PastryOrderCalc_ReturnsPastryTotal_Int()
    {
      Pastry newPastry = new Pastry("yummy");
      int pastryCount = 3;
      int pastryCost = 5;
      Assert.AreEqual(pastryCost, newPastry.PastryOrderCalc(pastryCount));
    }

  }
}