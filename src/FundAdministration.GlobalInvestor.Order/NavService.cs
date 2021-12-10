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

namespace FundAdministration.GlobalInvestor.Order.Navs
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface INavService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates Share Prices</summary>
        /// <param name="payload">postSharePrice Payload</param>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <returns>postSharePrice Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PostSharePriceSuccessResponse> PostSharePriceAsync(_0BULKPayload payload, string? referenceId = null, string? token = null, string? username = null, string? company = null, string? command = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    public partial class PostSharePriceSuccessheaderResponse 
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
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostSharePricerecordsSchema : System.Collections.ObjectModel.Collection<_0>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostSharePriceSuccessbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public PostSharePricerecordsSchema? Records { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostSharePriceSuccessResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public PostSharePriceSuccessheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public PostSharePriceSuccessbodyResponse? Body { get; set; }= default!;
    
    
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
        public System.Collections.Generic.ICollection<Details>? Details { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostSharePriceErrorheaderResponse 
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
    public partial class PostSharePriceErrorbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public System.Collections.Generic.ICollection<Items>? Items { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostSharePriceErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public PostSharePriceErrorheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class _0 
    {
        /// <summary>Record Indicator</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordIndicator")]
        public string? RecordIndicator { get; set; }= default!;
    
        /// <summary>Fund ID</summary>
        [System.Text.Json.Serialization.JsonPropertyName("taFundCode")]
        public string? TaFundCode { get; set; }= default!;
    
        /// <summary>Share class</summary>
        [System.Text.Json.Serialization.JsonPropertyName("shareClassCode")]
        public string? ShareClassCode { get; set; }= default!;
    
        /// <summary>externalSecurityIDCodeType</summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalSecurityIDCodeType")]
        public string? ExternalSecurityIDCodeType { get; set; }= default!;
    
        /// <summary>externalSecurityIDCode</summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalSecurityIDCode")]
        public string? ExternalSecurityIDCode { get; set; }= default!;
    
        /// <summary>quotationCurrency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("quotationCurrency")]
        public string? QuotationCurrency { get; set; }= default!;
    
        /// <summary>NAV date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("navDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? NavDate { get; set; }= default!;
    
        /// <summary>Share price</summary>
        [System.Text.Json.Serialization.JsonPropertyName("sharePrice")]
        public double? SharePrice { get; set; }= default!;
    
        /// <summary>Share price subscription</summary>
        [System.Text.Json.Serialization.JsonPropertyName("subscriptionPrice")]
        public double? SubscriptionPrice { get; set; }= default!;
    
        /// <summary>Share price redemption</summary>
        [System.Text.Json.Serialization.JsonPropertyName("redemptionPrice")]
        public double? RedemptionPrice { get; set; }= default!;
    
        /// <summary>RNI share</summary>
        [System.Text.Json.Serialization.JsonPropertyName("RNI")]
        public double? RNI { get; set; }= default!;
    
        /// <summary>Interim profit (German tax)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interimProfitGermanTax")]
        public double? InterimProfitGermanTax { get; set; }= default!;
    
        /// <summary>Capital gain Share</summary>
        [System.Text.Json.Serialization.JsonPropertyName("capitalGain")]
        public double? CapitalGain { get; set; }= default!;
    
        /// <summary>Real NAV date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("realNavDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? RealNavDate { get; set; }= default!;
    
        /// <summary>blockedNAVFlag</summary>
        [System.Text.Json.Serialization.JsonPropertyName("blockedNAVFlag")]
        public string? BlockedNAVFlag { get; set; }= default!;
    
        /// <summary>Daily dividend</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dailyDividendRate")]
        public double? DailyDividendRate { get; set; }= default!;
    
        /// <summary>TISR</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TISR")]
        public double? TISR { get; set; }= default!;
    
        /// <summary>Equity profit/gain (German tax)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("equityProfitGain1GermanTax")]
        public double? EquityProfitGain1GermanTax { get; set; }= default!;
    
        /// <summary>TIS1</summary>
        [System.Text.Json.Serialization.JsonPropertyName("swissTIS")]
        public double? SwissTIS { get; set; }= default!;
    
        /// <summary>Gross NAV</summary>
        [System.Text.Json.Serialization.JsonPropertyName("grossNAV")]
        public double? GrossNAV { get; set; }= default!;
    
        /// <summary>Reference NAV</summary>
        [System.Text.Json.Serialization.JsonPropertyName("referenceNAV")]
        public double? ReferenceNAV { get; set; }= default!;
    
        /// <summary>Individual equalization rate</summary>
        [System.Text.Json.Serialization.JsonPropertyName("individualEqualizationRate")]
        public double? IndividualEqualizationRate { get; set; }= default!;
    
        /// <summary>Swung price</summary>
        [System.Text.Json.Serialization.JsonPropertyName("flagSwungPrice")]
        public string? FlagSwungPrice { get; set; }= default!;
    
        /// <summary>seriesDate</summary>
        [System.Text.Json.Serialization.JsonPropertyName("seriesDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? SeriesDate { get; set; }= default!;
    
        /// <summary>Management fees</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dailyTotalCost")]
        public double? DailyTotalCost { get; set; }= default!;
    
        /// <summary>Gav per share</summary>
        [System.Text.Json.Serialization.JsonPropertyName("GAVPerShare")]
        public double? GAVPerShare { get; set; }= default!;
    
        /// <summary>Total GAV</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalGAV")]
        public double? TotalGAV { get; set; }= default!;
    
        /// <summary>Other fees</summary>
        [System.Text.Json.Serialization.JsonPropertyName("otherCosts")]
        public double? OtherCosts { get; set; }= default!;
    
        /// <summary>PFCalculationStatus</summary>
        [System.Text.Json.Serialization.JsonPropertyName("PFCalculationStatus")]
        public string? PFCalculationStatus { get; set; }= default!;
    
        /// <summary>Equity profit/gain II (German tax)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("equityProfitGain2GermanTax")]
        public double? EquityProfitGain2GermanTax { get; set; }= default!;
    
        /// <summary>New issues eligible shares P&amp;L</summary>
        [System.Text.Json.Serialization.JsonPropertyName("newIssuesOfSharesPL")]
        public double? NewIssuesOfSharesPL { get; set; }= default!;
    
        /// <summary>Ex-div</summary>
        [System.Text.Json.Serialization.JsonPropertyName("exDividendFlag")]
        public string? ExDividendFlag { get; set; }= default!;
    
        /// <summary>Total TI</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalTaxableIncome")]
        public double? TotalTaxableIncome { get; set; }= default!;
    
        /// <summary>Sav. directive</summary>
        [System.Text.Json.Serialization.JsonPropertyName("csavDirective")]
        public string? CsavDirective { get; set; }= default!;
    
        /// <summary>Shares outstanding</summary>
        [System.Text.Json.Serialization.JsonPropertyName("outstandingUnits")]
        public double? OutstandingUnits { get; set; }= default!;
    
        /// <summary>updFeeflag</summary>
        [System.Text.Json.Serialization.JsonPropertyName("updFee")]
        public string? UpdFee { get; set; }= default!;
    
        /// <summary>Estimated NAV</summary>
        [System.Text.Json.Serialization.JsonPropertyName("estimatedNAV")]
        public string? EstimatedNAV { get; set; }= default!;
    
        /// <summary>TISD</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TISD")]
        public double? TISD { get; set; }= default!;
    
        /// <summary>Agreement profit (German tax)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("Immobilliengewinn")]
        public double? Immobilliengewinn { get; set; }= default!;
    
        /// <summary>Asset test1</summary>
        [System.Text.Json.Serialization.JsonPropertyName("assetTest1")]
        public double? AssetTest1 { get; set; }= default!;
    
        /// <summary>TIS2</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TIS2")]
        public double? TIS2 { get; set; }= default!;
    
        /// <summary>Asset test2</summary>
        [System.Text.Json.Serialization.JsonPropertyName("assetTest2")]
        public double? AssetTest2 { get; set; }= default!;
    
        /// <summary>TIS3</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TIS3")]
        public double? TIS3 { get; set; }= default!;
    
        /// <summary>Asset test3</summary>
        [System.Text.Json.Serialization.JsonPropertyName("assetTest3")]
        public double? AssetTest3 { get; set; }= default!;
    
        /// <summary>TIS4</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TIS4")]
        public double? TIS4 { get; set; }= default!;
    
        /// <summary>Asset test4</summary>
        [System.Text.Json.Serialization.JsonPropertyName("assetTest4")]
        public double? AssetTest4 { get; set; }= default!;
    
        /// <summary>TIS5</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TIS5")]
        public double? TIS5 { get; set; }= default!;
    
        /// <summary>Asset test5</summary>
        [System.Text.Json.Serialization.JsonPropertyName("assetTest5")]
        public double? AssetTest5 { get; set; }= default!;
    
        /// <summary>TIS6</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TIS6")]
        public double? TIS6 { get; set; }= default!;
    
        /// <summary>Asset test6</summary>
        [System.Text.Json.Serialization.JsonPropertyName("assetTest6")]
        public double? AssetTest6 { get; set; }= default!;
    
        /// <summary>TIS7</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TIS7")]
        public double? TIS7 { get; set; }= default!;
    
        /// <summary>Asset test7</summary>
        [System.Text.Json.Serialization.JsonPropertyName("assetTest7")]
        public double? AssetTest7 { get; set; }= default!;
    
        /// <summary>TIS8</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TIS8")]
        public double? TIS8 { get; set; }= default!;
    
        /// <summary>Asset test8</summary>
        [System.Text.Json.Serialization.JsonPropertyName("assetTest8")]
        public double? AssetTest8 { get; set; }= default!;
    
        /// <summary>TIS9</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TIS9")]
        public double? TIS9 { get; set; }= default!;
    
        /// <summary>Asset test9</summary>
        [System.Text.Json.Serialization.JsonPropertyName("assetTest9")]
        public double? AssetTest9 { get; set; }= default!;
    
        /// <summary>Asset test (German tax)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("assetTestGt")]
        public double? AssetTestGt { get; set; }= default!;
    
        /// <summary>TG1 PV (German tax)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TG1")]
        public double? TG1 { get; set; }= default!;
    
        /// <summary>TG2 BV ESTG (German tax)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TG2")]
        public double? TG2 { get; set; }= default!;
    
        /// <summary>TG3 BV KSTG (German tax)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("TG3")]
        public double? TG3 { get; set; }= default!;
    
        /// <summary>AMF%</summary>
        [System.Text.Json.Serialization.JsonPropertyName("amf")]
        public double? Amf { get; set; }= default!;
    
        /// <summary>TER%</summary>
        [System.Text.Json.Serialization.JsonPropertyName("ter")]
        public double? Ter { get; set; }= default!;
    
        /// <summary>DF%</summary>
        [System.Text.Json.Serialization.JsonPropertyName("df")]
        public double? Df { get; set; }= default!;
    
        /// <summary>OF1%</summary>
        [System.Text.Json.Serialization.JsonPropertyName("of1")]
        public double? Of1 { get; set; }= default!;
    
        /// <summary>OF2%</summary>
        [System.Text.Json.Serialization.JsonPropertyName("of2")]
        public double? Of2 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Body 
    {
        [System.Text.Json.Serialization.JsonPropertyName("navs")]
        public System.Collections.Generic.ICollection<_0>? Navs { get; set; }= default!;
    
    
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