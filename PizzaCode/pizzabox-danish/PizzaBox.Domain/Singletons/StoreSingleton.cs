using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Domain.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class StoreSingleton
  {
    private static StoreSingleton _storeSingleton;
    public List<AStore> Stores { get; set; } // print job
    public List<APizza> aPizzas {get; set; } // storing pizza list
    public static StoreSingleton Instance
    {
      get
      {
        if (_storeSingleton == null)
        {
          _storeSingleton = new StoreSingleton(); // printer
        }

        return _storeSingleton;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private StoreSingleton()
    {
      // var fs = new FileStorage();

      // if (Stores == null)
      // {
      //   Stores = fs.ReadFromXml<AStore>().ToList();
      // }
    }

    public void Seeding()
    {
      // var pizzas = new List<APizza>
      // {
      //   new HalalPizza(),
      //   new MeatPizza(),
      //   new VeganPizza(),
      //   new VeggiePizza(),
      // };


      var fs = new FileStorage();

    //  fs.WriteToXml<AStore>(stores, 1);
    //  fs.WriteToXml<APizza>(pizzas, 2);

      Stores = fs.ReadFromXml<AStore>(1).ToList();
      aPizzas = fs.ReadFromXml<APizza>(2).ToList(); 
    }

  public void saveOrder(List<Order> orders) {
  var fs = new FileStorage();
  fs.WriteToXml<Order>(orders, 3); 
  }

  }
}
