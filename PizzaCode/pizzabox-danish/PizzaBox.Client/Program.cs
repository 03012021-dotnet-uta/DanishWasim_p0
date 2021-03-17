using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;

namespace PizzaBox.Client
{
  /// <summary>
  /// 
  /// </summary>
  class Program
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      //PlayWithStore();
      AsACustomer();
    }

    /// <summary>
    /// 
    /// </summary>
    public static void PlayWithStore()
    {
      foreach (var store in StoreSingleton.Instance.Stores)
      {
        Console.WriteLine(store);
      }
    }


    public static void PizzaType() 
    {

    var input = Console.ReadLine();  
    }

    public static void AsACustomer()
    {
      var ss = StoreSingleton.Instance;
      
      ss.Seeding();

      var aP = ss.aPizzas;

      // print all the stores available, must be from file or db
      foreach (var item in ss.Stores)
      {
        System.Console.WriteLine(item);
      }

      // select a store
      var input = Console.ReadLine();
      AStore chosenStore = null; 
      
      switch (input)
      {
        case "1": 
          chosenStore = new ChicagoStore(); 
          break;

      }

      // Input your name as customer

      Customer CustomerOrder = new Customer(); 
      Console.WriteLine("Input uour name?");
      CustomerOrder.CustName = Console.ReadLine();

      // Show user every pizza in the pizza list loop
      foreach (var item in aP)
      {
          System.Console.WriteLine(item.GetType().ToString().Split(".")[3]);
      }

      // Let user input type of pizza they want
      var PizzaInput = Console.ReadLine();
      APizza pizza = null;

      switch (PizzaInput)
      {
        case "1":
           pizza = new VeggiePizza();
          break;
        case "2":
           pizza = new MeatPizza();
           break;
        case "3":
            pizza = new VeganPizza();
            break;
        case "4":
            pizza = new HalalPizza();
          break; 
          default:
           pizza = new VeggiePizza();  //change to cheese pizza after MVP uploaded on GIT 
          break; 
      }

      
      // Save order

      var order = new Order();
      order.Pizzas = new List<APizza>();
      order.customer = CustomerOrder; 
      order.store = chosenStore;

      order.Pizzas.Add(pizza);
      ss.saveOrder(new List<Order>(){order});


      // print the customer menu
      System.Console.WriteLine("1. Place Order");
      System.Console.WriteLine("2. View Order History");
      System.Console.WriteLine("3. Exit");

      // select a menu option
      var input2 = Console.ReadLine();

      switch (input2)
      {
        case "1":
           PizzaType();

          break;
        case "2":
          // run the code for view order history
          break;
      }
    }
  }
}
