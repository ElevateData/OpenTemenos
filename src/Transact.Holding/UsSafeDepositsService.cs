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

namespace Transact.Holding.UsSafeDeposits
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IUsSafeDepositsService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>API to retrieve Safe deposit box information like Ownership, rent, due amounts, caution deposit, box status, visit information, etc,.</summary>
        /// <param name="accountId">Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <returns>UsSafeDepositBoxOverviewResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<UsSafeDepositBoxOverviewResponse> GetUsSafeDepositBoxOverviewAsync(string accountId, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class QueryHeader 
    {
        [System.Text.Json.Serialization.JsonPropertyName("audit")]
        public Audit? Audit { get; set; }= default!;
    
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
    
    /// <summary>UsSafeDepositBoxOverviewResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class UsSafeDepositBoxOverviewResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public UsSafeDepositBoxOverviewResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class UsSafeDepositBoxOverviewResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
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
        /// <summary>Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountId")]
        public string? AccountId { get; set; }= default!;
    
        /// <summary>Indicates an unique identifier of an account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("arrangementId")]
        public string? ArrangementId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("alternateAccountId")]
        public string? AlternateAccountId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("alternateAccountType")]
        public string? AlternateAccountType { get; set; }= default!;
    
        /// <summary>Specifies the current status of the account, which is either active, inactive or closed.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountStatus")]
        public string? AccountStatus { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("branchId")]
        public string? BranchId { get; set; }= default!;
    
        /// <summary>Company of the account to be created</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountCompany")]
        public string? AccountCompany { get; set; }= default!;
    
        /// <summary>Contains the unique identifier of the product, e.g. the product id of the arrangement account.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public string? ProductId { get; set; }= default!;
    
        /// <summary>Indicates the description of the Product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productDescription")]
        public string? ProductDescription { get; set; }= default!;
    
        /// <summary>The identifier of the product category</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productCategoryId")]
        public string? ProductCategoryId { get; set; }= default!;
    
        /// <summary>The date the account is opened.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("openingDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? OpeningDate { get; set; }= default!;
    
        /// <summary>Identifier of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerId")]
        public double? CustomerId { get; set; }= default!;
    
        /// <summary>Name of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerName")]
        public string? CustomerName { get; set; }= default!;
    
        /// <summary>Indicates if customer or account holder is in active military service</summary>
        [System.Text.Json.Serialization.JsonPropertyName("inActiveMilitaryService")]
        public string? InActiveMilitaryService { get; set; }= default!;
    
        /// <summary>The customer role with drop down of standard selections</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerRole")]
        public string? CustomerRole { get; set; }= default!;
    
        /// <summary>Title line 1 that will appear in notice and statements</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountTitle1")]
        public string? AccountTitle1 { get; set; }= default!;
    
        /// <summary>Title line 2 that will appear in notice and statements</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountTitle2")]
        public string? AccountTitle2 { get; set; }= default!;
    
        /// <summary>Title line 3 that will appear in notice and statements</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountTitle3")]
        public string? AccountTitle3 { get; set; }= default!;
    
        /// <summary>Title line 4 that will appear in notice and statements</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountTitle4")]
        public string? AccountTitle4 { get; set; }= default!;
    
        /// <summary>Type of Safe deposit Box rented for the Customer. Ex, SMALL, MEDIUM, etc,. Allowed user defined values can be retreived through getEbLookups for virtualTableName AA.SDB.BOX.TYPE</summary>
        [System.Text.Json.Serialization.JsonPropertyName("boxType")]
        public double? BoxType { get; set; }= default!;
    
        /// <summary>Description or additional details of the safe deposit box</summary>
        [System.Text.Json.Serialization.JsonPropertyName("boxdescription")]
        public string? Boxdescription { get; set; }= default!;
    
        /// <summary>Status of the safe deposit Box</summary>
        [System.Text.Json.Serialization.JsonPropertyName("boxStatus")]
        public string? BoxStatus { get; set; }= default!;
    
        /// <summary>Internal identification number for the Safe deposit box</summary>
        [System.Text.Json.Serialization.JsonPropertyName("boxNumber")]
        public double? BoxNumber { get; set; }= default!;
    
        /// <summary>Safe deposit box rental amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("rentAmount")]
        public double? RentAmount { get; set; }= default!;
    
        /// <summary>Tax amount for safe deposit rental service</summary>
        [System.Text.Json.Serialization.JsonPropertyName("taxOnRentAmount")]
        public double? TaxOnRentAmount { get; set; }= default!;
    
        /// <summary>Due date for safe deposit box rental payment</summary>
        [System.Text.Json.Serialization.JsonPropertyName("rentDueDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? RentDueDate { get; set; }= default!;
    
        /// <summary>Identifies the total outstanding amount for the corresponding Liability number and Limit reference. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("outstandingAmount")]
        public double? OutstandingAmount { get; set; }= default!;
    
        /// <summary>Date the Customer visited safe deposit box</summary>
        [System.Text.Json.Serialization.JsonPropertyName("visitDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? VisitDate { get; set; }= default!;
    
        /// <summary>Time the customer checked in</summary>
        [System.Text.Json.Serialization.JsonPropertyName("checkInTime")]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([0-1]\d|2[0-3]):([0-5]\d):([0-5]\d)$")]
        public string? CheckInTime { get; set; }= default!;
    
        /// <summary>Time the customer checked out</summary>
        [System.Text.Json.Serialization.JsonPropertyName("checkOutTime")]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([0-1]\d|2[0-3]):([0-5]\d):([0-5]\d)$")]
        public string? CheckOutTime { get; set; }= default!;
    
        /// <summary>Customer number of the customer who visited the safe deposit box</summary>
        [System.Text.Json.Serialization.JsonPropertyName("visitCustomer")]
        public double? VisitCustomer { get; set; }= default!;
    
        /// <summary>Name of the customer who visited the safe deposit box</summary>
        [System.Text.Json.Serialization.JsonPropertyName("visitCustomerName")]
        public string? VisitCustomerName { get; set; }= default!;
    
    
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