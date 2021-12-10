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

namespace Transact.Reference.BICs
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IBICsService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the status on the validity of the requested BIC along with its details</summary>
        /// <param name="bicId">Bank Identifier Code (BIC) of the Beneficiary bank.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>BICStatusResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BICStatusResponse> GetBICStatusAsync(string bicId, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the status on the validity of the BIC code</summary>
        /// <param name="bicId">Bank Identifier Code (BIC) of the Beneficiary bank.</param>
        /// <param name="effectiveDate">The date on which the principal movement is effected</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>BICResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BICResponse> ValidateBICAsync(string bicId, string? effectiveDate = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the Bank's legal entity identifier of the requested BIC</summary>
        /// <param name="bicId">Bank Identifier Code (BIC) of the Beneficiary bank.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>LEIFromBICResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<LEIFromBICResponse> GetLEIFromBICAsync(string bicId, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the matching bank identification codes for the specified search criterions</summary>
        /// <param name="countryCode">ISO 3166-1-alpha-2 or alpha-3 country code of financial institution</param>
        /// <param name="bicId">Bank Identifier Code (BIC) of the Beneficiary bank.</param>
        /// <param name="institutionName">Indicates the name of the institution</param>
        /// <param name="city">City of residence of customer or the City in which the bank/financial institution is located. For Example LONDON, NEW YORK</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>BICIdentifierResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BICIdentifierResponse> GetBICIdentifierAsync(string countryCode, string? bicId = null, string? institutionName = null, string? city = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    
    /// <summary>BICStatusResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BICStatusResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public BICStatusResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BICStatusResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
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
    
    /// <summary>BICResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BICResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public BICResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BICResponseBody : System.Collections.ObjectModel.Collection<Anonymous2>
    {
    
    }
    
    /// <summary>LEIFromBICResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class LEIFromBICResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public LEIFromBICResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class LEIFromBICResponseBody : System.Collections.ObjectModel.Collection<Anonymous3>
    {
    
    }
    
    /// <summary>BICIdentifierResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BICIdentifierResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public BICIdentifierResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BICIdentifierResponseBody : System.Collections.ObjectModel.Collection<Anonymous4>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous 
    {
        [System.Text.Json.Serialization.JsonPropertyName("addressInformation")]
        public System.Collections.Generic.ICollection<AddressInformation>? AddressInformation { get; set; }= default!;
    
        /// <summary>Indicates the Value added services that the financial institution has subscribed to</summary>
        [System.Text.Json.Serialization.JsonPropertyName("serviceCodes")]
        public System.Collections.Generic.ICollection<ServiceCodes>? ServiceCodes { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("entityInformation")]
        public System.Collections.Generic.ICollection<EntityInformation>? EntityInformation { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("excludedCompanies")]
        public System.Collections.Generic.ICollection<ExcludedCompanies>? ExcludedCompanies { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("allowedCompanies")]
        public System.Collections.Generic.ICollection<AllowedCompanies>? AllowedCompanies { get; set; }= default!;
    
        /// <summary>Bank Identifier Code (BIC) of the Beneficiary bank.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bicId")]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string? BicId { get; set; }= default!;
    
        /// <summary>Indicates whether the BIC is valid</summary>
        [System.Text.Json.Serialization.JsonPropertyName("isBICValid")]
        public string? IsBICValid { get; set; }= default!;
    
        /// <summary>Indicates the name of the institution</summary>
        [System.Text.Json.Serialization.JsonPropertyName("institutionName")]
        public string? InstitutionName { get; set; }= default!;
    
        /// <summary>The branch information relevant to this BIC code.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }= default!;
    
        /// <summary>Indicates the branch Code associated to the BIC Code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bicbranchCode")]
        public string? BicbranchCode { get; set; }= default!;
    
        /// <summary>Indicates the routing or processing BIC to which Euro payment must be sent</summary>
        [System.Text.Json.Serialization.JsonPropertyName("routingBiccode")]
        public string? RoutingBiccode { get; set; }= default!;
    
        /// <summary>ISO country code of the financial institution. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryId")]
        public string? CountryId { get; set; }= default!;
    
        /// <summary>Indicates the ISO Country code of the financial institution</summary>
        [System.Text.Json.Serialization.JsonPropertyName("nationalId")]
        public string? NationalId { get; set; }= default!;
    
        /// <summary>Indicates the national bank code of the financial institution</summary>
        [System.Text.Json.Serialization.JsonPropertyName("nationalIdtype")]
        public string? NationalIdtype { get; set; }= default!;
    
        /// <summary>Indicates the Clearing House Interbank Payments System Universal Identifier (CHIPS) of the institution</summary>
        [System.Text.Json.Serialization.JsonPropertyName("chipsuid")]
        public string? Chipsuid { get; set; }= default!;
    
        /// <summary>Indicates the type of financial institution</summary>
        [System.Text.Json.Serialization.JsonPropertyName("subtypeInd")]
        public string? SubtypeInd { get; set; }= default!;
    
        /// <summary>Indicates the branch qualifiers of the Bank Identifier Code (BIC). Branch Qualifiers are the operational type of the entity. Eg: ADM-Administration, BKO for Back Office</summary>
        [System.Text.Json.Serialization.JsonPropertyName("branchQualifier")]
        public string? BranchQualifier { get; set; }= default!;
    
        /// <summary>Indicates the date from which the data set becomes effective due to a change of its attributes e.g. BIC activates/deactivates in future</summary>
        [System.Text.Json.Serialization.JsonPropertyName("validFrom")]
        public string? ValidFrom { get; set; }= default!;
    
        /// <summary>Legal entity identifier for the bank.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bankLegalEntityIdentifier")]
        public string? BankLegalEntityIdentifier { get; set; }= default!;
    
        /// <summary>Defines the timezone of the entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("timeZone")]
        public string? TimeZone { get; set; }= default!;
    
        /// <summary>Indicates the status of the entity being connected to SWIFT</summary>
        [System.Text.Json.Serialization.JsonPropertyName("networkConnection")]
        public string? NetworkConnection { get; set; }= default!;
    
        /// <summary>Indicates the status of the BIC</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bicStatus")]
        public string? BicStatus { get; set; }= default!;
    
    
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
    public partial class Anonymous2 
    {
        /// <summary>Indicates whether the BIC is valid</summary>
        [System.Text.Json.Serialization.JsonPropertyName("isBICValid")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? IsBICValid { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous3 
    {
        /// <summary>Legal entity identifier for the bank.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bankLegalEntityIdentifier")]
        public string? BankLegalEntityIdentifier { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous4 
    {
        /// <summary>Indicates the name of the institution</summary>
        [System.Text.Json.Serialization.JsonPropertyName("institutionNames")]
        public System.Collections.Generic.ICollection<InstitutionNames>? InstitutionNames { get; set; }= default!;
    
        /// <summary>This is the country name that the financial institution resides in.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryNames")]
        public System.Collections.Generic.ICollection<CountryNames>? CountryNames { get; set; }= default!;
    
        /// <summary>ISO 3166-1-alpha-2 or alpha-3 country code of financial institution</summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string? CountryCode { get; set; }= default!;
    
        /// <summary>Bank Identifier Code (BIC) of the Beneficiary bank.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bicId")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? BicId { get; set; }= default!;
    
        /// <summary>City of residence of customer or the City in which the bank/financial institution is located. For Example LONDON, NEW YORK</summary>
        [System.Text.Json.Serialization.JsonPropertyName("city")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? City { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AddressInformation 
    {
        /// <summary>The town and/or city component of the base address of a customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressCity")]
        public string? AddressCity { get; set; }= default!;
    
        /// <summary>Indicates first line of the address of the BIC</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressLine1")]
        public string? AddressLine1 { get; set; }= default!;
    
        /// <summary>Indicates second line of the address of the BIC</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressLine2")]
        public string? AddressLine2 { get; set; }= default!;
    
        /// <summary>Indicates third line of the address of the BIC</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressLine3")]
        public string? AddressLine3 { get; set; }= default!;
    
        /// <summary>Indicates fourth line of the address of the BIC</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addressLine4")]
        public string? AddressLine4 { get; set; }= default!;
    
        /// <summary>Identifies the address postal code for the customer.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("postCode")]
        public string? PostCode { get; set; }= default!;
    
        /// <summary>Indicates first line of branch location of the financial institution</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bicLocation1")]
        public string? BicLocation1 { get; set; }= default!;
    
        /// <summary>Indicates second line of branch location of the financial institution</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bicLocation2")]
        public string? BicLocation2 { get; set; }= default!;
    
        /// <summary>This is the country name that the financial institution resides in.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryName")]
        public string? CountryName { get; set; }= default!;
    
        /// <summary>Post Office Box (POB) number that relates to financial institution</summary>
        [System.Text.Json.Serialization.JsonPropertyName("postBoxNumber")]
        public string? PostBoxNumber { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ServiceCodes 
    {
        /// <summary>Indicates the Value added services that the financial institution has subscribed to</summary>
        [System.Text.Json.Serialization.JsonPropertyName("serviceCode")]
        public string? ServiceCode { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class EntityInformation 
    {
        /// <summary>Indicates the status of the entity in the office hierarchy e.g. Head Office, Main Payments Office</summary>
        [System.Text.Json.Serialization.JsonPropertyName("officeType")]
        public string? OfficeType { get; set; }= default!;
    
        /// <summary>Indicates the status of the entity in the legal hierarchy eg. L - Legal Entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("legalType")]
        public string? LegalType { get; set; }= default!;
    
        /// <summary>Indicates the type of entity that identifies the group eg. Parent or Member</summary>
        [System.Text.Json.Serialization.JsonPropertyName("groupType")]
        public string? GroupType { get; set; }= default!;
    
        /// <summary>Indicates the status of the institution like Bank, Money Exchange, Payment institution etc.,</summary>
        [System.Text.Json.Serialization.JsonPropertyName("institutionStatus")]
        public string? InstitutionStatus { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ExcludedCompanies 
    {
        /// <summary>Indicates the companies where Central Directory record is excluded to use</summary>
        [System.Text.Json.Serialization.JsonPropertyName("excludedCompany")]
        public string? ExcludedCompany { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AllowedCompanies 
    {
        /// <summary>Indicates the companies where Central Directory record is allowed to use</summary>
        [System.Text.Json.Serialization.JsonPropertyName("allowedCompany")]
        public string? AllowedCompany { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class InstitutionNames 
    {
        /// <summary>Indicates the name of the institution</summary>
        [System.Text.Json.Serialization.JsonPropertyName("institutionName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? InstitutionName { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CountryNames 
    {
        /// <summary>This is the country name that the financial institution resides in.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? CountryName { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016