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

namespace Transact.Holding.Transactions
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface ITransactionService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves transaction details</summary>
        /// <param name="transactionId">Unique transaction identifier for retrieving the details of the transaction. For example: FT0102030333 etc.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>TransactionDetailsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<TransactionDetailsResponse> GetTransactionDetailsAsync(string transactionId, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, bool? disablePagination = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves accounting entries</summary>
        /// <param name="transactionReference">Contains the identifier for the transaction in the core system</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>StatementForTransactionResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<StatementForTransactionResponse> GetStatementForTransactionAsync(string transactionReference, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, bool? disablePagination = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves account transaction</summary>
        /// <param name="accountId">Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</param>
        /// <param name="customerId">Identifier of the customer</param>
        /// <param name="listType">Specifies the transaction Method(RECENT,COMPLETED,PENDING,SEARCH)</param>
        /// <param name="transactionCount">Specifies the number of transaction to be shown</param>
        /// <param name="payType">Indicates the identifier of payment types for  letter of credit.</param>
        /// <param name="dateFrom">Start date of the loan</param>
        /// <param name="dateTo">End date of the loan</param>
        /// <param name="minimumAmount">The minimum account balance required.</param>
        /// <param name="maximumAmount">The maximum account balance allowed.</param>
        /// <param name="displayName">Contains the name used for display or enrichment purposes</param>
        /// <param name="transactionCode">Identifies the system internal transaction code applicable to the transaction</param>
        /// <param name="entryReference">It is the transaction reference. This is the identifier of the transaction on Temenos Core Banking system.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>AccountTransactionsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<AccountTransactionsResponse> GetAccountTransactionsAsync(string? accountId = null, string? customerId = null, string? listType = null, string? transactionCount = null, string? payType = null, string? dateFrom = null, string? dateTo = null, string? minimumAmount = null, string? maximumAmount = null, string? displayName = null, string? transactionCode = null, string? entryReference = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, bool? disablePagination = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    
    /// <summary>TransactionDetailsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TransactionDetailsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public TransactionDetailsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TransactionDetailsResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
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
    
    /// <summary>StatementForTransactionResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class StatementForTransactionResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public StatementForTransactionResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class StatementForTransactionResponseBody : System.Collections.ObjectModel.Collection<Anonymous2>
    {
    
    }
    
    /// <summary>AccountTransactionsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AccountTransactionsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public AccountTransactionsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AccountTransactionsResponseBody : System.Collections.ObjectModel.Collection<Anonymous3>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>Debit value of the transaction </summary>
        [System.Text.Json.Serialization.JsonPropertyName("debits")]
        public System.Collections.Generic.ICollection<Debits>? Debits { get; set; }= default!;
    
        /// <summary>Credit value of the transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("credits")]
        public System.Collections.Generic.ICollection<Credits>? Credits { get; set; }= default!;
    
        /// <summary>Identifies the Beneficiary name and address of the Standing Order</summary>
        [System.Text.Json.Serialization.JsonPropertyName("beneficiaries")]
        public System.Collections.Generic.ICollection<Beneficiaries>? Beneficiaries { get; set; }= default!;
    
        /// <summary>It is the transaction reference. This is the identifier of the transaction on Temenos Core Banking system.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entryReference")]
        public string? EntryReference { get; set; }= default!;
    
        /// <summary>Business date on which the accounting entry was generated.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bookingDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? BookingDate { get; set; }= default!;
    
        /// <summary>The additional text printed on descriptive statements in addition to the standard narrative and/or reference</summary>
        [System.Text.Json.Serialization.JsonPropertyName("narrative")]
        public string? Narrative { get; set; }= default!;
    
        /// <summary>Identifier of the currency. This is the 3-letter ISO 4217 code of the currency.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currencyId")]
        public string? CurrencyId { get; set; }= default!;
    
        /// <summary>Contains the date from which the payment is expected and is used to indicate the exposure date for the payment.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("clearingDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ClearingDate { get; set; }= default!;
    
        /// <summary>Indicates the value date on which the underlying accounting entry is to be given value (for interest purposes)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("valueDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ValueDate { get; set; }= default!;
    
        /// <summary>Contains the identifier for the transaction in the core system</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionReference")]
        public string? TransactionReference { get; set; }= default!;
    
        /// <summary>The transaction description</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionName")]
        public string? TransactionName { get; set; }= default!;
    
        /// <summary>The ISO code (3 letters) for the institution's local currency.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("localCurrencyId")]
        public string? LocalCurrencyId { get; set; }= default!;
    
        /// <summary>Indicates the charge types which are applicable for the transaction. Example: CORRBKCHG</summary>
        [System.Text.Json.Serialization.JsonPropertyName("chargeType")]
        public string? ChargeType { get; set; }= default!;
    
        /// <summary>Retrieves the Charge Amount after redeem</summary>
        [System.Text.Json.Serialization.JsonPropertyName("chargeAmount")]
        public string? ChargeAmount { get; set; }= default!;
    
        /// <summary>This is a system populated field to display the date on which MT740 (Authorization to Reimburse) was sent.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dateOfOriginalAuthorisation")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? DateOfOriginalAuthorisation { get; set; }= default!;
    
        /// <summary>The date when payment instruction is processed in system.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("processingDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ProcessingDate { get; set; }= default!;
    
        /// <summary>Cheque number associated with the transaction or accounting entry.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("chequeNumber")]
        public string? ChequeNumber { get; set; }= default!;
    
        /// <summary>The name of the bank being referred to.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bankName")]
        public string? BankName { get; set; }= default!;
    
        /// <summary>Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountId")]
        public string? AccountId { get; set; }= default!;
    
        /// <summary>The exchange rate that is actually applied for currency conversion in case of transactions involving FX conversion. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerRate")]
        public string? CustomerRate { get; set; }= default!;
    
    
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
        [System.Text.Json.Serialization.JsonPropertyName("images")]
        public System.Collections.Generic.ICollection<Images>? Images { get; set; }= default!;
    
        /// <summary>It is the transaction reference. This is the identifier of the transaction on Temenos Core Banking system.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entryReference")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? EntryReference { get; set; }= default!;
    
        /// <summary>Business date on which the accounting entry was generated.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bookingDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? BookingDate { get; set; }= default!;
    
        /// <summary>The additional text printed on descriptive statements in addition to the standard narrative and/or reference</summary>
        [System.Text.Json.Serialization.JsonPropertyName("narrative")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? Narrative { get; set; }= default!;
    
        /// <summary>This is the payment amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }= default!;
    
        /// <summary>Identifier of the currency. This is the 3-letter ISO 4217 code of the currency.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currencyId")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? CurrencyId { get; set; }= default!;
    
        /// <summary>Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? AccountId { get; set; }= default!;
    
        /// <summary>Display name or short name of the account specified.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountName")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? AccountName { get; set; }= default!;
    
        /// <summary>Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("companyId")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? CompanyId { get; set; }= default!;
    
        /// <summary>Notes to facilitate the use of the Function.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("notes")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? Notes { get; set; }= default!;
    
        /// <summary>Unique transaction identifier for retrieving the details of the transaction. For example: FT0102030333 etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? TransactionId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous3 
    {
        /// <summary>It is the transaction reference. This is the identifier of the transaction on Temenos Core Banking system.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entryReference")]
        public string? EntryReference { get; set; }= default!;
    
        /// <summary>Business date on which the accounting entry was generated.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bookingDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? BookingDate { get; set; }= default!;
    
        /// <summary>The additional text printed on descriptive statements in addition to the standard narrative and/or reference</summary>
        [System.Text.Json.Serialization.JsonPropertyName("narrative")]
        public string? Narrative { get; set; }= default!;
    
        /// <summary>Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountId")]
        public string? AccountId { get; set; }= default!;
    
        /// <summary>This is the payment amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }= default!;
    
        /// <summary>Identifier of the currency. This is the 3-letter ISO 4217 code of the currency.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currencyId")]
        public string? CurrencyId { get; set; }= default!;
    
        /// <summary>Display name or short name of the account specified.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountName")]
        public string? AccountName { get; set; }= default!;
    
        /// <summary>Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("companyId")]
        public string? CompanyId { get; set; }= default!;
    
        /// <summary>Based on documentCode, the field defaults the required document codes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("documentId")]
        public string? DocumentId { get; set; }= default!;
    
        /// <summary>Notes to facilitate the use of the Function.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }= default!;
    
        /// <summary>A system generated unique identifier for the image record</summary>
        [System.Text.Json.Serialization.JsonPropertyName("imageId")]
        public string? ImageId { get; set; }= default!;
    
        /// <summary>The monetary value of each balance type for an account is itemised.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public double? Balance { get; set; }= default!;
    
        /// <summary>Contains the identifier for the transaction in the core system</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionReference")]
        public string? TransactionReference { get; set; }= default!;
    
        /// <summary>Identifies the transaction type applicable to the transaction being processed, i.e. outward or inward payment. For example: ACPX, OTPX etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionType")]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? TransactionType { get; set; }= default!;
    
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? DisplayName { get; set; }= default!;
    
        /// <summary>Contains the name of the account, basically the short title of the account.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("shortName")]
        public string? ShortName { get; set; }= default!;
    
        /// <summary>The stock exchange identifier</summary>
        [System.Text.Json.Serialization.JsonPropertyName("stockExchange")]
        public string? StockExchange { get; set; }= default!;
    
        /// <summary>The International Securities Identification Number of the instrument</summary>
        [System.Text.Json.Serialization.JsonPropertyName("ISIN")]
        public string? ISIN { get; set; }= default!;
    
        /// <summary>Indicates the value date on which the underlying accounting entry is to be given value (for interest purposes)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("valueDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ValueDate { get; set; }= default!;
    
        /// <summary>The nominal quantity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Debits 
    {
        /// <summary>The currency of the debit side in payment transaction. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("debitCurrencyId")]
        public string? DebitCurrencyId { get; set; }= default!;
    
        /// <summary>Amount to be debited in a payment transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("debitAmount")]
        public string? DebitAmount { get; set; }= default!;
    
        /// <summary>Date on which the amount will be debited for settlement</summary>
        [System.Text.Json.Serialization.JsonPropertyName("debitValueDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? DebitValueDate { get; set; }= default!;
    
        /// <summary>Indicates the debit account number of the payment or transaction.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("debitAccountId")]
        public string? DebitAccountId { get; set; }= default!;
    
        /// <summary>International Bank Account Number (IBAN) of the debtor account, required only for International transfers/payments outside the Bank. For example: GB98 MIDL07009312345678, FR7630006000011234567890189</summary>
        [System.Text.Json.Serialization.JsonPropertyName("debitAccountIBAN")]
        public string? DebitAccountIBAN { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Credits 
    {
        /// <summary>Specifies the credit currency. For example: USD, EUR etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("creditCurrencyId")]
        public string? CreditCurrencyId { get; set; }= default!;
    
        /// <summary>Amount to be credited in a payment transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("creditAmount")]
        public string? CreditAmount { get; set; }= default!;
    
        /// <summary>Reference quoted by the credit account for a payment</summary>
        [System.Text.Json.Serialization.JsonPropertyName("creditValueDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? CreditValueDate { get; set; }= default!;
    
        /// <summary>Credit account identifier of the payment or transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("creditAccountId")]
        public string? CreditAccountId { get; set; }= default!;
    
        /// <summary>Indicates the IBAN of the credit account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("creditAccountIBAN")]
        public string? CreditAccountIBAN { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Beneficiaries 
    {
        /// <summary>International Bank Account Number (IBAN) of the beneficiary account, required only for International transfers/payments outside the Bank. For example: GB98 MIDL07009312345678, FR7630006000011234567890189</summary>
        [System.Text.Json.Serialization.JsonPropertyName("beneficiaryIBAN")]
        public string? BeneficiaryIBAN { get; set; }= default!;
    
        /// <summary>Unique account identifier of the beneficiary account number.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("beneficiaryAccountId")]
        public string? BeneficiaryAccountId { get; set; }= default!;
    
        /// <summary>Identifies the Customer who is to be the ultimate receiver of the funds transferred by the sending bank when this Beneficiary is not a bank.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("beneficiaryCustomerId")]
        public string? BeneficiaryCustomerId { get; set; }= default!;
    
        /// <summary>Bank for the beneficiary</summary>
        [System.Text.Json.Serialization.JsonPropertyName("beneficiaryBank")]
        public string? BeneficiaryBank { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Images 
    {
        /// <summary>Based on documentCode, the field defaults the required document codes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("documentId")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? DocumentId { get; set; }= default!;
    
        /// <summary>A system generated unique identifier for the image record</summary>
        [System.Text.Json.Serialization.JsonPropertyName("imageId")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? ImageId { get; set; }= default!;
    
        /// <summary>Indicates the internal classification of images - such as Photographs, Documents, Passports, etc..,</summary>
        [System.Text.Json.Serialization.JsonPropertyName("imageType")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? ImageType { get; set; }= default!;
    
    
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