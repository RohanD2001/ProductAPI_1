using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductAPI.Models.Account
{
    [ComplexType] // Indicate that this class is a complex type
    public class Header
    {
        public DateTime Timestamp { get; set; }
        public string TransactionType { get; set; }

        [Key]
        public string Source { get; set; }
    }

    [ComplexType] // Indicate that this class is a complex type
    public class ParentAccount
    {
        [Key]
        public string Name { get; set; }

        public string Type { get; set; }

        public string Id { get; set; }

        public string Email { get; set; }
    }

    public class AccountModel
    {
        public Header Header { get; set; }
        public ParentAccount ParentAccount { get; set; }

        [Key]
        public string AccountId { get; set; }

        public string ContactId { get; set; }
        public string ContactBackofficeId { get; set; }
        public string ExternalId { get; set; }
        public string LegacyCustomerId { get; set; }
        public string MigrationExternalId { get; set; }
        public string OpenLoyaltyAccountId { get; set; }
        public string PartyId { get; set; }
        public string RecordTypeId { get; set; }
        public string SAPCustomerId { get; set; }
        public string CommercialName { get; set; }
        public string AccountType { get; set; }

        // Address properties
        public string AddressAddressLine1 { get; set; }
        public string AddressAddressLine2 { get; set; }
        public string AddressCity { get; set; }
        public string AddressPostCode { get; set; }
        public string District { get; set; }
        public string AddressState { get; set; }

        // Billing properties
        public string BaseFrequency { get; set; }
        public string BillingCity { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        public string BillingStreet { get; set; }

        public string ContactEmail { get; set; }
        public string ContentTarget { get; set; }
        public string CountryISOCode { get; set; }
        public string CustomerClassification { get; set; }
        public string CustomerCode { get; set; }
        public string Email { get; set; }

        // Nullable properties
        public bool? EnableIndirectOnlineOrder { get; set; }
        public string Frequency { get; set; }
        public string GeographicEnvironment { get; set; }
        public bool? IsB2BCustomer { get; set; }
        public string IsBlockedToSales { get; set; }
        public string IvyBaseStatus { get; set; }
        public string LegalName { get; set; }
        public string MarketISO { get; set; }
        public string Name { get; set; }
        public string OutletType { get; set; }
        public string OwnershipType { get; set; }
        public string OwnerType { get; set; }
        public string ParentAccountName { get; set; }
        public string ParentName { get; set; }
        public string PricingGroup { get; set; }
        public string PricingGroup1 { get; set; }
        public string PricingGroup2 { get; set; }
        public string PricingGroup3 { get; set; }
        public string PrimaryContact { get; set; }
        public string SendIOToSAP { get; set; }
        public string ShopperChannel { get; set; }
        public string Status { get; set; }
        public string SubType { get; set; }
        public string Telephone { get; set; }

        // Nullable integer
        public int? UserQuota { get; set; }
        public string VatRegistrationNumber { get; set; }
    }
}
