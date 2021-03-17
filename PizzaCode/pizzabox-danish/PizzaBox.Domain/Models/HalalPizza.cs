using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class HalalPizza : APizza
  {
    protected override void AddCrust()
    {
      Crust = new Crust();
    }

    protected override void AddSize()
    {
      Size = new Size();
    }

    protected override void AddToppings()
    {
      Toppings = new List<Topping>
      {
        new Topping(),
        new Topping()
        {
            Name = "Halal Pepperoni",
            Price = 7, 
        },
        new Topping() 
        {
            Name = "Halal Chicken", 
            Price = 6,
        }
      };
    }
  }
}
