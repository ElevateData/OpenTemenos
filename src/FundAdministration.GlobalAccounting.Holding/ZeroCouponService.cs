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

namespace FundAdministration.GlobalAccounting.Holding.ZeroCoupons
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IZeroCouponService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates and update zero coupon bonds master record</summary>
        /// <param name="payload">createZeroCoupon Payload</param>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <returns>createZeroCoupon Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CreateZeroCouponSuccessResponse> CreateZeroCouponAsync(_0BULKPayload payload, string? referenceId = null, string? token = null, string? username = null, string? company = null, string? command = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    public partial class CreateZeroCouponSuccessheaderResponse 
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
    public partial class CreateZeroCouponrecordsSchema : System.Collections.ObjectModel.Collection<_0>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateZeroCouponSuccessbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public CreateZeroCouponrecordsSchema? Records { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateZeroCouponSuccessResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public CreateZeroCouponSuccessheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public CreateZeroCouponSuccessbodyResponse? Body { get; set; }= default!;
    
    
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
    public partial class CreateZeroCouponErrorheaderResponse 
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
    public partial class CreateZeroCouponErrorbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public System.Collections.Generic.ICollection<Items>? Items { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateZeroCouponErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public CreateZeroCouponErrorheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class _0 
    {
        /// <summary>Transaction Type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionType")]
        public string? TransactionType { get; set; }= default!;
    
        /// <summary>External security identification code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("instrumentId")]
        public string? InstrumentId { get; set; }= default!;
    
        /// <summary>Name</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityName")]
        public string? SecurityName { get; set; }= default!;
    
        /// <summary>Security long description</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityLongDescription")]
        public string? SecurityLongDescription { get; set; }= default!;
    
        /// <summary>This can be used to provide a Short description of the fields like security,Ctable,Account Group etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityShortDescription")]
        public string? SecurityShortDescription { get; set; }= default!;
    
        /// <summary>This is the reporting code tagged to an account.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("reportingCode")]
        public string? ReportingCode { get; set; }= default!;
    
        /// <summary>Locale type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("legalReportingAssetTypeCategory")]
        public string? LegalReportingAssetTypeCategory { get; set; }= default!;
    
        /// <summary>External system category</summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalInstrumentCategory")]
        public string? ExternalInstrumentCategory { get; set; }= default!;
    
        /// <summary>Security issued country code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }= default!;
    
        /// <summary>Branche code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("industryector")]
        public double? Industryector { get; set; }= default!;
    
        /// <summary>Security quotation place</summary>
        [System.Text.Json.Serialization.JsonPropertyName("quotationPlace")]
        public string? QuotationPlace { get; set; }= default!;
    
        /// <summary>Nominal of the Intrument</summary>
        [System.Text.Json.Serialization.JsonPropertyName("smallestTreatableSecurityUnit")]
        public double? SmallestTreatableSecurityUnit { get; set; }= default!;
    
        /// <summary>Price provider code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("providerCode")]
        public string? ProviderCode { get; set; }= default!;
    
        /// <summary>Security quotation currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("quotationCurrency")]
        public string? QuotationCurrency { get; set; }= default!;
    
        /// <summary>Frequency of payment of coupon/ commission</summary>
        [System.Text.Json.Serialization.JsonPropertyName("couponFrequency")]
        public string? CouponFrequency { get; set; }= default!;
    
        /// <summary>Issue Date of an instrument, like for Bonds</summary>
        [System.Text.Json.Serialization.JsonPropertyName("issueDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? IssueDate { get; set; }= default!;
    
        /// <summary>FirstCouponDate</summary>
        [System.Text.Json.Serialization.JsonPropertyName("couponDate")]
        public string? CouponDate { get; set; }= default!;
    
        /// <summary>Maturity Date of an instrument, like for Bonds</summary>
        [System.Text.Json.Serialization.JsonPropertyName("expiryDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ExpiryDate { get; set; }= default!;
    
        /// <summary>Interest calculation algorithm</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestCalculationAlgorithm")]
        public string? InterestCalculationAlgorithm { get; set; }= default!;
    
        /// <summary>Interest rate</summary>
        [System.Text.Json.Serialization.JsonPropertyName("couponRate")]
        public double? CouponRate { get; set; }= default!;
    
        /// <summary>Redemption price</summary>
        [System.Text.Json.Serialization.JsonPropertyName("redemptionPrice")]
        public double? RedemptionPrice { get; set; }= default!;
    
        /// <summary>IdentificationCodeDepositary</summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeOfIssuer")]
        public string? TypeOfIssuer { get; set; }= default!;
    
        /// <summary>Depositary</summary>
        [System.Text.Json.Serialization.JsonPropertyName("issuerOfSecurity")]
        public string? IssuerOfSecurity { get; set; }= default!;
    
        /// <summary>IdentificationCodeDepositaryGUA</summary>
        [System.Text.Json.Serialization.JsonPropertyName("idTypeOfProvider")]
        public string? IdTypeOfProvider { get; set; }= default!;
    
        /// <summary>DepositaryGUA</summary>
        [System.Text.Json.Serialization.JsonPropertyName("internalIdOfIssuer")]
        public string? InternalIdOfIssuer { get; set; }= default!;
    
        /// <summary>Security provider1 code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityProvider1Code")]
        public string? SecurityProvider1Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider1</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIdCodeAtProvider1")]
        public string? SecurityIdCodeAtProvider1 { get; set; }= default!;
    
        /// <summary>Security provider2 code2</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityProvider2Code")]
        public string? SecurityProvider2Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider2</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIdCodeAtProvider2")]
        public string? SecurityIdCodeAtProvider2 { get; set; }= default!;
    
        /// <summary>Security provider3 code3</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityProvider3Code")]
        public string? SecurityProvider3Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider3</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIdCodeAtProvider3")]
        public string? SecurityIdCodeAtProvider3 { get; set; }= default!;
    
        /// <summary>Security provider4 code4</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityProvider4Code")]
        public string? SecurityProvider4Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider4</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIdCodeAtProvider4")]
        public string? SecurityIdCodeAtProvider4 { get; set; }= default!;
    
        /// <summary>Security provider5 code5</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityProvider5Code")]
        public string? SecurityProvider5Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider5</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIdCodeAtProvider5")]
        public string? SecurityIdCodeAtProvider5 { get; set; }= default!;
    
        /// <summary>Language code2</summary>
        [System.Text.Json.Serialization.JsonPropertyName("languageCode2")]
        public string? LanguageCode2 { get; set; }= default!;
    
        /// <summary>Description in language 2</summary>
        [System.Text.Json.Serialization.JsonPropertyName("descriptionInLanguage2")]
        public string? DescriptionInLanguage2 { get; set; }= default!;
    
        /// <summary>Security provider6 code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityProvider6Code")]
        public string? SecurityProvider6Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider6</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIdCodeAtProvider6")]
        public string? SecurityIdCodeAtProvider6 { get; set; }= default!;
    
        /// <summary>Security provider7 code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityProvider7Code")]
        public string? SecurityProvider7Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider7</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIdCodeAtProvider7")]
        public string? SecurityIdCodeAtProvider7 { get; set; }= default!;
    
        /// <summary>Security provider8 code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityProvider8Code")]
        public string? SecurityProvider8Code { get; set; }= default!;
    
        /// <summary>Security Id code at provider8</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIdCodeAtProvider8")]
        public string? SecurityIdCodeAtProvider8 { get; set; }= default!;
    
        /// <summary>Status</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityStatusYForActiveAndNForInactive")]
        public string? SecurityStatusYForActiveAndNForInactive { get; set; }= default!;
    
        /// <summary>Issue price</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIssuePrice")]
        public double? SecurityIssuePrice { get; set; }= default!;
    
        /// <summary>Redemption currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("redemptionCurrency")]
        public string? RedemptionCurrency { get; set; }= default!;
    
        /// <summary>Income currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("incomeCurrencyIfOtherThanSecurityCurrency")]
        public string? IncomeCurrencyIfOtherThanSecurityCurrency { get; set; }= default!;
    
        /// <summary>Contract size</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractSize")]
        public double? ContractSize { get; set; }= default!;
    
        /// <summary>CHECK DATA</summary>
        [System.Text.Json.Serialization.JsonPropertyName("createOrUpdate")]
        public string? CreateOrUpdate { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Body 
    {
        [System.Text.Json.Serialization.JsonPropertyName("zeroCoupons")]
        public System.Collections.Generic.ICollection<_0>? ZeroCoupons { get; set; }= default!;
    
    
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