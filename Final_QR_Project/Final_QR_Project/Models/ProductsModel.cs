using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace Final_QR_Project.Models
{
   public class ProductsModel
    {
      public  List<Product> products { get; set; }

        public ProductsModel()
        {
            products = new List<Product>();
        }
    }
}
