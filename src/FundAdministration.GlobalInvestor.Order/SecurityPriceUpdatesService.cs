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

namespace FundAdministration.GlobalInvestor.Order.SecurityPriceUpdates
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface ISecurityPriceUpdatesService
    {
        /// <summary>Creates Market Values Historicals</summary>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <param name="payload">postsecuritypriceupdates Payload</param>
        /// <returns>postsecuritypriceupdates Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PostsecuritypriceupdatesSuccessResponse> PostsecuritypriceupdatesAsync(string? referenceId, string? token, string? username, string? company, string? command, _0BULKPayload payload);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates Market Values Historicals</summary>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <param name="payload">postsecuritypriceupdates Payload</param>
        /// <returns>postsecuritypriceupdates Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PostsecuritypriceupdatesSuccessResponse> PostsecuritypriceupdatesAsync(string? referenceId, string? token, string? username, string? company, string? command, _0BULKPayload payload, System.Threading.CancellationToken cancellationToken);
    
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
    public partial class PostsecuritypriceupdatesSuccessheaderResponse 
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
    public partial class PostsecuritypriceupdatesrecordsSchema : System.Collections.ObjectModel.Collection<_0>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostsecuritypriceupdatesSuccessbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public PostsecuritypriceupdatesrecordsSchema? Records { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostsecuritypriceupdatesSuccessResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public PostsecuritypriceupdatesSuccessheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public PostsecuritypriceupdatesSuccessbodyResponse? Body { get; set; }= default!;
    
    
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
    public partial class PostsecuritypriceupdatesErrorheaderResponse 
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
    public partial class PostsecuritypriceupdatesErrorbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public System.Collections.Generic.ICollection<Items>? Items { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostsecuritypriceupdatesErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public PostsecuritypriceupdatesErrorheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class _0 
    {
        /// <summary>It specifies the type of record that is loaded</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordIndicator")]
        public string? RecordIndicator { get; set; }= default!;
    
        /// <summary>Internal ID of the Security. Allowed values are from the Security IDs created in MFGI.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("internalSecurityNumber")]
        public double? InternalSecurityNumber { get; set; }= default!;
    
        /// <summary>Accounting date (if Null then taken from FUND/PARM)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountingDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? AccountingDate { get; set; }= default!;
    
        /// <summary>Reference NAV price of the security</summary>
        [System.Text.Json.Serialization.JsonPropertyName("marketValue")]
        public string? MarketValue { get; set; }= default!;
    
        /// <summary>High Water Mark Price of the security</summary>
        [System.Text.Json.Serialization.JsonPropertyName("HWMPrice")]
        public string? HWMPrice { get; set; }= default!;
    
        /// <summary>Bench Mark Price of the security</summary>
        [System.Text.Json.Serialization.JsonPropertyName("BMKPrice")]
        public string? BMKPrice { get; set; }= default!;
    
        /// <summary>Hurdle Adjusted High water mark Price of the security</summary>
        [System.Text.Json.Serialization.JsonPropertyName("hurdleAdjustedHWMPrice")]
        public string? HurdleAdjustedHWMPrice { get; set; }= default!;
    
        /// <summary>Hurdle Rate of the security</summary>
        [System.Text.Json.Serialization.JsonPropertyName("hurdleRate")]
        public string? HurdleRate { get; set; }= default!;
    
        /// <summary>External ID provider.  For Example: 00 - External Depositary Reference, 01 - Telekurs, 03 - SEDOL, etc.LOV is available from CMESS table TYP_IDVAL</summary>
        [System.Text.Json.Serialization.JsonPropertyName("IDCode")]
        public string? IDCode { get; set; }= default!;
    
        /// <summary>Internal ID of the Security. Allowed values are from the Security IDs created in MFGI.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityId")]
        public string? SecurityId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Body 
    {
        [System.Text.Json.Serialization.JsonPropertyName("marketValuesHistoricals")]
        public System.Collections.Generic.ICollection<_0>? MarketValuesHistoricals { get; set; }= default!;
    
    
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