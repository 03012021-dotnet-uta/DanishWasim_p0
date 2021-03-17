using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Order
  {
    public List<APizza> Pizzas { get; set; }
    public Customer customer {get; set; }
    public AStore store {get; set; } 
  }
}

