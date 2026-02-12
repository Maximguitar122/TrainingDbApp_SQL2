using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingDbApp.Models
{
    public class Product
    {
          public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price {  get; set; }
        public string Description { get; set; }
        public List<Review> Reviews { get; set; } = new();
        public List<Category> Categories { get; set; } = new();
        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
