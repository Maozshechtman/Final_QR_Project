
using System.ComponentModel;
using System.Windows;
using Final_QR_Project.Models;
using BE;
using System.Collections.ObjectModel;

namespace Final_QR_Project.ViewModels
{
    public class ProductsVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Product> Products { get; set; }

        public ProductsVM()
        {
            Products = new ObservableCollection<Product>()
            {
                new Product {Id=1,AllAmount=100},
                 new Product {Id=2,AllAmount=50},
                  new Product {Id=3,AllAmount=90}
                  , new Product {Id=4,AllAmount=25}
            };
        }
    }
}
