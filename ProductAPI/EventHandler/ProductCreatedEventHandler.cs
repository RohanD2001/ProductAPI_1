namespace ProductAPI.EventHandler
{
    public class ProductCreatedEventHandler
    {
        public void Handle(ProductCreatedEvent productCreatedEvent)
        {
            
            Console.WriteLine($"Product created: {productCreatedEvent.Product.Name}");
        }
    }

}
