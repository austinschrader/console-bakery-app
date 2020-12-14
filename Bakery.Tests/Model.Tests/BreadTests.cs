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
    public void BreadOrderCalc_ReturnsBreadTotal_Int()
    {
      Bread newBread = new Bread("yummy");
      int breadCount = 3;
      int breadCost = 15;
      Assert.AreEqual(breadCost, newBread.BreadOrderCalc(breadCount));
    }

  }
}