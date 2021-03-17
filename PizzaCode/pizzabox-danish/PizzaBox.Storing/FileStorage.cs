using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaBox.Storing
{
  public class FileStorage
  {
    private readonly string _path = @"store.xml";
    private readonly string _pizzapath = @"pizza.xml"; 
    private readonly string _order = @"order.xml"; 



      public string choosepath(int x) {
        
        switch (x)
        {
            case 1:
            return _path; 
            case 2: 
            return _pizzapath; 
            case 3: 
            return _order; 
        }
        return null;
      }
  
    public void WriteToXml<T>(List<T> data,int a) where T : class
    {
      string PathName = choosepath(a);

      using (var writer = new StreamWriter(PathName))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        serializer.Serialize(writer, data);
      }
    }

    public IEnumerable<T> ReadFromXml<T>(int x) where T : class
    {
      string PathName = choosepath(x); 

      using (var reader = new StreamReader(PathName))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        return serializer.Deserialize(reader) as IEnumerable<T>;
      }
    }
  }
}
