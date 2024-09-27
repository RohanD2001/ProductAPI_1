namespace ProductAPI.Models.Contact
{
    public class ContactModel
    {
 
        public string AccountId { get; set; }
        public int PartyId { get; set; }
        public string ContactId { get; set; }
        public string ExternalId { get; set; }
        public string RecordTypeId { get; set; }
        public string B2BUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Mobile { get; set; }
        public string Salutation { get; set; }
        public int PreferredLanguage { get; set; }
        public string Status { get; set; }
        public string EndMarketISO { get; set; }
        public string MailingState { get; set; }
        public string MailingStreet { get; set; }
        public string MailingCity { get; set; }
        public string MailingCountry { get; set; }
        public string MailingPostalCode { get; set; }
        public string Role { get; set; }
        public string PortalUserStatus { get; set; }
        public string B2BPortalUserStatus { get; set; }
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
