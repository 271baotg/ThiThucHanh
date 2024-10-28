using THUCHANH.Models;

namespace THUCHANH.Repository
{
    public interface IProductRepository
    {
        public ICollection<Product> getById(int id);
        public ICollection<Product> getAll();

        public bool updateProduct(Product product);
        public bool createProduct(Product product);

        public bool isExist(long id);
        public bool Save();
    }
}
