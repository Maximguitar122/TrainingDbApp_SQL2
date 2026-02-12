using TrainingDbApp.Data;
using TrainingDbApp.Models;

namespace TrainingDbApp.Repositories
{
    public class ReviewRepositories
    {

        private readonly  AppDbContext _context = new AppDbContext();
        public void Add(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
        }

        public List<Review> GetAll()
        {
            return _context.Reviews.ToList();

        }


        public Review GetById(int id)
        {
            return _context.Reviews.Find(id);
        }

        public void Update(Review review)
        {
            _context.Reviews.Update(review);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var review = _context.Reviews.Find(id);
            if (review != null)
            {

                _context.Reviews.Remove(review);
                _context.SaveChanges();

            }
        }
    }
}
