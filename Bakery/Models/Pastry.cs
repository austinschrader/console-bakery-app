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
      int pastryCost = 0;
      if (pastryCount == 0)
      {
        pastryCost = 0;
        return pastryCost;
      }
      else if (pastryCount == 1)
      {
        pastryCost = 2;
        return pastryCost;
      }
      else if (pastryCount == 2)
      {
        pastryCost = 3;
        return pastryCost;
      }
      else if (pastryCount == 3)
      {
        pastryCost = 5;
        return pastryCost;
      }
      return pastryCost;

    }
  }
}