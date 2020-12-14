using System;

namespace Bakery
{
  public class Bread
  {
    public string Taste { get; set; }

    public Bread(string taste)
    {
      Taste = taste;
    }

    public int BreadOrderCalc(int breadCount)
    {
      int unitOfThree = breadCount / 3;
      int remainder = breadCount % 3;

      int breadCost = (unitOfThree * 15) + (remainder * 5);
      return breadCost;
    }
  }
}