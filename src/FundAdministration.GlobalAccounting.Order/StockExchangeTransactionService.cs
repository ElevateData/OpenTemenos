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

namespace FundAdministration.GlobalAccounting.Order.StockExchangeTransactions
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IStockExchangeTransactionService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates and manages equity transactions</summary>
        /// <param name="payload">createStockExchangeTransaction Payload</param>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <returns>createStockExchangeTransaction Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CreateStockExchangeTransactionSuccessResponse> CreateStockExchangeTransactionAsync(_0BULKPayload payload, string? referenceId = null, string? token = null, string? username = null, string? company = null, string? command = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class _0BULKPayload 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public object? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public Body? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaginationSchema 
    {
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public string? Page { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public string? Count { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public string? Total { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AuditSchema 
    {
        [System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public string? StartTime { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public string? EndTime { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("processTime")]
        public string? ProcessTime { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SuccessHeaderstatusSchema 
    {
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("HTTP_MESSAGE")]
        public string? HTTP_MESSAGE { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("HTTP_CODE")]
        public string? HTTP_CODE { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("responseId")]
        public string? ResponseId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("eTag")]
        public string? ETag { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        public string? LastModified { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateStockExchangeTransactionSuccessheaderResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public PaginationSchema? Pagination { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("audit")]
        public AuditSchema? Audit { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public SuccessHeaderstatusSchema? Status { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("referenceId")]
        public string? ReferenceId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("details")]
        public System.Collections.Generic.ICollection<Details>? Details { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateStockExchangeTransactionrecordsSchema : System.Collections.ObjectModel.Collection<_0>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateStockExchangeTransactionSuccessbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public CreateStockExchangeTransactionrecordsSchema? Records { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateStockExchangeTransactionSuccessResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public CreateStockExchangeTransactionSuccessheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public CreateStockExchangeTransactionSuccessbodyResponse? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ErrorHeaderstatusSchema 
    {
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("HTTP_MESSAGE")]
        public string? HTTP_MESSAGE { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("HTTP_CODE")]
        public string? HTTP_CODE { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("responseId")]
        public string? ResponseId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("eTag")]
        public string? ETag { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        public string? LastModified { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("details")]
        public System.Collections.Generic.ICollection<Details2>? Details { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateStockExchangeTransactionErrorheaderResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public PaginationSchema? Pagination { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("audit")]
        public AuditSchema? Audit { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public ErrorHeaderstatusSchema? Status { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("referenceId")]
        public string? ReferenceId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateStockExchangeTransactionErrorbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public System.Collections.Generic.ICollection<Items>? Items { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateStockExchangeTransactionErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public CreateStockExchangeTransactionErrorheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class _0 
    {
        /// <summary>Multifonds Transaction type code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionType")]
        public string? TransactionType { get; set; }= default!;
    
        /// <summary>Existing system fund number</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fundIdentifierCode")]
        public string? FundIdentifierCode { get; set; }= default!;
    
        /// <summary>Existing system entry number</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionNumber")]
        public string? TransactionNumber { get; set; }= default!;
    
        /// <summary>Relates to Identifier codes of security,Provider,Thirdparty and industry etc</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIdentifierType")]
        public string? SecurityIdentifierType { get; set; }= default!;
    
        /// <summary>The External identification code for Security like 01 for Telekurs, 03 for Sedol. Also used for other provider identifiers</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIdentifierCode")]
        public string? SecurityIdentifierCode { get; set; }= default!;
    
        /// <summary>Tax lot number to identify tax lots based on acquisition date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractNumber")]
        public string? ContractNumber { get; set; }= default!;
    
        /// <summary>Custodian where the units of the transaction would be lodged</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityCustodianIdentifierCode")]
        public string? SecurityCustodianIdentifierCode { get; set; }= default!;
    
        /// <summary>Trade date of the transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("tradeDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? TradeDate { get; set; }= default!;
    
        /// <summary>Settlement date of transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("settlementDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? SettlementDate { get; set; }= default!;
    
        /// <summary>Transaction Quantity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }= default!;
    
        /// <summary>The unit price of an instrument which is being transacted.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bookPrice")]
        public double? BookPrice { get; set; }= default!;
    
        /// <summary>Currency of operation gross amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityCurrency")]
        public string? SecurityCurrency { get; set; }= default!;
    
        /// <summary>Gross amount of the transaction which is quantity multiplied by price</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bookCostInSecurityCurrency")]
        public double? BookCostInSecurityCurrency { get; set; }= default!;
    
        /// <summary>Purchase/sale interest on a interest bearing instrument</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accruedInterestsAmountPurchased")]
        public double? AccruedInterestsAmountPurchased { get; set; }= default!;
    
        /// <summary>Currency of operation net amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("netAmountCurrency")]
        public string? NetAmountCurrency { get; set; }= default!;
    
        /// <summary>Net amount of transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("netAmountExpressedInSecurityCurrency")]
        public double? NetAmountExpressedInSecurityCurrency { get; set; }= default!;
    
        /// <summary>Transaction fees currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionFeeCurrency")]
        public string? TransactionFeeCurrency { get; set; }= default!;
    
        /// <summary>This field denotes the fee amount of the transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionFeesAmount")]
        public double? TransactionFeesAmount { get; set; }= default!;
    
        /// <summary>Fees code for booking transaction fees</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionFeeIdentifierCode")]
        public string? TransactionFeeIdentifierCode { get; set; }= default!;
    
        /// <summary>Correspondent bank where the cash proceeds from the transaction would be settled</summary>
        [System.Text.Json.Serialization.JsonPropertyName("depositaryBankIdentifierCode")]
        public string? DepositaryBankIdentifierCode { get; set; }= default!;
    
        /// <summary>Account manager number fund</summary>
        [System.Text.Json.Serialization.JsonPropertyName("managerIdentifierCode")]
        public string? ManagerIdentifierCode { get; set; }= default!;
    
        /// <summary>Currency in which the settlement would be processed.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("settlementCurrency")]
        public string? SettlementCurrency { get; set; }= default!;
    
        /// <summary>Exchange rate applied if Null then calculated by MF</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionExchangeRate")]
        public double? TransactionExchangeRate { get; set; }= default!;
    
        /// <summary>Amount of settlement as part of the transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("netAmountExpressedInSettlementCurrency")]
        public double? NetAmountExpressedInSettlementCurrency { get; set; }= default!;
    
        /// <summary>Counterparts correspondent number</summary>
        [System.Text.Json.Serialization.JsonPropertyName("brokerAndCounterpartyIdentifierCode")]
        public string? BrokerAndCounterpartyIdentifierCode { get; set; }= default!;
    
        /// <summary>Time stamp of the trade execution in the market.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("execTimestamp")]
        public string? ExecTimestamp { get; set; }= default!;
    
        /// <summary>Security identifier used in the transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("mfSecurityIdentifier")]
        public double? MfSecurityIdentifier { get; set; }= default!;
    
        /// <summary>This field denotes the status of the trade. Confirmed or Not Confirmed</summary>
        [System.Text.Json.Serialization.JsonPropertyName("softHardDealIndicator")]
        public string? SoftHardDealIndicator { get; set; }= default!;
    
        /// <summary>Unconfirm deal flag</summary>
        [System.Text.Json.Serialization.JsonPropertyName("unconfirmedTradeFlag")]
        public string? UnconfirmedTradeFlag { get; set; }= default!;
    
        /// <summary>The price at which an instruments if redeemed.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("purchaseYield")]
        public double? PurchaseYield { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Body 
    {
        [System.Text.Json.Serialization.JsonPropertyName("stockExchangeTransactions")]
        public System.Collections.Generic.ICollection<_0>? StockExchangeTransactions { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Details 
    {
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Details2 
    {
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Items 
    {
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
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