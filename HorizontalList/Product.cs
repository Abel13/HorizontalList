using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorizontalList
{
  public class Product
  {
    public string Name { get; set; }
    public double Value { get; set; }
    public string Image { get; set; }

    public Product(string name, double value, string image)
    {
      Name = name;
      Value = value;
      Image = image;
    }
  }
}
