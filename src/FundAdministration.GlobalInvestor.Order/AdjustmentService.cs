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

namespace OpenTemenos.FundAdministrations.GlobalInvestor.Order.Adjustments
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IAdjustmentService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates Underlying Reg. Adjustments</summary>
        /// <param name="payload">postadjustments Payload</param>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <returns>postadjustments Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PostadjustmentsSuccessResponse> PostadjustmentsAsync(_0BULKPayload payload, string? referenceId = null, string? token = null, string? username = null, string? company = null, string? command = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    public partial class PostadjustmentsSuccessheaderResponse 
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
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PostadjustmentsrecordsSchema : System.Collections.ObjectModel.Collection<_0>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PostadjustmentsSuccessbodyResponse 
    {
        [Newtonsoft.Json.JsonProperty("records", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PostadjustmentsrecordsSchema? Records { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PostadjustmentsSuccessResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PostadjustmentsSuccessheaderResponse? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PostadjustmentsSuccessbodyResponse? Body { get; set; }= default!;
    
    
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
        public System.Collections.Generic.ICollection<Details>? Details { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PostadjustmentsErrorheaderResponse 
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
    public partial class PostadjustmentsErrorbodyResponse 
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Items>? Items { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PostadjustmentsErrorResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PostadjustmentsErrorheaderResponse? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class _0 
    {
        /// <summary>It specifies the type of record that is loaded</summary>
        [Newtonsoft.Json.JsonProperty("recordIndicator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RecordIndicator { get; set; }= default!;
    
        /// <summary>It specifies the chronological system generated Adjustment order number. </summary>
        [Newtonsoft.Json.JsonProperty("adjustmentOrderNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AdjustmentOrderNumber { get; set; }= default!;
    
        /// <summary>It specifies the external order identifier for which the order is being placed. This is taken from the interface file</summary>
        [Newtonsoft.Json.JsonProperty("externalOrderReference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExternalOrderReference { get; set; }= default!;
    
        /// <summary>Register ID through which the Underlying register adjustment order is being placed. Allowed values are from the list of Registers created in MFGI for which the user has rights</summary>
        [Newtonsoft.Json.JsonProperty("internalRegisterNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InternalRegisterNumber { get; set; }= default!;
    
        /// <summary>Register ID from which the units are being transferred out. Allowed values are registers from the list of Register IDs based on respective Global and Bearer structure</summary>
        [Newtonsoft.Json.JsonProperty("registerOutID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RegisterOutID { get; set; }= default!;
    
        /// <summary>Register ID from which the units are being transferred In. Allowed values are registers from the list of Regsiter IDs based on respective Global and Bearer structure</summary>
        [Newtonsoft.Json.JsonProperty("registerInID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RegisterInID { get; set; }= default!;
    
        /// <summary>TA Fund ID for which the order is being placed. Allowed values are from the list of TA funds created in MFGI for which the user has rights</summary>
        [Newtonsoft.Json.JsonProperty("fundID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundID { get; set; }= default!;
    
        /// <summary>Share class code for which the order is being placed. Allowed values are from the list of share classes linked to the Fund</summary>
        [Newtonsoft.Json.JsonProperty("shareType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ShareType { get; set; }= default!;
    
        /// <summary>Quantity</summary>
        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Quantity { get; set; }= default!;
    
        /// <summary>Flag to specify if the order can be confirmed autimatically upon creation. Allowed values : Y (to enable), N (to disable), Null (=N)</summary>
        [Newtonsoft.Json.JsonProperty("flagConfirmed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FlagConfirmed { get; set; }= default!;
    
        /// <summary>TradeDate</summary>
        [Newtonsoft.Json.JsonProperty("tradeDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? TradeDate { get; set; }= default!;
    
        /// <summary>It specifies the external register identifier through which the Underlying register adjustment order is being placed. This is taken from the interface file</summary>
        [Newtonsoft.Json.JsonProperty("externalRegisterNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExternalRegisterNumber { get; set; }= default!;
    
        /// <summary>It specifies the transfer out register external register identifier . This is taken from the interface file</summary>
        [Newtonsoft.Json.JsonProperty("registerExternOutID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RegisterExternOutID { get; set; }= default!;
    
        /// <summary>It specifies the transfer In register external register identifier . This is taken from the interface file</summary>
        [Newtonsoft.Json.JsonProperty("registerExternInID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RegisterExternInID { get; set; }= default!;
    
        /// <summary>It specifies the type of Security external identifier.</summary>
        [Newtonsoft.Json.JsonProperty("externalSecurityIDCodeType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExternalSecurityIDCodeType { get; set; }= default!;
    
        /// <summary>It specifies the External identifier for security in interfaced orders.</summary>
        [Newtonsoft.Json.JsonProperty("externalSecurityIDCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExternalSecurityIDCode { get; set; }= default!;
    
        /// <summary>The currency in which the payments related to this transaction will be processed (in 3 letter ISO code, Eg: EUR). The LoV is available in Cmess table MONNAIES</summary>
        [Newtonsoft.Json.JsonProperty("paymentCurrency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentCurrency { get; set; }= default!;
    
        /// <summary>The mode in which the order is received. For example : 0001 - Telephone, 0002 - Fax. The LoV is available in Cmess table TA_ORDREC.</summary>
        [Newtonsoft.Json.JsonProperty("receptionMode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReceptionMode { get; set; }= default!;
    
        /// <summary>Message source. . The LoV is available in Cmess table TA_ORDREC2 </summary>
        [Newtonsoft.Json.JsonProperty("originalMessageLocation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OriginalMessageLocation { get; set; }= default!;
    
        /// <summary>Provider ID Code for external Register Equivalence.</summary>
        [Newtonsoft.Json.JsonProperty("secondaryProviderId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SecondaryProviderId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Body 
    {
        [Newtonsoft.Json.JsonProperty("underlyingRegAdjustments", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<_0>? UnderlyingRegAdjustments { get; set; }= default!;
    
    
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