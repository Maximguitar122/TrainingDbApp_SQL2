
using TrainingDbApp.Data;
using TrainingDbApp.Models;

namespace TrainingDbApp.Repositories
{
    public class Orderrepository
    {
        private readonly AppDbContext _context = new AppDbContext();
        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _context.Orders.ToList();

        }


        public Order  GetById(int id)
        {
            return _context.Orders.Find(id);
        }

        public  void Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void Delete(int id) {
            var order = _context.Orders.Find(id);
            if (order != null) {

                _context.Orders.Remove(order);
                _context.SaveChanges();
            
            }
        }
    }
}
