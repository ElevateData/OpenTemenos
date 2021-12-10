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

namespace FundAdministration.GlobalAccounting.Holding.CapitalDecreaseOfParValuesDomesticShare
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface ICapitalDecreaseOfParValuesDomesticShareService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates capital decrease of par value and partial repayment of par value (domestic shares)</summary>
        /// <param name="payload">createCapitalDecreaseOfParValueDomesticWithCostAdjustment Payload</param>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <returns>createCapitalDecreaseOfParValueDomesticWithCostAdjustment Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentSuccessResponse> CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentAsync(_0BULKPayload payload, string? referenceId = null, string? token = null, string? username = null, string? company = null, string? command = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    public partial class CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentSuccessheaderResponse 
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
    public partial class CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentrecordsSchema : System.Collections.ObjectModel.Collection<_0>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentSuccessbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentrecordsSchema? Records { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentSuccessResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentSuccessheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentSuccessbodyResponse? Body { get; set; }= default!;
    
    
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
    public partial class CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentErrorheaderResponse 
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
    public partial class CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentErrorbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public System.Collections.Generic.ICollection<Items>? Items { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentErrorheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class _0 
    {
        /// <summary>Transaction type identifier</summary>
        [System.Text.Json.Serialization.JsonPropertyName("operationCode")]
        public string? OperationCode { get; set; }= default!;
    
        /// <summary>The ex-date, or ex-dividend date, is the date on or after which a security is traded without a previously declared dividend or distribution.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entitlementDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? EntitlementDate { get; set; }= default!;
    
        /// <summary>Trade date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("tradeDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? TradeDate { get; set; }= default!;
    
        /// <summary>Value date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("settlementDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? SettlementDate { get; set; }= default!;
    
        /// <summary>Give for</summary>
        [System.Text.Json.Serialization.JsonPropertyName("exchangeOfNumberOfQuantity")]
        public double? ExchangeOfNumberOfQuantity { get; set; }= default!;
    
        /// <summary>Old sec.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("exchangeOption")]
        public double? ExchangeOption { get; set; }= default!;
    
        /// <summary>Unit amt.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("optionForCashflowIndicator")]
        public string? OptionForCashflowIndicator { get; set; }= default!;
    
        /// <summary>Unit Amount CA</summary>
        [System.Text.Json.Serialization.JsonPropertyName("cashflowPerUnitOnResultantQty")]
        public double? CashflowPerUnitOnResultantQty { get; set; }= default!;
    
        /// <summary>Currency Amount Receive Paid</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currencyOfCashflow")]
        public string? CurrencyOfCashflow { get; set; }= default!;
    
        /// <summary>External  reference corresponds a trade,security or fund</summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalReference")]
        public string? ExternalReference { get; set; }= default!;
    
        /// <summary>Subseq. no.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("subSequenceNumber")]
        public double? SubSequenceNumber { get; set; }= default!;
    
        /// <summary>Input the description of the transaction, else auto generated</summary>
        [System.Text.Json.Serialization.JsonPropertyName("shortDescription")]
        public string? ShortDescription { get; set; }= default!;
    
        /// <summary>Correct book value by</summary>
        [System.Text.Json.Serialization.JsonPropertyName("optionForBookcostCorrection")]
        public string? OptionForBookcostCorrection { get; set; }= default!;
    
        /// <summary>Book value adj.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("optionForBookValueAdjustment")]
        public string? OptionForBookValueAdjustment { get; set; }= default!;
    
        /// <summary>Correction Amount Old Or New Sec Currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("correctionAmountPerUnit")]
        public double? CorrectionAmountPerUnit { get; set; }= default!;
    
        /// <summary>Correspondent bank where the cash proceeds from the transaction would be settled</summary>
        [System.Text.Json.Serialization.JsonPropertyName("correspondentNumber")]
        public string? CorrespondentNumber { get; set; }= default!;
    
        /// <summary>Relates to Identifier codes of security,Provider,Thirdparty and industry etc</summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalProviderCode")]
        public string? ExternalProviderCode { get; set; }= default!;
    
        /// <summary>The External identification code for Security like 01 for Telekurs, 03 for Sedol. Also used for other provider identifiers</summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalSecurityIdentification")]
        public string? ExternalSecurityIdentification { get; set; }= default!;
    
        /// <summary>Dividend Process Announcement Modification Flag</summary>
        [System.Text.Json.Serialization.JsonPropertyName("processCUDOptions")]
        public string? ProcessCUDOptions { get; set; }= default!;
    
        /// <summary>Flg Vol Ca</summary>
        [System.Text.Json.Serialization.JsonPropertyName("flagForVoluntaryCa")]
        public string? FlagForVoluntaryCa { get; set; }= default!;
    
        /// <summary>Close old pos.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("closeExistingPositionOption")]
        public string? CloseExistingPositionOption { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Body 
    {
        [System.Text.Json.Serialization.JsonPropertyName("capitalDecreaseOfParValueDomesticWithCostAdjustments")]
        public System.Collections.Generic.ICollection<_0>? CapitalDecreaseOfParValueDomesticWithCostAdjustments { get; set; }= default!;
    
    
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