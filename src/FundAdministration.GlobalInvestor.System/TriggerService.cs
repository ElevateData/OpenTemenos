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

namespace OpenTemenos.FundAdministrations.GlobalInvestor.System.Triggers
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface ITriggerService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates Outbound Trigger Tables</summary>
        /// <param name="payload">posttriggers Payload</param>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <returns>posttriggers Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PosttriggersSuccessResponse> PosttriggersAsync(_0BULKPayload payload, string? referenceId = null, string? token = null, string? username = null, string? company = null, string? command = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    public partial class PosttriggersSuccessheaderResponse 
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
    public partial class PosttriggersrecordsSchema : System.Collections.ObjectModel.Collection<_0>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PosttriggersSuccessbodyResponse 
    {
        [Newtonsoft.Json.JsonProperty("records", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PosttriggersrecordsSchema? Records { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PosttriggersSuccessResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PosttriggersSuccessheaderResponse? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PosttriggersSuccessbodyResponse? Body { get; set; }= default!;
    
    
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
    public partial class PosttriggersErrorheaderResponse 
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
    public partial class PosttriggersErrorbodyResponse 
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Items>? Items { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PosttriggersErrorResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PosttriggersErrorheaderResponse? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class _0 
    {
        /// <summary>It specifies the type of record that is loaded</summary>
        [Newtonsoft.Json.JsonProperty("recordIndicator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RecordIndicator { get; set; }= default!;
    
        /// <summary>It specifies the Job ID that this output belongs to.  Overall Job ID from dashboard screen</summary>
        [Newtonsoft.Json.JsonProperty("jobID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? JobID { get; set; }= default!;
    
        /// <summary>It specifies the sequential number assigned to all records created from the same job / doc_type. System generated</summary>
        [Newtonsoft.Json.JsonProperty("sequenceNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SequenceNumber { get; set; }= default!;
    
        /// <summary>It specifies the Sequence Document number of the trigger</summary>
        [Newtonsoft.Json.JsonProperty("sequenceDocumentNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SequenceDocumentNumber { get; set; }= default!;
    
        /// <summary>It specifies the external register identifier of the register </summary>
        [Newtonsoft.Json.JsonProperty("externalRegisterNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExternalRegisterNumber { get; set; }= default!;
    
        /// <summary>It specifies the contact number of the deal</summary>
        [Newtonsoft.Json.JsonProperty("contractNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContractNumber { get; set; }= default!;
    
        /// <summary>It specifies the order number of the deal</summary>
        [Newtonsoft.Json.JsonProperty("orderReference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OrderReference { get; set; }= default!;
    
        /// <summary>It specifies the Agent ID of the contract</summary>
        [Newtonsoft.Json.JsonProperty("agentNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AgentNumber { get; set; }= default!;
    
        /// <summary>It specifies the External order reference from the order linked to the contract</summary>
        [Newtonsoft.Json.JsonProperty("externalOrderReference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExternalOrderReference { get; set; }= default!;
    
        /// <summary>It specifies the status of the document/records in the queue</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Status { get; set; }= default!;
    
        /// <summary>It specifies the date and timestamp when the record has been extracted</summary>
        [Newtonsoft.Json.JsonProperty("extractedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ExtractedDate { get; set; }= default!;
    
        /// <summary>It specifies the date and timestamp when the record has been created</summary>
        [Newtonsoft.Json.JsonProperty("createdDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? CreatedDate { get; set; }= default!;
    
        /// <summary>It specifies the Folder path and filename to indicate the destination where outbound messages can be retrieved</summary>
        [Newtonsoft.Json.JsonProperty("pathName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PathName { get; set; }= default!;
    
        /// <summary>It specifies the Date and timestamp when the message has been successfully delivered or not</summary>
        [Newtonsoft.Json.JsonProperty("dateAcknowledged", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? DateAcknowledged { get; set; }= default!;
    
        /// <summary>It specifies the external comment </summary>
        [Newtonsoft.Json.JsonProperty("externalComment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExternalComment { get; set; }= default!;
    
        /// <summary>It specifies the document id</summary>
        [Newtonsoft.Json.JsonProperty("documentID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocumentID { get; set; }= default!;
    
        /// <summary>It specifies the external register identifier </summary>
        [Newtonsoft.Json.JsonProperty("externalRegisterReference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExternalRegisterReference { get; set; }= default!;
    
        /// <summary>It specifies the Sender STP counterparty defined in the Central register screen</summary>
        [Newtonsoft.Json.JsonProperty("sTPCounterpart", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? STPCounterpart { get; set; }= default!;
    
        /// <summary>It specifies the external security Id type</summary>
        [Newtonsoft.Json.JsonProperty("externalSecurityIDCodeType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExternalSecurityIDCodeType { get; set; }= default!;
    
        /// <summary>It specifies the external security identification code </summary>
        [Newtonsoft.Json.JsonProperty("externalSecurityIDCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExternalSecurityIDCode { get; set; }= default!;
    
        /// <summary>It specifies the TA fund currency </summary>
        [Newtonsoft.Json.JsonProperty("quotationCurrency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? QuotationCurrency { get; set; }= default!;
    
        /// <summary>It specifies the reporting currency </summary>
        [Newtonsoft.Json.JsonProperty("reportCurrency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReportCurrency { get; set; }= default!;
    
        /// <summary>It specifies the Mode received</summary>
        [Newtonsoft.Json.JsonProperty("receptionMode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReceptionMode { get; set; }= default!;
    
        /// <summary>ID</summary>
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ID { get; set; }= default!;
    
        /// <summary>Main Operation</summary>
        [Newtonsoft.Json.JsonProperty("operation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Operation { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Body 
    {
        [Newtonsoft.Json.JsonProperty("outboundTriggerTables", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<_0>? OutboundTriggerTables { get; set; }= default!;
    
    
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