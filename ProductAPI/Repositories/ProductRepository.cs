using Microsoft.EntityFrameworkCore;
using ProductAPI;
using ProductAPI.Data;
using ProductAPI.EventHandler;
using ProductAPI.Models;
using ProductAPI.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    private readonly ProductCreatedEventHandler _eventHandler;

    public ProductRepository(ApplicationDbContext context, ProductCreatedEventHandler eventHandler)
    {
        _context = context;
        _eventHandler = eventHandler;
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> GetProductById(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task AddProduct(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();

        // event
        _eventHandler.Handle(new ProductCreatedEvent(product));
    }

    public async Task DeleteProduct(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
        else {
            throw new Exception(message: "Please Enter a valid Id");
        }
    }
}
