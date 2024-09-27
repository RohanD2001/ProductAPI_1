using Polly;
using ProductAPI.Models;
using ProductAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;
using ProductAPI.EventHandler;
using ProductAPI;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    private readonly ProductCreatedEventHandler _eventHandler;
    private readonly IAsyncPolicy _retryPolicy;

    public ProductRepository(ApplicationDbContext context, ProductCreatedEventHandler eventHandler)
    {
        _context = context;
        _eventHandler = eventHandler;

        // Defining Polly
        _retryPolicy = Policy
            .Handle<DbUpdateException>()
            .Or<TimeoutException>()
            .Or<Exception>()
            .WaitAndRetryAsync(5, retryAttempt => TimeSpan.FromSeconds(2),
            onRetry: (exception, timeSpan, retryCount, context) =>
            {
                // You can log retry information here
                Console.WriteLine($"Retry {retryCount} due to {exception.Message}");
            });
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await _retryPolicy.ExecuteAsync(async () =>
        {
            return await _context.Products.ToListAsync();
        });
    }

    public async Task<Product> GetProductById(int id)
    {
        var product= await _retryPolicy.ExecuteAsync(async () =>
        {
            return await _context.Products.FindAsync(id);
        });

        if (product == null) {
            throw new Exception(message: $"Product with the Id : {id} does not exist");
        }
        else
        {
            return product;
        }
    }

    public async Task AddProduct(Product product)
    {
        await _retryPolicy.ExecuteAsync(async () =>
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        });

        // Raising the event
        _eventHandler.Handle(new ProductCreatedEvent(product));
    }

    public async Task DeleteProduct(int id)
    {
        await _retryPolicy.ExecuteAsync(async () =>
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Please Enter a valid Id");
            }
        });
    }
}