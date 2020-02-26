using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Message;

  public Car(string makeModel, int price, int miles, string message)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Message = message;
  }

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    if (Miles < maxMiles)
    {
      return (Price < maxPrice);
    }
    else
    {
      return false;
    }
  }
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "Best damn car I ever owned.");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "The real reason I opened this lot.");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "The Babysitter Special!");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "Rally Racer in the making.");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);
    Console.WriteLine("Enter maximum mileage: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
  if (CarsMatchingSearch.Count > 0)
  {
    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }
  else
  {
    Console.WriteLine("There is nothing for you here. Which is sad. We have a Koral.");
  }
  }
}