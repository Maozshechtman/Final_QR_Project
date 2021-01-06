using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace Final_QR_Project.ViewModels
{
    public class StatisticVM : INotifyPropertyChanged
    {
        public ObservableCollection<Product> Data {get;set;}
        public StatisticVM()
        {
            Data = new ObservableCollection<Product>()
            {
                new Product { Id = 1, Name = "Chips", AllAmount = 100, AvgRate = 3 }
                , new Product { Id = 2, Name = "Almond Milk", AllAmount = 14, AvgRate = 4 }
                 , new Product { Id = 3, Name = "Puff Pastry", AllAmount = 70, AvgRate = 4 }


            };
                
               
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
