using System;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome. The cost for bread is as follows:");
      Console.WriteLine("For 1 loaf, it's $5. If you buy 2, then you get the 3rd for free.");
      Console.WriteLine("For pastries you can buy 1 for $2, or 3 for $5.");
      Console.WriteLine("How many loaves of bread would you like?");
      string breadCountString = Console.ReadLine();
      Console.WriteLine("How many pastries would you like?");
      string pastryCountString = Console.ReadLine();

      int breadCount = int.Parse(breadCountString);
      int pastryCount = int.Parse(pastryCountString);

      Pastry newPastry = new Pastry("yummy");
      int pastryCost = newPastry.PastryOrderCalc(pastryCount);

      Bread newBread = new Bread("yummy");
      int breadCost = newBread.BreadOrderCalc(breadCount);

      int orderTotal = pastryCost + breadCost;

      Console.WriteLine("This is your total order cost: " + orderTotal);

    }
  }

}


