
using System.Runtime.CompilerServices;
using TrainingDbApp.Data;
using TrainingDbApp.Models;

namespace TrainingDbApp.Repositories
{
   public class CategoryRepository
    {

        private readonly AppDbContext _context = new AppDbContext();
        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();

        }


        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {

                _context.Categories.Remove(category);
                _context.SaveChanges();

            }
        }
    }
}
