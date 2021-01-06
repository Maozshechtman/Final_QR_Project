using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class DbAdapter
    {
      public static string Main()
        {
            using (var ctx = new MyContext())
            {
                var product = new BE.Product() {Porductid=111 ,Name = "בטטה סגולה" ,Price=9.9};
                ctx.Products.Add(product);
                ctx.SaveChanges();
            }
            return "Test Completed";
           
        }
    }
}
