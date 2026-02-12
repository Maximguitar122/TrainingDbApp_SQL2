using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingDbApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OrderId { get; set; }
        public User User { get; set; } = null!;
        public List<OrderItem> OrderItems { get; set; }
    }
}
