//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

using OpenTemenos.Shared.Models;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"

namespace OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FixedBonds
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IFixedBondService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates fixed bonds master record</summary>
        /// <param name="payload">createFixedBond Payload</param>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <returns>createFixedBond Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CreateFixedBondSuccessResponse> CreateFixedBondAsync(_0BULKPayload payload, string? referenceId = null, string? token = null, string? username = null, string? company = null, string? command = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class _0BULKPayload 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Body? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PaginationSchema 
    {
        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Page { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Size { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Count { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Total { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AuditSchema 
    {
        [Newtonsoft.Json.JsonProperty("startTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StartTime { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("endTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EndTime { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("processTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProcessTime { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SuccessHeaderstatusSchema 
    {
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Result { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("HTTP_MESSAGE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HTTP_MESSAGE { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Description { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Message { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("HTTP_CODE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HTTP_CODE { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestId { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("responseId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ResponseId { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("eTag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ETag { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("lastModified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LastModified { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CreateFixedBondSuccessheaderResponse 
    {
        [Newtonsoft.Json.JsonProperty("pagination", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaginationSchema? Pagination { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("audit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AuditSchema? Audit { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SuccessHeaderstatusSchema? Status { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("company", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Company { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("username", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Username { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("referenceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReferenceId { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Token { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("details", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Details>? Details { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CreateFixedBondrecordsSchema : System.Collections.ObjectModel.Collection<_0>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CreateFixedBondSuccessbodyResponse 
    {
        [Newtonsoft.Json.JsonProperty("records", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CreateFixedBondrecordsSchema? Records { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CreateFixedBondSuccessResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CreateFixedBondSuccessheaderResponse? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CreateFixedBondSuccessbodyResponse? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ErrorHeaderstatusSchema 
    {
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Result { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("HTTP_MESSAGE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HTTP_MESSAGE { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Description { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Message { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("HTTP_CODE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HTTP_CODE { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestId { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("responseId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ResponseId { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("eTag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ETag { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("lastModified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LastModified { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("details", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Details2>? Details { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CreateFixedBondErrorheaderResponse 
    {
        [Newtonsoft.Json.JsonProperty("pagination", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaginationSchema? Pagination { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("audit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AuditSchema? Audit { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ErrorHeaderstatusSchema? Status { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("referenceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReferenceId { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Token { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("username", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Username { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CreateFixedBondErrorbodyResponse 
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Items>? Items { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CreateFixedBondErrorResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CreateFixedBondErrorheaderResponse? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class _0 
    {
        /// <summary>Transaction Type</summary>
        [Newtonsoft.Json.JsonProperty("transactionType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TransactionType { get; set; }= default!;
    
        /// <summary>External security identification code</summary>
        [Newtonsoft.Json.JsonProperty("instrumentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstrumentId { get; set; }= default!;
    
        /// <summary>Name</summary>
        [Newtonsoft.Json.JsonProperty("securityName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityName { get; set; }= default!;
    
        /// <summary>Security long description</summary>
        [Newtonsoft.Json.JsonProperty("securityLongDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityLongDescription { get; set; }= default!;
    
        /// <summary>This can be used to provide a Short description of the fields like security,Ctable,Account Group etc.</summary>
        [Newtonsoft.Json.JsonProperty("securityShortDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityShortDescription { get; set; }= default!;
    
        /// <summary>This is the reporting code tagged to an account.</summary>
        [Newtonsoft.Json.JsonProperty("reportingCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReportingCode { get; set; }= default!;
    
        /// <summary>Locale type</summary>
        [Newtonsoft.Json.JsonProperty("legalReportingAssetTypeCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LegalReportingAssetTypeCategory { get; set; }= default!;
    
        /// <summary>External system category</summary>
        [Newtonsoft.Json.JsonProperty("externalInstrumentCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExternalInstrumentCategory { get; set; }= default!;
    
        /// <summary>Security issued country code</summary>
        [Newtonsoft.Json.JsonProperty("countryCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CountryCode { get; set; }= default!;
    
        /// <summary>Branche code</summary>
        [Newtonsoft.Json.JsonProperty("industryector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Industryector { get; set; }= default!;
    
        /// <summary>Security quotation place</summary>
        [Newtonsoft.Json.JsonProperty("quotationPlace", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? QuotationPlace { get; set; }= default!;
    
        /// <summary>Nominal of the Intrument</summary>
        [Newtonsoft.Json.JsonProperty("smallestTreatableSecurityUnit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SmallestTreatableSecurityUnit { get; set; }= default!;
    
        /// <summary>Price provider code</summary>
        [Newtonsoft.Json.JsonProperty("providerCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProviderCode { get; set; }= default!;
    
        /// <summary>Security quotation currency</summary>
        [Newtonsoft.Json.JsonProperty("quotationCurrency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? QuotationCurrency { get; set; }= default!;
    
        /// <summary>Frequency of payment of coupon/ commission</summary>
        [Newtonsoft.Json.JsonProperty("couponFrequency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CouponFrequency { get; set; }= default!;
    
        /// <summary>Issue Date of an instrument, like for Bonds</summary>
        [Newtonsoft.Json.JsonProperty("issueDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? IssueDate { get; set; }= default!;
    
        /// <summary>FirstCouponDate</summary>
        [Newtonsoft.Json.JsonProperty("couponDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CouponDate { get; set; }= default!;
    
        /// <summary>Reflects the Irregular next Interest period END date</summary>
        [Newtonsoft.Json.JsonProperty("forFrnSecuritiesThisDateWillBeTheEndOfThePeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ForFrnSecuritiesThisDateWillBeTheEndOfThePeriod { get; set; }= default!;
    
        /// <summary>Total amount of the issue. Used for investment restrictions control.</summary>
        [Newtonsoft.Json.JsonProperty("issueCapital", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IssueCapital { get; set; }= default!;
    
        /// <summary>Maturity Date of an instrument, like for Bonds</summary>
        [Newtonsoft.Json.JsonProperty("expiryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ExpiryDate { get; set; }= default!;
    
        /// <summary>Interest calculation algorithm</summary>
        [Newtonsoft.Json.JsonProperty("interestCalculationAlgorithm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestCalculationAlgorithm { get; set; }= default!;
    
        /// <summary>Interest rate</summary>
        [Newtonsoft.Json.JsonProperty("couponRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CouponRate { get; set; }= default!;
    
        /// <summary>Redemption price</summary>
        [Newtonsoft.Json.JsonProperty("redemptionPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RedemptionPrice { get; set; }= default!;
    
        /// <summary>IdentificationCodeDepositary</summary>
        [Newtonsoft.Json.JsonProperty("typeOfIssuer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TypeOfIssuer { get; set; }= default!;
    
        /// <summary>Depositary</summary>
        [Newtonsoft.Json.JsonProperty("issuerOfSecurity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IssuerOfSecurity { get; set; }= default!;
    
        /// <summary>IdentificationCodeDepositaryGUA</summary>
        [Newtonsoft.Json.JsonProperty("idTypeOfProvider", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IdTypeOfProvider { get; set; }= default!;
    
        /// <summary>DepositaryGUA</summary>
        [Newtonsoft.Json.JsonProperty("internalIdOfIssuer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InternalIdOfIssuer { get; set; }= default!;
    
        /// <summary>Security provider1 code</summary>
        [Newtonsoft.Json.JsonProperty("securityProvider1Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityProvider1Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider1</summary>
        [Newtonsoft.Json.JsonProperty("securityIdCodeAtProvider1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityIdCodeAtProvider1 { get; set; }= default!;
    
        /// <summary>Security provider2 code2</summary>
        [Newtonsoft.Json.JsonProperty("securityProvider2Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityProvider2Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider2</summary>
        [Newtonsoft.Json.JsonProperty("securityIdCodeAtProvider2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityIdCodeAtProvider2 { get; set; }= default!;
    
        /// <summary>Security provider3 code3</summary>
        [Newtonsoft.Json.JsonProperty("securityProvider3Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityProvider3Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider3</summary>
        [Newtonsoft.Json.JsonProperty("securityIdCodeAtProvider3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityIdCodeAtProvider3 { get; set; }= default!;
    
        /// <summary>Security provider4 code4</summary>
        [Newtonsoft.Json.JsonProperty("securityProvider4Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityProvider4Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider4</summary>
        [Newtonsoft.Json.JsonProperty("securityIdCodeAtProvider4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityIdCodeAtProvider4 { get; set; }= default!;
    
        /// <summary>Security provider5 code5</summary>
        [Newtonsoft.Json.JsonProperty("securityProvider5Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityProvider5Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider5</summary>
        [Newtonsoft.Json.JsonProperty("securityIdCodeAtProvider5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityIdCodeAtProvider5 { get; set; }= default!;
    
        /// <summary>Language code2</summary>
        [Newtonsoft.Json.JsonProperty("languageCode2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LanguageCode2 { get; set; }= default!;
    
        /// <summary>Description in language 2</summary>
        [Newtonsoft.Json.JsonProperty("descriptionInLanguage2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DescriptionInLanguage2 { get; set; }= default!;
    
        /// <summary>Security provider6 code</summary>
        [Newtonsoft.Json.JsonProperty("securityProvider6Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityProvider6Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider6</summary>
        [Newtonsoft.Json.JsonProperty("securityIdCodeAtProvider6", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityIdCodeAtProvider6 { get; set; }= default!;
    
        /// <summary>Security provider7 code</summary>
        [Newtonsoft.Json.JsonProperty("securityProvider7Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityProvider7Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider7</summary>
        [Newtonsoft.Json.JsonProperty("securityIdCodeAtProvider7", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityIdCodeAtProvider7 { get; set; }= default!;
    
        /// <summary>Security provider8 code</summary>
        [Newtonsoft.Json.JsonProperty("securityProvider8Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityProvider8Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider8</summary>
        [Newtonsoft.Json.JsonProperty("securityIdCodeAtProvider8", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityIdCodeAtProvider8 { get; set; }= default!;
    
        /// <summary>Status</summary>
        [Newtonsoft.Json.JsonProperty("securityStatusYForActiveAndNForInactive", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityStatusYForActiveAndNForInactive { get; set; }= default!;
    
        /// <summary>Int. begin date</summary>
        [Newtonsoft.Json.JsonProperty("interestBeginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? InterestBeginDate { get; set; }= default!;
    
        /// <summary>Issue price</summary>
        [Newtonsoft.Json.JsonProperty("securityIssuePrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SecurityIssuePrice { get; set; }= default!;
    
        /// <summary>Redemption currency</summary>
        [Newtonsoft.Json.JsonProperty("redemptionCurrency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RedemptionCurrency { get; set; }= default!;
    
        /// <summary>Income currency</summary>
        [Newtonsoft.Json.JsonProperty("incomeCurrencyIfOtherThanSecurityCurrency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IncomeCurrencyIfOtherThanSecurityCurrency { get; set; }= default!;
    
        /// <summary>Reflects the Irregular Interest period begin date</summary>
        [Newtonsoft.Json.JsonProperty("irregularPeriodBeginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? IrregularPeriodBeginDate { get; set; }= default!;
    
        /// <summary>Contract size</summary>
        [Newtonsoft.Json.JsonProperty("contractSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContractSize { get; set; }= default!;
    
        /// <summary>cleanOrDirtyPrice</summary>
        [Newtonsoft.Json.JsonProperty("cleanOrDirtyPriceOnlyIfIncomeTypeLessThan1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CleanOrDirtyPriceOnlyIfIncomeTypeLessThan1 { get; set; }= default!;
    
        /// <summary>Convertibility start date</summary>
        [Newtonsoft.Json.JsonProperty("convertibilityStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ConvertibilityStartDate { get; set; }= default!;
    
        /// <summary>Convertibility end date</summary>
        [Newtonsoft.Json.JsonProperty("convertibilityEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ConvertibilityEndDate { get; set; }= default!;
    
        /// <summary>Security number to be converted</summary>
        [Newtonsoft.Json.JsonProperty("securityNumberToBeConverted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SecurityNumberToBeConverted { get; set; }= default!;
    
        /// <summary>Convertibility date: Related to step up bonds, convertibility date has to be defined with the switch date of the interest from zero/low coupon to the higher coupon.</summary>
        [Newtonsoft.Json.JsonProperty("convertibilityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ConvertibilityDate { get; set; }= default!;
    
        /// <summary>Allows review and update of the ex-coupon dates for the interest receivable.</summary>
        [Newtonsoft.Json.JsonProperty("securityExCouponDateFlag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecurityExCouponDateFlag { get; set; }= default!;
    
        /// <summary>Security coupon date</summary>
        [Newtonsoft.Json.JsonProperty("flagYOrNToCalculateOrNotTheAverageEoniaRatesInCaseOfBenchmarkSecurityAndSecuritiesWithIncomeSmoothing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FlagYOrNToCalculateOrNotTheAverageEoniaRatesInCaseOfBenchmarkSecurityAndSecuritiesWithIncomeSmoothing { get; set; }= default!;
    
        /// <summary>CHECK DATA</summary>
        [Newtonsoft.Json.JsonProperty("createOrUpdate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CreateOrUpdate { get; set; }= default!;
    
        /// <summary>Accrual convention for income securities which enable the management of week-ends and holidays for the determination of the coupon amount and interest's accruals</summary>
        [Newtonsoft.Json.JsonProperty("accrualConvention", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AccrualConvention { get; set; }= default!;
    
        /// <summary>Helps in definining how manage the coupon payment on holiday</summary>
        [Newtonsoft.Json.JsonProperty("couponGeneration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CouponGeneration { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Body 
    {
        [Newtonsoft.Json.JsonProperty("fixedBonds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<_0>? FixedBonds { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Details 
    {
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Code { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Message { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Details2 
    {
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Code { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Message { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Items 
    {
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Code { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Message { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
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