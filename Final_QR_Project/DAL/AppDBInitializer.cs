using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using BE;
namespace DAL
{
   public  class AppDBInitializer: DropCreateDatabaseAlways<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            IList<Product> products = new List<Product>(); ;
            products.Add(new Product { Porductid = 111, Name = "בורקס תרד שלושת האופים",AllAmount=0 });
            products.Add(new Product { Porductid = 121, Name = "בורקס גבינה שלושת האופים", AllAmount = 0 });
            products.Add(new Product { Porductid = 131, Name = "בורקס גבינה שלושת האופים", AllAmount = 0 });

            context.Products.AddRange(products);
            base.Seed(context);
            

        }
    }
}
