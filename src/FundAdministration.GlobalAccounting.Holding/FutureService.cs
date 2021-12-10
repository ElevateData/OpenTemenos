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

namespace FundAdministration.GlobalAccounting.Holding.Future
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IFutureService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates Future instrument master record</summary>
        /// <param name="payload">createFuture Payload</param>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <returns>createFuture Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CreateFutureSuccessResponse> CreateFutureAsync(_0BULKPayload payload, string? referenceId = null, string? token = null, string? username = null, string? company = null, string? command = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    public partial class CreateFutureSuccessheaderResponse 
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
    public partial class CreateFuturerecordsSchema : System.Collections.ObjectModel.Collection<_0>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateFutureSuccessbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public CreateFuturerecordsSchema? Records { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateFutureSuccessResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public CreateFutureSuccessheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public CreateFutureSuccessbodyResponse? Body { get; set; }= default!;
    
    
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
    public partial class CreateFutureErrorheaderResponse 
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
    public partial class CreateFutureErrorbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public System.Collections.Generic.ICollection<Items>? Items { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateFutureErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public CreateFutureErrorheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class _0 
    {
        /// <summary>Transaction type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionType")]
        public string? TransactionType { get; set; }= default!;
    
        /// <summary>External security identification number</summary>
        [System.Text.Json.Serialization.JsonPropertyName("instrumenID")]
        public string? InstrumenID { get; set; }= default!;
    
        /// <summary>This is the reporting code tagged to an account.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("reportingCode")]
        public string? ReportingCode { get; set; }= default!;
    
        /// <summary>Local Type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("underlyingAssetType")]
        public string? UnderlyingAssetType { get; set; }= default!;
    
        /// <summary>Asset type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("instrumentType")]
        public string? InstrumentType { get; set; }= default!;
    
        /// <summary>Quotation Place</summary>
        [System.Text.Json.Serialization.JsonPropertyName("primaryExchangeCode")]
        public string? PrimaryExchangeCode { get; set; }= default!;
    
        /// <summary>Price provider code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("providerCode")]
        public string? ProviderCode { get; set; }= default!;
    
        /// <summary>Quotation Currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityCurrency")]
        public string? SecurityCurrency { get; set; }= default!;
    
        /// <summary>Maturity Date of an instrument, like for Bonds</summary>
        [System.Text.Json.Serialization.JsonPropertyName("expiryDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ExpiryDate { get; set; }= default!;
    
        /// <summary>Type of Issuer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalIdentificationCode")]
        public string? ExternalIdentificationCode { get; set; }= default!;
    
        /// <summary>Issuer of security</summary>
        [System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }= default!;
    
        /// <summary>Security provider1 code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("sedol")]
        public string? Sedol { get; set; }= default!;
    
        /// <summary>Security Id code at provider1</summary>
        [System.Text.Json.Serialization.JsonPropertyName("sedolId")]
        public string? SedolId { get; set; }= default!;
    
        /// <summary>Security provider2 code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("isin")]
        public string? Isin { get; set; }= default!;
    
        /// <summary>Security Id code at provider2</summary>
        [System.Text.Json.Serialization.JsonPropertyName("isinId")]
        public string? IsinId { get; set; }= default!;
    
        /// <summary>Security provider3 code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("cusip")]
        public string? Cusip { get; set; }= default!;
    
        /// <summary>Security Id code at provider3</summary>
        [System.Text.Json.Serialization.JsonPropertyName("cusipID")]
        public string? CusipID { get; set; }= default!;
    
        /// <summary>Security provider4 code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bloomberg")]
        public string? Bloomberg { get; set; }= default!;
    
        /// <summary>Security Id code at provider4</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bloombergId")]
        public string? BloombergId { get; set; }= default!;
    
        /// <summary>Security provider5 code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("wertpapier")]
        public string? Wertpapier { get; set; }= default!;
    
        /// <summary>Security Id code at provider5</summary>
        [System.Text.Json.Serialization.JsonPropertyName("wertpapierID")]
        public string? WertpapierID { get; set; }= default!;
    
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
    
        /// <summary>Number of contracts to take in consideration. Fot future, the default value is 1</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractSize")]
        public double? ContractSize { get; set; }= default!;
    
        /// <summary>Underlying security provider 1</summary>
        [System.Text.Json.Serialization.JsonPropertyName("providerCodeOfUnderlyingId")]
        public string? ProviderCodeOfUnderlyingId { get; set; }= default!;
    
        /// <summary>Underlying security Id at underlying provider 1</summary>
        [System.Text.Json.Serialization.JsonPropertyName("underlyingSecurityId")]
        public string? UnderlyingSecurityId { get; set; }= default!;
    
        /// <summary>Type OF security</summary>
        [System.Text.Json.Serialization.JsonPropertyName("derivativeTypeForO")]
        public string? DerivativeTypeForO { get; set; }= default!;
    
        /// <summary>Type of underlying Security</summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeOfUnderlyingInstrument")]
        public string? TypeOfUnderlyingInstrument { get; set; }= default!;
    
        /// <summary>Style of option or future</summary>
        [System.Text.Json.Serialization.JsonPropertyName("optionStyle")]
        public string? OptionStyle { get; set; }= default!;
    
        /// <summary>If N do not perform checks on mandatory fields or equivalence and decision table</summary>
        [System.Text.Json.Serialization.JsonPropertyName("createOrUpdate")]
        public string? CreateOrUpdate { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Body 
    {
        [System.Text.Json.Serialization.JsonPropertyName("futures")]
        public System.Collections.Generic.ICollection<_0>? Futures { get; set; }= default!;
    
    
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