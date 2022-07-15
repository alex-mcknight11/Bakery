using System;

namespace Bakery {
  public class Program
  {
    public static void Main()
    {
      int breadTotal = 0;
      int pastryTotal = 0;
      int customerBreadCount = 0;
      int customerPastryCount = 0;

      Bread entryBread = new Bread(1, "none");
      int entryBreadPrice = Bread.BreadPrice(entryBread.BreadCount);
      Pastry entryPastry = new Pastry(1, "none");
      int entryPastryPrice = Pastry.PastryPrice(entryPastry.PastryCount);

      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Our specials today are 3 pastries for $5, or buy 2 get 1 for loaves of bread");
      Console.WriteLine("Order Below:");
    }
  }
}