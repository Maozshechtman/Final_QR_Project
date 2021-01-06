using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Product
    {
        public int Id { get; set; }
        public int Porductid { get; set; }
        [Required]
        public string Name { get; set; }
        public int AllAmount { get; set; }
        public double Price { get; set; }
        public int AvgRate { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
