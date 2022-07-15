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

      Console.WriteLine("Please choose one from the following options: ");
      string breadTypes = "White, Wheat, Sourdough, Banana, Rye, Whole Grain";
      Console.WriteLine(breadTypes);
      string customerBreadType = Console.ReadLine().ToLower();
      Console.WriteLine("How many loaves would you like to order?");
      customerBreadCount += int.Parse(Console.ReadLine());
      Bread customerBread = new Bread(customerBreadCount, customerBreadType);
      breadTotal += Bread.BreadPrice(customerBreadCount);

      Console.WriteLine("Please choose from one of the following options: ");
      string pastryTypes = "Bear Claw, Cruller, Crossaint, Cannoli, Scone, Baklava";
      Console.WriteLine(pastryTypes);
      string customerPastryType = Console.ReadLine().ToLower();
      Console.WriteLine("How many pastries would you like to order?");
      customerPastryCount += int.Parse(Console.ReadLine());
      Pastry customerPastry = new Pastry(customerPastryCount, customerPastryType);
      pastryTotal += Pastry.PastryPrice(customerPastryCount);

      Console.WriteLine("You ordered: ");
      Console.WriteLine("<------------------------------------------------>");
      Console.WriteLine(customerBread.BreadCount + " loaf/loaves of " + customerBread.BreadType);
      Console.WriteLine(customerPastry.PastryCount + " " + customerPastry.PastryType + "(s)");

      breadTotal += pastryTotal;
      Console.WriteLine("<------------------------------------------------>");
      Console.WriteLine("Your final total is $" + breadTotal + ".00");
      }
    }
  }