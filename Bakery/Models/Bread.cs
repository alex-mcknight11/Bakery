using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {

    public int BreadCount { get; set; }
    public string BreadType { get; set; }
    public Bread (int Count, string Type)
    {
      BreadCount = Count;
      BreadType = Type;
    }
    private static List<Bread> _instances = new List<Bread>{};

    public static int BreadPrice(int breadCount)
    {
      int BreadPrice = 0;
      List<int> BreadList = new List<int>{};
      for(int i = 0; i <= breadCount; i++)
      {
        BreadList.Add(i);
      }
      foreach(int bread in BreadList)
      {
        if(bread % 3 == 0)
        {
          BreadPrice += 0;
        }
        else
        {
          BreadPrice += 5;
        }
      }
      return BreadPrice;
    }

    public static List<Bread> GetAllBread()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}