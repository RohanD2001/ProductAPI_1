using ProductAPI.Models;

namespace ProductAPI.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task AddProduct(Product product);
        Task DeleteProduct(int id);
    }
}
