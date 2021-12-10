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

namespace Transact.Party.CustomerArrangements
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface ICustomerArrangementsService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the list of accounts(Accounts,Deposits,Loans) available for a customer</summary>
        /// <param name="customerId">The identifier of the customer</param>
        /// <param name="arrangementId">The unique identifiier of an arrangement contract. The format of the ID is YYDDDXXXXX prefixed with AA. YYDDD is the year and date of input in julian date format, XXXXX - is a random generated string.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="companyId">The identifier of the company, following the format CCGGGLLLL, where: CC is the country code, GGG is Company Group Code and LLLL is the Local Code. Country Code must be a valid countryCode, Company Group Code must be 3 numeric characters in the range 001-999 and must be a valid companyGroup. The Local Code is 4 numeric characters in the range 0001-9999, e.g. GB0010001</param>
        /// <returns>ArrangementListResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ArrangementListResponse> GetArrangementListAsync(string customerId, string? arrangementId = null, string? productGroup = null, string? product = null, string? currency = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the list of accounts available for a customer(Only from Accounts Product)</summary>
        /// <param name="customerId">The identifier of the customer</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="companyId">The identifier of the company, following the format CCGGGLLLL, where: CC is the country code, GGG is Company Group Code and LLLL is the Local Code. Country Code must be a valid countryCode, Company Group Code must be 3 numeric characters in the range 001-999 and must be a valid companyGroup. The Local Code is 4 numeric characters in the range 0001-9999, e.g. GB0010001</param>
        /// <returns>ArrangementAccountsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ArrangementAccountsResponse> GetArrangementAccountsAsync(string customerId, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the list of Bundle accounts available for a customer</summary>
        /// <param name="customerId">The identifier of the customer</param>
        /// <param name="arrangementId">The unique identifiier of an arrangement contract. The format of the ID is YYDDDXXXXX prefixed with AA. YYDDD is the year and date of input in julian date format, XXXXX - is a random generated string.</param>
        /// <param name="productGroupId">The identifier of the product group</param>
        /// <param name="productId">The identifier of the product</param>
        /// <param name="currencyId">The identifier of the curreny. The is the 3 letter ISO 4217 code of the currency.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="companyId">The identifier of the company, following the format CCGGGLLLL, where: CC is the country code, GGG is Company Group Code and LLLL is the Local Code. Country Code must be a valid countryCode, Company Group Code must be 3 numeric characters in the range 001-999 and must be a valid companyGroup. The Local Code is 4 numeric characters in the range 0001-9999, e.g. GB0010001</param>
        /// <returns>ProductBundlesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ProductBundlesResponse> GetProductBundlesAsync(string customerId, string? arrangementId = null, string? productGroupId = null, string? productId = null, string? currencyId = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the Pricing Condition related to a customer</summary>
        /// <param name="customerId">The identifier of the customer</param>
        /// <param name="arrangementId">The unique identifiier of an arrangement contract. The format of the ID is YYDDDXXXXX prefixed with AA. YYDDD is the year and date of input in julian date format, XXXXX - is a random generated string.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="companyId">The identifier of the company, following the format CCGGGLLLL, where: CC is the country code, GGG is Company Group Code and LLLL is the Local Code. Country Code must be a valid countryCode, Company Group Code must be 3 numeric characters in the range 001-999 and must be a valid companyGroup. The Local Code is 4 numeric characters in the range 0001-9999, e.g. GB0010001</param>
        /// <returns>PreferentialPricingResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PreferentialPricingResponse> GetPreferentialPricingAsync(string customerId, string? arrangementId = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    
    /// <summary>ArrangementListResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ArrangementListResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public ArrangementListResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ArrangementListResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
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
        /// <summary>for bad requests</summary>
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
        /// <summary>caused by server</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type: System</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>ArrangementAccountsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ArrangementAccountsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public ArrangementAccountsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ArrangementAccountsResponseBody : System.Collections.ObjectModel.Collection<Anonymous2>
    {
    
    }
    
    /// <summary>ProductBundlesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ProductBundlesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public ProductBundlesResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ProductBundlesResponseBody : System.Collections.ObjectModel.Collection<Anonymous3>
    {
    
    }
    
    /// <summary>PreferentialPricingResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PreferentialPricingResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public PreferentialPricingResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PreferentialPricingResponseBody : System.Collections.ObjectModel.Collection<Anonymous4>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>The unique identifiier of an arrangement contract. The format of the ID is YYDDDXXXXX prefixed with AA. YYDDD is the year and date of input in julian date format, XXXXX - is a random generated string.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("arrangementId")]
        public string? ArrangementId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("account")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? Account { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("productDescription")]
        public string? ProductDescription { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("customer")]
        public string? Customer { get; set; }= default!;
    
        /// <summary>The name that is displayed for the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? CustomerName { get; set; }= default!;
    
        /// <summary>The status of the arrangement</summary>
        [System.Text.Json.Serialization.JsonPropertyName("arrangementStatus")]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string? ArrangementStatus { get; set; }= default!;
    
    
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
        [System.Text.Json.Serialization.JsonPropertyName("customers")]
        public System.Collections.Generic.ICollection<Customers>? Customers { get; set; }= default!;
    
        /// <summary>The identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? AccountId { get; set; }= default!;
    
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public string? DisplayName { get; set; }= default!;
    
        /// <summary>The cardType and number of the card. Card issues are defined with an ID consisting of three elements. The card type, a full stop and the card number. The card type must be a valid cardType. The card number may be any alphanumeric construction, e.g. VISA.1234567887654321 GC.1111222233334444 AB21.1111111122222222</summary>
        [System.Text.Json.Serialization.JsonPropertyName("cardNumber")]
        [System.ComponentModel.DataAnnotations.StringLength(18)]
        public string? CardNumber { get; set; }= default!;
    
        /// <summary>The identifier of the curreny. The is the 3 letter ISO 4217 code of the currency.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currencyId")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? CurrencyId { get; set; }= default!;
    
        /// <summary>Balance of the account that represents total of transactions posted against the account excluding any entries with the processing date in the future.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("onlineActualBalance")]
        public double? OnlineActualBalance { get; set; }= default!;
    
        /// <summary>The total of cleared funds booked against the account. Same as onlineActualBalance with the exception of credit or reversed debit entries with the exposure date in the future.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("onlineClearedBalance")]
        public double? OnlineClearedBalance { get; set; }= default!;
    
        /// <summary>The amount of funds that have been blocked (reserved) for specific purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("lockedAmount")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 19D)]
        public double? LockedAmount { get; set; }= default!;
    
        /// <summary>The amount of an allocated credit limit that is available for the nomniated customer to utilise</summary>
        [System.Text.Json.Serialization.JsonPropertyName("availableLimit")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 19D)]
        public double? AvailableLimit { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("leadCurrency")]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? LeadCurrency { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous3 
    {
        [System.Text.Json.Serialization.JsonPropertyName("products")]
        public System.Collections.Generic.ICollection<Products>? Products { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("customers")]
        public System.Collections.Generic.ICollection<Customers2>? Customers { get; set; }= default!;
    
        /// <summary>The unique identifiier of an arrangement contract. The format of the ID is YYDDDXXXXX prefixed with AA. YYDDD is the year and date of input in julian date format, XXXXX - is a random generated string.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("arrangementId")]
        public string? ArrangementId { get; set; }= default!;
    
        /// <summary>The amount of the balance, typically linked to a balance type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("balanceAmount")]
        public double? BalanceAmount { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous4 
    {
        [System.Text.Json.Serialization.JsonPropertyName("products")]
        public System.Collections.Generic.ICollection<Products2>? Products { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("priceProductName")]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public string? PriceProductName { get; set; }= default!;
    
        /// <summary>The unique identifiier of an arrangement contract. The format of the ID is YYDDDXXXXX prefixed with AA. YYDDD is the year and date of input in julian date format, XXXXX - is a random generated string.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("arrangementId")]
        public string? ArrangementId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("variation")]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string? Variation { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Customers 
    {
        [System.Text.Json.Serialization.JsonPropertyName("customerShortName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? CustomerShortName { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("roleDisplayName")]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public string? RoleDisplayName { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Products 
    {
        /// <summary>The name that is displayed for the product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productName")]
        public string? ProductName { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Customers2 
    {
        /// <summary>The identifier of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerId")]
        public string? CustomerId { get; set; }= default!;
    
        /// <summary>The name that is displayed for the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? CustomerName { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Products2 
    {
        /// <summary>The name that is displayed for the product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productName")]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public string? ProductName { get; set; }= default!;
    
        /// <summary>The identifier of the curreny. The is the 3 letter ISO 4217 code of the currency.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currencyId")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? CurrencyId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("interest")]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public string? Interest { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("bonus")]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public string? Bonus { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("charge")]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public string? Charge { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016