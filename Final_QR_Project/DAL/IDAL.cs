using System;
using System.Collections.Generic;
using System.Text;
using BE;
namespace DAL
{
    interface IDAL
    {
      void addProduct(BE.Product product)
      void addScan(BE.Scan scan);
        
    }
}
