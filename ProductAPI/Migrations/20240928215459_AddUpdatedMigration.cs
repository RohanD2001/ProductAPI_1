using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdatedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountData",
                columns: table => new
                {
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContactId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactBackofficeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExternalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegacyCustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MigrationExternalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenLoyaltyAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordTypeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SAPCustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommercialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressAddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressAddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressPostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseFrequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingStreet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentTarget = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryISOCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerClassification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnableIndirectOnlineOrder = table.Column<bool>(type: "bit", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeographicEnvironment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsB2BCustomer = table.Column<bool>(type: "bit", nullable: true),
                    IsBlockedToSales = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IvyBaseStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarketISO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutletType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnershipType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricingGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricingGroup1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricingGroup2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricingGroup3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SendIOToSAP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopperChannel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserQuota = table.Column<int>(type: "int", nullable: true),
                    VatRegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header_Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header_Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Header_TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentAccount_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentAccount_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentAccount_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentAccount_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountData", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "ContactData",
                columns: table => new
                {
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartyId = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExternalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordTypeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B2BUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salutation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredLanguage = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndMarketISO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailingState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailingStreet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailingCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailingCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailingPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortalUserStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B2BPortalUserStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    header_Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    header_Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    header_TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parentAccount_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parentAccount_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parentAccount_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parentAccount_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactData", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountData");

            migrationBuilder.DropTable(
                name: "ContactData");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
