using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("yummy");
      string myTaste = "yummy";
      Assert.AreEqual(typeof(Bread), newBread.GetType());
      Assert.AreEqual(myTaste, newBread.Taste);
    }

    [TestMethod]
    public void BreadOrderCalc_ReturnsBreadTotalForZeroLoaves_Int()
    {
      Bread newBread = new Bread("yummy");
      int breadCount = 0;
      int breadCost = 0;
      Assert.AreEqual(breadCost, newBread.BreadOrderCalc(breadCount));
    }

    [TestMethod]
    public void BreadOrderCalc_ReturnsBreadTotalForTwoLoaves_Int()
    {
      Bread newBread = new Bread("yummy");
      int breadCount = 2;
      int breadCost = 10;
      Assert.AreEqual(breadCost, newBread.BreadOrderCalc(breadCount));
    }

    [TestMethod]
    public void BreadOrderCalc_ReturnsBreadTotalForThreeLoaves_Int()
    {
      Bread newBread = new Bread("yummy");
      int breadCount = 3;
      int breadCost = 10;
      Assert.AreEqual(breadCost, newBread.BreadOrderCalc(breadCount));
    }

    [TestMethod]
    public void BreadOrderCalc_ReturnsBreadTotalForFourLoaves_Int()
    {
      Bread newBread = new Bread("yummy");
      int breadCount = 4;
      int breadCost = 15;
      Assert.AreEqual(breadCost, newBread.BreadOrderCalc(breadCount));
    }

    [TestMethod]
    public void BreadOrderCalc_ReturnsBreadTotalForFiveLoaves_Int()
    {
      Bread newBread = new Bread("yummy");
      int breadCount = 5;
      int breadCost = 20;
      Assert.AreEqual(breadCost, newBread.BreadOrderCalc(breadCount));
    }

    [TestMethod]
    public void BreadOrderCalc_ReturnsBreadTotalForSixLoaves_Int()
    {
      Bread newBread = new Bread("yummy");
      int breadCount = 6;
      int breadCost = 20;
      Assert.AreEqual(breadCost, newBread.BreadOrderCalc(breadCount));
    }

  }
}