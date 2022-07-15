using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    // properties, constructors, methods, etc. go here
    public static int BreadPrice(int breadCount)
    {
      int breadprice = 0;
      List<int> breadList = new List<int>{};
      for(int i = 0; i <= breadCount; i++)
      {
        breadList.Add(i);
      }
      foreach(int bread in breadList)
      {
        if(bread % 3 == 0)
        {
          breadPrice += 0;
        }
        else
        {
          breadPrice += 5;
        }
      }
      return breadPrice;
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