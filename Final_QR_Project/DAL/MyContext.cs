using System;
using System.Data.Entity;

namespace DAL
{
    public class MyContext: System.Data.Entity.DbContext
    {
        public MyContext() : base("SmartBuyDB")
        {
           
        }
            
        public DbSet<BE.Product> Products { get; set;}
        public DbSet<BE.Scan> Scans { get; set; }
        public DbSet<BE.Store> Stores { get; set;}
        public DbSet<BE.User> Users { get; set; }
    }
    
}
