using TrainingDbApp.Data;
using TrainingDbApp.Models;

namespace TrainingDbApp.Repositories
{
    public class ProductRepository
    {

        private readonly AppDbContext _context = new AppDbContext() ;

        public void Add(Product product)
        {
            _context.Products.Add(product);
               _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }
        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void Delete(int id) {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
