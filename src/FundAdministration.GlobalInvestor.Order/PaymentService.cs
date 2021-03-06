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

namespace FundAdministration.GlobalInvestor.Order.Payments
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IPaymentService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates Payment Details</summary>
        /// <param name="payload">postpayments Payload</param>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <returns>postpayments Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PostpaymentsSuccessResponse> PostpaymentsAsync(_0BULKPayload payload, string? referenceId = null, string? token = null, string? username = null, string? company = null, string? command = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    public partial class PostpaymentsSuccessheaderResponse 
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
    public partial class PostpaymentsrecordsSchema : System.Collections.ObjectModel.Collection<_0>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostpaymentsSuccessbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public PostpaymentsrecordsSchema? Records { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostpaymentsSuccessResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public PostpaymentsSuccessheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public PostpaymentsSuccessbodyResponse? Body { get; set; }= default!;
    
    
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
    public partial class PostpaymentsErrorheaderResponse 
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
    public partial class PostpaymentsErrorbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public System.Collections.Generic.ICollection<Items>? Items { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostpaymentsErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public PostpaymentsErrorheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class _0 
    {
        /// <summary>It specifies the type of record that is loaded</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordIndicator")]
        public string? RecordIndicator { get; set; }= default!;
    
        /// <summary>Internal order ID. Allowed values are from the list of Ids defined in MFGI.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("orderReference")]
        public double? OrderReference { get; set; }= default!;
    
        /// <summary>External order ID. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalOrderReference")]
        public string? ExternalOrderReference { get; set; }= default!;
    
        /// <summary>Internal agent ID. Allowed values are from the list of Ids defined in MFGI.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("agentNumber")]
        public double? AgentNumber { get; set; }= default!;
    
        /// <summary>External agent ID. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalAgentReference")]
        public string? ExternalAgentReference { get; set; }= default!;
    
        /// <summary>Internal register ID. Allowed values are from the list of Ids defined in MFGI.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("internalRegisterNumber")]
        public double? InternalRegisterNumber { get; set; }= default!;
    
        /// <summary>External register ID. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalRegisterReference")]
        public string? ExternalRegisterReference { get; set; }= default!;
    
        /// <summary>TA fund ID. Allowed values are from the list of Ids defined in MFGI.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("taFundCode")]
        public string? TaFundCode { get; set; }= default!;
    
        /// <summary>Internal TFC ID. Allowed values are from the list of Ids defined in MFGI.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("tfcNumber")]
        public double? TfcNumber { get; set; }= default!;
    
        /// <summary>Share class code. Allowed values are from the list of share class codes defined in MFGI.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("shareClassCode")]
        public string? ShareClassCode { get; set; }= default!;
    
        /// <summary>Contract number</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractNumber")]
        public double? ContractNumber { get; set; }= default!;
    
        /// <summary>Payment Date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? PaymentDate { get; set; }= default!;
    
        /// <summary>It specifies the amount that has been received from the investor.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("effectiveAmount")]
        public double? EffectiveAmount { get; set; }= default!;
    
        /// <summary>Payment Date &amp; time</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentDateTime")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? PaymentDateTime { get; set; }= default!;
    
        /// <summary>It specifies which due amount is settled</summary>
        [System.Text.Json.Serialization.JsonPropertyName("settlementMoneyIndicator")]
        public string? SettlementMoneyIndicator { get; set; }= default!;
    
        /// <summary>Partial settlement ID populated for subsequent payment records only. Automatically incremented by the system. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("partialSettlementId")]
        public double? PartialSettlementId { get; set; }= default!;
    
        /// <summary>It specifies the order amount(in case of main payment) or the outstanding order amount (in case of subsequent payments).</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentAmount")]
        public double? PaymentAmount { get; set; }= default!;
    
        /// <summary>Code for the mode through which the transaction has been received.For example: 0001(Telephone), 0002(Fax),0003(Email)etc. The LoV is available from CMESS table TA_ORDREC</summary>
        [System.Text.Json.Serialization.JsonPropertyName("receptionMode")]
        public string? ReceptionMode { get; set; }= default!;
    
        /// <summary>External ID provider. TheLOV is available from CMESS table TYP_IDVAL</summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalSecurityIDCodeType")]
        public string? ExternalSecurityIDCodeType { get; set; }= default!;
    
        /// <summary>External ID for the security</summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalSecurityIDCode")]
        public string? ExternalSecurityIDCode { get; set; }= default!;
    
        /// <summary>Location where the File is stored</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fileLocation")]
        public string? FileLocation { get; set; }= default!;
    
        /// <summary>It specifies the TA fund currecy. Through this field, system identifies the Fund and share class in for which the the payment is made association with securityExternalIdType and securityExternalId</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentCurrency")]
        public string? PaymentCurrency { get; set; }= default!;
    
        /// <summary>External ID of the global register</summary>
        [System.Text.Json.Serialization.JsonPropertyName("nregisterGlobalExt")]
        public string? NregisterGlobalExt { get; set; }= default!;
    
        /// <summary>Transaction's identification number</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dealRef")]
        public string? DealRef { get; set; }= default!;
    
        /// <summary>It specifies the interest amount for the late payment</summary>
        [System.Text.Json.Serialization.JsonPropertyName("peRealEstLatePmtInt")]
        public double? PeRealEstLatePmtInt { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Body 
    {
        [System.Text.Json.Serialization.JsonPropertyName("paymentDetailses")]
        public System.Collections.Generic.ICollection<_0>? PaymentDetailses { get; set; }= default!;
    
    
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