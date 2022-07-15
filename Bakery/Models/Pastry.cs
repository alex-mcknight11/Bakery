using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Pastry
  {

    public int PastryCount { get; set; }
    public string PastryType { get; set; }
    public Pastry (int Count, string Type)
    {
      PastryCount = Count;
      PastryType = Type;
    }
    private static List<Pastry> _instances = new List<Pastry>{};

    public static int PastryPrice(int pastryCount)
    {
      int pastryPrice = 0;
      List<int> pastryList = new List<int>{};
      for(int i = 0; i <= pastryCount; i ++)
      {
        pastryList.Add(i);
      }
      foreach(int pastry in pastryList)
      {
        if(pastry % 3 == 0)
        {
          int pastryMultiplier = pastry / 3;
          pastryPrice = pastryMultiplier * 5;
        }
        else
        {
          pastryPrice += 2;
        }
      }
      return pastryPrice;
    }

    public static List<Pastry> GetAllPastries()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
