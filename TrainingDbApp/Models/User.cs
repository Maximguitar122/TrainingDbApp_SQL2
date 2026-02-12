using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingDbApp.Models
{
   public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Order> Orders { get; set; } = new();
        public List<Review> Reviews { get; set; } = new();
    }
}
