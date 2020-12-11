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
  }
}