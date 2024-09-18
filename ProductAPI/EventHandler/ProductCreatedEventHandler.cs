namespace ProductAPI.EventHandler
{
    public class ProductCreatedEventHandler
    {
        public void Handle(ProductCreatedEvent productCreatedEvent)
        {
            // Handle the event (e.g., send a notification, log the event, etc.)
            Console.WriteLine($"Product created: {productCreatedEvent.Product.Name}");
        }
    }

}
