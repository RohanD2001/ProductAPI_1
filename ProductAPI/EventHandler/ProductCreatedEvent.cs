using ProductAPI.Models;

namespace ProductAPI
{
    public class ProductCreatedEvent
    {
        public Product Product { get; }

        public ProductCreatedEvent(Product product)
        {
            Product = product;
        }
    }

}
