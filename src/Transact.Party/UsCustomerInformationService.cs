//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

using Shared.Models;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"

namespace Transact.Party.UsCustomerInformations
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IUsCustomerInformationService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve customer information service required for infinity integration</summary>
        /// <param name="customerId">Identifier of the customer</param>
        /// <param name="customerName">Name of the customer</param>
        /// <param name="addressLine1">Indicates first line of the address of the BIC</param>
        /// <param name="addressCity">The town and/or city component of the base address of a customer</param>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="zipCode">Zip code</param>
        /// <param name="dateOfBirth">The date of birth of an individual customer</param>
        /// <param name="lastName">The last name of an individual customer</param>
        /// <param name="phoneNumber">The phone number of the customer or prospect</param>
        /// <param name="firstName">Specifies customer's first name</param>
        /// <param name="email">Email Identifier of the Customer</param>
        /// <param name="mobilePhoneNumber">Represents the phone number of a customer</param>
        /// <param name="taxId">Holds the Customer's TAX/SSN Id.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <returns>UsCustomerInformationResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<UsCustomerInformationResponse> GetUsCustomerInformationAsync(string? customerId = null, string? customerName = null, string? addressLine1 = null, string? addressCity = null, string? countryId = null, string? zipCode = null, string? dateOfBirth = null, string? lastName = null, string? phoneNumber = null, string? firstName = null, string? email = null, string? mobilePhoneNumber = null, string? taxId = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class QueryHeader 
    {
        [System.Text.Json.Serialization.JsonPropertyName("audit")]
        public Audit? Audit { get; set; }= default!;
    
        /// <summary>Status of the API(success/failed)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }= default!;
    
        /// <summary>The total number of records per page</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? Page_size { get; set; }= default!;
    
        /// <summary>The record from which the response should be displayed</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_start")]
        public int? Page_start { get; set; }= default!;
    
        /// <summary>The total number of records present</summary>
        [System.Text.Json.Serialization.JsonPropertyName("total_size")]
        public int? Total_size { get; set; }= default!;
    
        /// <summary>Unique id expected to get as part of response from t24 on every enquiry request</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public string? Page_token { get; set; }= default!;
    
    
    }
    
    /// <summary>UsCustomerInformationResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class UsCustomerInformationResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public UsCustomerInformationResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class UsCustomerInformationResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
    {
    
    }
    
    /// <summary>BusinessQueryErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BusinessQueryErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public BusinessQueryErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BusinessQueryErrorResponseBody 
    {
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message for bad requests</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type: Business</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>SystemQueryErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SystemQueryErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public SystemQueryErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SystemQueryErrorResponseBody 
    {
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message caused by server</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type: System</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous 
    {
        [System.Text.Json.Serialization.JsonPropertyName("communicationDevices")]
        public System.Collections.Generic.ICollection<CommunicationDevices>? CommunicationDevices { get; set; }= default!;
    
        /// <summary>Additional address information, e.g. Contact Person. Building, Floor, Apartment, Street Number, Street Name, Town, Area, Code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressDetails")]
        public System.Collections.Generic.ICollection<AddressDetails>? AddressDetails { get; set; }= default!;
    
        /// <summary>Indicates second line of the address of the BIC</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressLine2")]
        public System.Collections.Generic.ICollection<AddressLine2>? AddressLine2 { get; set; }= default!;
    
        /// <summary>The town and/or city component of the base address of a customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressCities")]
        public System.Collections.Generic.ICollection<AddressCities>? AddressCities { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("stateIds")]
        public System.Collections.Generic.ICollection<StateIds>? StateIds { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("counties")]
        public System.Collections.Generic.ICollection<Counties>? Counties { get; set; }= default!;
    
        /// <summary>Identifies the address postal code for the customer.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("postCodes")]
        public System.Collections.Generic.ICollection<PostCodes>? PostCodes { get; set; }= default!;
    
        /// <summary>Zip plus 4</summary>
        [System.Text.Json.Serialization.JsonPropertyName("zipPlusFours")]
        public System.Collections.Generic.ICollection<ZipPlusFours>? ZipPlusFours { get; set; }= default!;
    
        /// <summary>Identifies the country of the customer.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("countries")]
        public System.Collections.Generic.ICollection<Countries>? Countries { get; set; }= default!;
    
        /// <summary>Identifies the nature of the postal address, like primary, secondary or office address</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressLocations")]
        public System.Collections.Generic.ICollection<AddressLocations>? AddressLocations { get; set; }= default!;
    
        /// <summary>Captures how the address can be used for tax purposes. Allowed values can be retrieved through getEbLookups for virtualTableName IRS.ADDRESS.TYPE</summary>
        [System.Text.Json.Serialization.JsonPropertyName("taxAddressTypes")]
        public System.Collections.Generic.ICollection<TaxAddressTypes>? TaxAddressTypes { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("legalDocuments")]
        public System.Collections.Generic.ICollection<LegalDocuments>? LegalDocuments { get; set; }= default!;
    
        /// <summary>Other Nationality of the Customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("otherNationalityIds")]
        public System.Collections.Generic.ICollection<OtherNationalityIds>? OtherNationalityIds { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("contactTypes")]
        public System.Collections.Generic.ICollection<ContactTypes>? ContactTypes { get; set; }= default!;
    
        /// <summary>Preferred method of contact to the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("preferredChannels")]
        public System.Collections.Generic.ICollection<PreferredChannels>? PreferredChannels { get; set; }= default!;
    
        /// <summary>The office phone number of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("officePhoneNumbers")]
        public System.Collections.Generic.ICollection<OfficePhoneNumbers>? OfficePhoneNumbers { get; set; }= default!;
    
        /// <summary>Identifier of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerId")]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? CustomerId { get; set; }= default!;
    
        /// <summary>Name of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? CustomerName { get; set; }= default!;
    
        /// <summary>The fax (facsimile) number of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("faxId")]
        [System.ComponentModel.DataAnnotations.StringLength(17)]
        public string? FaxId { get; set; }= default!;
    
        /// <summary>The internal bank status of a customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerStatus")]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string? CustomerStatus { get; set; }= default!;
    
        /// <summary>An institution-defined high level description or segmentation of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("statusName")]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string? StatusName { get; set; }= default!;
    
        /// <summary>The identifier of the nationality of a customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("nationalityId")]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string? NationalityId { get; set; }= default!;
    
        /// <summary>Indicates the name of the nationality of the beneficiary</summary>
        [System.Text.Json.Serialization.JsonPropertyName("nationalityName")]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string? NationalityName { get; set; }= default!;
    
        /// <summary>The identifier of the country of residence of a customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("residenceId")]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string? ResidenceId { get; set; }= default!;
    
        /// <summary>The identifier of the department head or specific account officer responsible for the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountOfficerId")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 4D)]
        public double? AccountOfficerId { get; set; }= default!;
    
        /// <summary>NAICS Code linked to the occupation or type of business of the Customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("naicsCode")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 6D)]
        public double? NaicsCode { get; set; }= default!;
    
        /// <summary>An institution-defined identifier of the type of customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("sectorId")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 4D)]
        public double? SectorId { get; set; }= default!;
    
        /// <summary>The last name of an individual customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("lastName")]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string? LastName { get; set; }= default!;
    
        /// <summary>Name of the Account/Relationship Officer attached to the Customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountOfficerName")]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string? AccountOfficerName { get; set; }= default!;
    
        /// <summary>Main menu title or header which the user wants to display on the screen when requesting the display of this main menu. This field can be expanded to allow the user to enter the description of the main menu in various languages.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string? Title { get; set; }= default!;
    
        /// <summary>Gender of the Individual Customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("gender")]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? Gender { get; set; }= default!;
    
        /// <summary>An institution-defined identifier of the type of customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("sectorName")]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string? SectorName { get; set; }= default!;
    
        /// <summary>Describes the target in an abbreviated form which can be used for reporting when space is limited.This can be expanded to allow the User to enter a short description of the Target code in various languages. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("targetName")]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string? TargetName { get; set; }= default!;
    
        /// <summary>Marital status of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maritalstatus")]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string? Maritalstatus { get; set; }= default!;
    
        /// <summary>Industry associated with the Customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("industryName")]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string? IndustryName { get; set; }= default!;
    
        /// <summary>Name of the residence country.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("residenceName")]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string? ResidenceName { get; set; }= default!;
    
        /// <summary>The death date of customer.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dateOfDeath")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? DateOfDeath { get; set; }= default!;
    
        /// <summary>The date on which the bank gets the notification that the customer is dead.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("notificationDateOfDeath")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? NotificationDateOfDeath { get; set; }= default!;
    
        /// <summary>The identifier of the underlying Entity/Company/Branch.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("companyId")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? CompanyId { get; set; }= default!;
    
        /// <summary>Indicates the customer consolidation number for credit grouping purposes, within the same branch/country.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerLiability")]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? CustomerLiability { get; set; }= default!;
    
        /// <summary>Specifies customer's first name</summary>
        [System.Text.Json.Serialization.JsonPropertyName("firstName")]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string? FirstName { get; set; }= default!;
    
        /// <summary>The language that the contents of the field are displayed in.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("language")]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string? Language { get; set; }= default!;
    
        /// <summary>Date on which the entity is incorporated</summary>
        [System.Text.Json.Serialization.JsonPropertyName("birthIncorpDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? BirthIncorpDate { get; set; }= default!;
    
        /// <summary>Specifies how the Customer is considered by the bank and how he fits in with the Account Officer's overall marketing strategy</summary>
        [System.Text.Json.Serialization.JsonPropertyName("target")]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string? Target { get; set; }= default!;
    
        /// <summary>Holds the Customer's TAX/SSN Id.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("taxId")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 35D)]
        public double? TaxId { get; set; }= default!;
    
        /// <summary>Attribute value linked to the attribute name. It holds the expected value for the defined attribute name. For a stop transaction the value is the check number, change range, amount or amount range.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerType")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? CustomerType { get; set; }= default!;
    
        /// <summary>The date of birth of an individual customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dateOfBirth")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? DateOfBirth { get; set; }= default!;
    
        /// <summary>Current number of the record</summary>
        [System.Text.Json.Serialization.JsonPropertyName("versionNumber")]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string? VersionNumber { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Audit2 
    {
        /// <summary>Time taken to response by T24</summary>
        [System.Text.Json.Serialization.JsonPropertyName("T24_time")]
        public int? T24_time { get; set; }= default!;
    
        /// <summary>The CURR.NO. of the record</summary>
        [System.Text.Json.Serialization.JsonPropertyName("versionNumber")]
        public string? VersionNumber { get; set; }= default!;
    
        /// <summary>Time taken to parse the request by IRIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("requestParse_time")]
        public double? RequestParse_time { get; set; }= default!;
    
        /// <summary>Time taken to parse the response by IRIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("responseParse_time")]
        public double? ResponseParse_time { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CommunicationDevices 
    {
        /// <summary>The phone number of the customer or prospect</summary>
        [System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        [System.ComponentModel.DataAnnotations.StringLength(17)]
        public string? PhoneNumber { get; set; }= default!;
    
        /// <summary>Represents the phone number of a customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("mobilePhoneNumber")]
        public string? MobilePhoneNumber { get; set; }= default!;
    
        /// <summary>Contains the email identifier of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("emailId")]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string? EmailId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AddressDetails 
    {
        /// <summary>Indicates first line of the address of the BIC</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressLine1")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? AddressLine1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AddressLine2 
    {
        /// <summary>Indicates second line of the address of the BIC</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressLine2")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? AddressLine21 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AddressCities 
    {
        /// <summary>The town and/or city component of the base address of a customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressCity")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? AddressCity { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class StateIds 
    {
        /// <summary>Represents the US State to which the address belongs to.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("stateId")]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string? StateId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Counties 
    {
        [System.Text.Json.Serialization.JsonPropertyName("county")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? County { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostCodes 
    {
        /// <summary>Zip code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("zipCode")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? ZipCode { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ZipPlusFours 
    {
        /// <summary>Zip plus 4</summary>
        [System.Text.Json.Serialization.JsonPropertyName("zipPlusFour")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 4D)]
        public double? ZipPlusFour { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Countries 
    {
        /// <summary>Identifies the country of the customer.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("country")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? Country { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AddressLocations 
    {
        /// <summary>Identifies the nature of the postal address, like primary, secondary or office address</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressLocation")]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? AddressLocation { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TaxAddressTypes 
    {
        /// <summary>Captures how the address can be used for tax purposes. Allowed values can be retrieved through getEbLookups for virtualTableName IRS.ADDRESS.TYPE</summary>
        [System.Text.Json.Serialization.JsonPropertyName("taxAddressType")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? TaxAddressType { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class LegalDocuments 
    {
        /// <summary>Unique reference number of the legal documents submitted as identification proof</summary>
        [System.Text.Json.Serialization.JsonPropertyName("legalId")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? LegalId { get; set; }= default!;
    
        /// <summary>Name of the legal documents such as passport, driving licence etc., provided as identification proof</summary>
        [System.Text.Json.Serialization.JsonPropertyName("legalDocumentName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? LegalDocumentName { get; set; }= default!;
    
        /// <summary>Name of the account holder in the Legal Document</summary>
        [System.Text.Json.Serialization.JsonPropertyName("legalHolderName")]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string? LegalHolderName { get; set; }= default!;
    
        /// <summary>Authority who issued the legal document</summary>
        [System.Text.Json.Serialization.JsonPropertyName("legalIssueAuthorisedDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? LegalIssueAuthorisedDate { get; set; }= default!;
    
        /// <summary>Date of Issue of the legal document</summary>
        [System.Text.Json.Serialization.JsonPropertyName("legalIssueDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? LegalIssueDate { get; set; }= default!;
    
        /// <summary>Expiry date of the legal document submitted as proof</summary>
        [System.Text.Json.Serialization.JsonPropertyName("legalExpiredDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? LegalExpiredDate { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class OtherNationalityIds 
    {
        /// <summary>Other Nationality of the Customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("otherNationalityId")]
        [System.ComponentModel.DataAnnotations.StringLength(9)]
        public string? OtherNationalityId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ContactTypes 
    {
        /// <summary>Types of contacts available to users to communicate</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contactType")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? ContactType { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PreferredChannels 
    {
        /// <summary>Preferred method of contact to the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("preferredChannel")]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string? PreferredChannel { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class OfficePhoneNumbers 
    {
        /// <summary>The office phone number of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("officePhoneNumber")]
        [System.ComponentModel.DataAnnotations.StringLength(17)]
        public string? OfficePhoneNumber { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    internal class DateFormatConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public DateFormatConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016