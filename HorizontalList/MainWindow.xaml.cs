using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HorizontalList
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      var products = GetProducts();
      if (products.Count > 0)
        ListViewProducts.ItemsSource = products;
    }

    private List<Product> GetProducts()
    {
      return new List<Product>()
      {
        new Product("Product 1", 205.46, "/Assets/1.jpg"),
        new Product("Product 2", 102.50, "/Assets/2.jpg"),
        new Product("Product 3", 400.99, "/Assets/3.jpg"),
        new Product("Product 4", 350.26, "/Assets/4.jpg"),
        new Product("Product 5", 150.10, "/Assets/5.jpg"),
        new Product("Product 6", 100.02, "/Assets/6.jpg"),
        new Product("Product 7", 295.25, "/Assets/7.jpg"),
        new Product("Product 8", 700.00, "/Assets/8.jpg")
      };
    }
  }
}
