using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    private  string  _makeModel;
    private int _price;
    private  static List<Car> _instances = new List<Car> {};

    public Car (string makeModel, int price)
    {
      _makeModel=makeModel;
      _price=price;
    }

    //get set
     public  string GetMakeModel()
     {
       return _makeModel;
     }

     public  void SetMakeModel(string makeModel)
     {
       _makeModel=makeModel;
     }

     public  int GetPrice()
     {
       return _price;
     }

     public  void SetPrice(int price)
     {
       _price=price;
     }

     public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
  {
    _instances.Clear();
  }

  // public static Car Find(int searchPrice)
  //   {
  //     return _instances[searchPrice-1];
  //   }


  }
}
