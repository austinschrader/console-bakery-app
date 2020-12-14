using System.ComponentModel.Design.Serialization;

namespace Bakery
{
  public class Pastry
  {
    public string Taste { get; set; }

    public Pastry(string taste)
    {
      Taste = taste;
    }

    public int PastryOrderCalc(int pastryCount)
    {
      int unitOfThree = pastryCount / 3;
      int remainder = pastryCount % 3;

      int pastryCost = (unitOfThree * 5) + (remainder * 2);
      return pastryCost;
    }
  }
}