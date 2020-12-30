
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
    }
}
