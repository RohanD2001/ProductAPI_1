namespace ProductAPI.Models.Contact
{
    public class Header
    {
        public DateTime Timestamp { get; set; }
        public string TransactionType { get; set; } // size = 50 
        public string Source { get; set; } // size = 100 } 
    }
}
