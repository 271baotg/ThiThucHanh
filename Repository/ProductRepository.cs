using Microsoft.EntityFrameworkCore;
using THUCHANH.DbAccess;
using THUCHANH.Models;

namespace THUCHANH.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _applicationContext;

        public ProductRepository(ApplicationContext dbContext)
        {
            _applicationContext = dbContext;
        }

        public bool createProduct(Product Product)
        {
            _applicationContext.Products.Add(Product);
            return Save();
        }
        public ICollection<Product> getAll()
        {
            return _applicationContext.Products.ToList();
        }
        public ICollection<Product> getById(int id)
        {
            return _applicationContext.Products.Where(p => p.Id == id).ToList();
        }



        public bool updateProduct(Product Product)
        {
            _applicationContext.Update(Product);
            return Save();
        }

        public bool Save()
        {
            var save = _applicationContext.SaveChanges();
            return save > 0 ? true : false;
        }

        public bool isExist(long id)
        {
            return _applicationContext.Products.Any(p => p.Id == id);
        }
    }
}
