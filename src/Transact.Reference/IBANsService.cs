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

namespace Transact.Reference.IBANs
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IIBANsService
    {
        /// <summary>Retrieves the BIC code for the requested IBAN</summary>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>BICfromIBANResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BICfromIBANResponse> GetBICfromIBANAsync(string ibanId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the BIC code for the requested IBAN</summary>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>BICfromIBANResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BICfromIBANResponse> GetBICfromIBANAsync(string ibanId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieves the components of the requested IBAN</summary>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>IBANDetailsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<IBANDetailsResponse> GetIBANDetailsAsync(string ibanId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the components of the requested IBAN</summary>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>IBANDetailsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<IBANDetailsResponse> GetIBANDetailsAsync(string ibanId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieves IBAN from a BBAN</summary>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>IBANFromBBANResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<IBANFromBBANResponse> GetIBANFromBBANAsync(string bbanId, string countryId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves IBAN from a BBAN</summary>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>IBANFromBBANResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<IBANFromBBANResponse> GetIBANFromBBANAsync(string bbanId, string countryId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieves the generated IBAN number</summary>
        /// <param name="accountId">Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</param>
        /// <param name="bankId">Contains the identifier of the bank with which the transaction is performed</param>
        /// <param name="branchId">Unique and unambiguous identification of a branch of a financial institution.</param>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>IBANNumberGeneratedResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<IBANNumberGeneratedResponse> GetIBANNumberGeneratedAsync(string accountId, string bankId, string? branchId, string countryId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the generated IBAN number</summary>
        /// <param name="accountId">Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</param>
        /// <param name="bankId">Contains the identifier of the bank with which the transaction is performed</param>
        /// <param name="branchId">Unique and unambiguous identification of a branch of a financial institution.</param>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>IBANNumberGeneratedResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<IBANNumberGeneratedResponse> GetIBANNumberGeneratedAsync(string accountId, string bankId, string? branchId, string countryId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieves the structure of an IBAN number</summary>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>IBANStructureResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<IBANStructureResponse> GetIBANStructureAsync(string countryId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the structure of an IBAN number</summary>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>IBANStructureResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<IBANStructureResponse> GetIBANStructureAsync(string countryId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieves the status on the validity of the given IBAN number</summary>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>IBANResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<IBANResponse> ValidateIBANAsync(string ibanId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the status on the validity of the given IBAN number</summary>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>IBANResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<IBANResponse> ValidateIBANAsync(string ibanId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, System.Threading.CancellationToken cancellationToken);
    
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
    
    /// <summary>BICfromIBANResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BICfromIBANResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public BICfromIBANResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BICfromIBANResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
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
    
    /// <summary>IBANDetailsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class IBANDetailsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public IBANDetailsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class IBANDetailsResponseBody : System.Collections.ObjectModel.Collection<Anonymous2>
    {
    
    }
    
    /// <summary>IBANFromBBANResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class IBANFromBBANResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public IBANFromBBANResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class IBANFromBBANResponseBody : System.Collections.ObjectModel.Collection<Anonymous3>
    {
    
    }
    
    /// <summary>IBANNumberGeneratedResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class IBANNumberGeneratedResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public IBANNumberGeneratedResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class IBANNumberGeneratedResponseBody : System.Collections.ObjectModel.Collection<Anonymous4>
    {
    
    }
    
    /// <summary>IBANStructureResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class IBANStructureResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public IBANStructureResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class IBANStructureResponseBody : System.Collections.ObjectModel.Collection<Anonymous5>
    {
    
    }
    
    /// <summary>IBANResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class IBANResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public IBANResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class IBANResponseBody : System.Collections.ObjectModel.Collection<Anonymous6>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>Bank Identifier Code (BIC) of the Beneficiary bank.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bicId")]
        public string? BicId { get; set; }= default!;
    
        /// <summary>The name of the bank being referred to.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bankName")]
        public string? BankName { get; set; }= default!;
    
        /// <summary>Identifies the country of the customer.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }= default!;
    
        /// <summary>City address stated on driver licence or utlility bill. For example London, New York etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }= default!;
    
    
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
        /// <summary>International Bank Account number, an identifier of the account. E.g. GB29 NWBK 6016 1331 9268 19</summary>
        [System.Text.Json.Serialization.JsonPropertyName("iban")]
        [System.ComponentModel.DataAnnotations.StringLength(36)]
        public string? Iban { get; set; }= default!;
    
        /// <summary>ISO country code of the financial institution. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryId")]
        public string? CountryId { get; set; }= default!;
    
        /// <summary>Contains the checksum extracted from the IBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("checksum")]
        public string? Checksum { get; set; }= default!;
    
        /// <summary>Contains the identifier of the bank with which the transaction is performed</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bankId")]
        public string? BankId { get; set; }= default!;
    
        /// <summary>Unique and unambiguous identification of a branch of a financial institution.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("branchId")]
        public string? BranchId { get; set; }= default!;
    
        /// <summary>Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountNumber")]
        public string? AccountNumber { get; set; }= default!;
    
        /// <summary>Contains the length of the IBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("ibanLength")]
        public string? IbanLength { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous3 
    {
        /// <summary>International Bank Account number, an identifier of the account. E.g. GB29 NWBK 6016 1331 9268 19</summary>
        [System.Text.Json.Serialization.JsonPropertyName("iban")]
        [System.ComponentModel.DataAnnotations.StringLength(36)]
        public string? Iban { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous4 
    {
        /// <summary>International Bank Account number, an identifier of the account. E.g. GB29 NWBK 6016 1331 9268 19</summary>
        [System.Text.Json.Serialization.JsonPropertyName("iban")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? Iban { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous5 
    {
        /// <summary>Indicates the start position of the country code in the IBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryCodePosition")]
        public string? CountryCodePosition { get; set; }= default!;
    
        /// <summary>Indicates the number of characters of the country code in the IBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryCodeLength")]
        public string? CountryCodeLength { get; set; }= default!;
    
        /// <summary>Indicates the start position of check digits in the IBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("checkDigitsPosition")]
        public string? CheckDigitsPosition { get; set; }= default!;
    
        /// <summary>Indicates the number of check digits in the IBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("checkDigitsLength")]
        public string? CheckDigitsLength { get; set; }= default!;
    
        /// <summary>Indicates the start position of bank identifier in the IBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bankIdentifierPosition")]
        public string? BankIdentifierPosition { get; set; }= default!;
    
        /// <summary>Indicates the number of characters of bank identifier in the IBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bankIdentifierLength")]
        public string? BankIdentifierLength { get; set; }= default!;
    
        /// <summary>Indicates the start position of the branch identifier in the IBAN (value is empty if the branch identifier is not applied in the country's IBAN format).</summary>
        [System.Text.Json.Serialization.JsonPropertyName("branchIdentifierPosition")]
        public string? BranchIdentifierPosition { get; set; }= default!;
    
        /// <summary>Indicates the number of characters of the branch identifier in the IBAN (value is 0 if the branch identifier is not applied in the country's IBAN format)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("branchIdentifierLength")]
        public string? BranchIdentifierLength { get; set; }= default!;
    
        /// <summary>Indicates the number of significant characters of the National ID value that are used by SWIFT to populate the IBAN NATIONAL ID and that are sufficient to derive the IBAN BIC correctly.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("nationalIdLength")]
        public string? NationalIdLength { get; set; }= default!;
    
        /// <summary>Indicates the start position of the account number in the IBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountNumberPosition")]
        public string? AccountNumberPosition { get; set; }= default!;
    
        /// <summary>Indicates the number of characters of the account number in the IBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountNumberLength")]
        public string? AccountNumberLength { get; set; }= default!;
    
        /// <summary>Indicates the total number of characters in the IBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalLength")]
        public string? TotalLength { get; set; }= default!;
    
        /// <summary>Indicates whether the IBAN is used in one of the SEPA schemes, Y - if it does; N - if it does not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("sepaMember")]
        public string? SepaMember { get; set; }= default!;
    
        /// <summary>The date from which the IBAN can start being used in customer credit payments, in the format YYYYMMDD</summary>
        [System.Text.Json.Serialization.JsonPropertyName("optionalCommenceDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? OptionalCommenceDate { get; set; }= default!;
    
        /// <summary>The date from which the IBAN must be used in customer credit payments, in the format YYYYMMDD</summary>
        [System.Text.Json.Serialization.JsonPropertyName("mandatoryCommenceDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? MandatoryCommenceDate { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous6 
    {
        /// <summary>International Bank Account number, an identifier of the account. E.g. GB29 NWBK 6016 1331 9268 19</summary>
        [System.Text.Json.Serialization.JsonPropertyName("iban")]
        [System.ComponentModel.DataAnnotations.StringLength(36)]
        public string? Iban { get; set; }= default!;
    
        /// <summary>Indicates the IBAN was validated.Contains true if the IBAN is valid.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("isIBANValid")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? IsIBANValid { get; set; }= default!;
    
    
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