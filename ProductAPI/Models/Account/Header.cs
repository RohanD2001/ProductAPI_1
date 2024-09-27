namespace ProductAPI.Models.Account
{
    public class Header
    {
        public DateTime Timestamp { get; set; }
        public string TransactionType { get; set; }
        public string Source { get; set; }
    }
}
