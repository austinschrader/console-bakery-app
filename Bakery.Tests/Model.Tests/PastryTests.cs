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
    public void PastryOrderCalc_ReturnsPastryTotalForZeroPastries_Int()
    {
      Pastry newPastry = new Pastry("yummy");
      int pastryCount = 0;
      int pastryCost = 0;
      Assert.AreEqual(pastryCost, newPastry.PastryOrderCalc(pastryCount));
    }

    [TestMethod]
    public void PastryOrderCalc_ReturnsPastryTotalForOnePastry_Int()
    {
      Pastry newPastry = new Pastry("yummy");
      int pastryCount = 1;
      int pastryCost = 2;
      Assert.AreEqual(pastryCost, newPastry.PastryOrderCalc(pastryCount));
    }

    [TestMethod]
    public void PastryOrderCalc_ReturnsPastryTotalForTwoPastries_Int()
    {
      Pastry newPastry = new Pastry("yummy");
      int pastryCount = 2;
      int pastryCost = 4;
      Assert.AreEqual(pastryCost, newPastry.PastryOrderCalc(pastryCount));
    }

    [TestMethod]
    public void PastryOrderCalc_ReturnsPastryTotalForThreePastries_Int()
    {
      Pastry newPastry = new Pastry("yummy");
      int pastryCount = 3;
      int pastryCost = 5;
      Assert.AreEqual(pastryCost, newPastry.PastryOrderCalc(pastryCount));
    }

    [TestMethod]
    public void PastryOrderCalc_ReturnsPastryTotalForFourPastries_Int()
    {
      Pastry newPastry = new Pastry("yummy");
      int pastryCount = 4;
      int pastryCost = 7;
      Assert.AreEqual(pastryCost, newPastry.PastryOrderCalc(pastryCount));
    }

    [TestMethod]
    public void PastryOrderCalc_ReturnsPastryTotalForFivePastries_Int()
    {
      Pastry newPastry = new Pastry("yummy");
      int pastryCount = 6;
      int pastryCost = 10;
      Assert.AreEqual(pastryCost, newPastry.PastryOrderCalc(pastryCount));
    }

    [TestMethod]
    public void PastryOrderCalc_ReturnsPastryTotalForSixPastries_Int()
    {
      Pastry newPastry = new Pastry("yummy");
      int pastryCount = 6;
      int pastryCost = 10;
      Assert.AreEqual(pastryCost, newPastry.PastryOrderCalc(pastryCount));
    }

  }
}