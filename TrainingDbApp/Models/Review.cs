using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingDbApp.Models
{
    public class Review
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string Text { get; set; }
        public int Rating { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public DateTime CreatedAt { get; set; }


    }
}
