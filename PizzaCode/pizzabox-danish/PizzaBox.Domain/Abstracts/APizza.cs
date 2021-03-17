using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>
  /// 
  [XmlInclude(typeof(CustomPizza))]
  [XmlInclude(typeof(VeganPizza))]
  [XmlInclude(typeof(MeatPizza))]
  [XmlInclude(typeof(VeggiePizza))]
  [XmlInclude(typeof(HalalPizza))]

  public abstract class APizza
  {
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public APizza()
    {
      FactoryMethod();
    }

    /// <summary>
    /// 
    /// </summary>
    private void FactoryMethod()
    {
      AddCrust();
      AddSize();
      AddToppings();
    }

    protected abstract void AddCrust();
    protected abstract void AddSize();
    protected abstract void AddToppings();
  }
}
