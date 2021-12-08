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

namespace Transact.Holding.SecurityTrades
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface ISecurityTradesService
    {
        /// <summary>Allows to view the security trade details</summary>
        /// <param name="securityTradeId">Identifier of the Security Trade</param>
        /// <param name="customerId">Identifier of the customer</param>
        /// <param name="instrumentId">The identifier of the instrument</param>
        /// <param name="depositoryId">Id of the securities depository.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <returns>SecurityTradesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<SecurityTradesResponse> GetSecurityTradesAsync(string securityTradeId, string? customerId, string? instrumentId, string? depositoryId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Allows to view the security trade details</summary>
        /// <param name="securityTradeId">Identifier of the Security Trade</param>
        /// <param name="customerId">Identifier of the customer</param>
        /// <param name="instrumentId">The identifier of the instrument</param>
        /// <param name="depositoryId">Id of the securities depository.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <returns>SecurityTradesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<SecurityTradesResponse> GetSecurityTradesAsync(string securityTradeId, string? customerId, string? instrumentId, string? depositoryId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, System.Threading.CancellationToken cancellationToken);
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class QueryHeader 
    {
        [System.Text.Json.Serialization.JsonPropertyName("audit")]
        public Audit? Audit { get; set; }= default!;
    
        /// <summary>The total number of records per page</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? Page_size { get; set; }= default!;
    
        /// <summary>The record from which the response should be displayed</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_start")]
        public int? Page_start { get; set; }= default!;
    
        /// <summary>The total number of records present</summary>
        [System.Text.Json.Serialization.JsonPropertyName("total_size")]
        public int? Total_size { get; set; }= default!;
    
        /// <summary>Unique id expected to get as part of response from t24 on every enquiry request</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public string? Page_token { get; set; }= default!;
    
    
    }
    
    /// <summary>SecurityTradesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SecurityTradesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public SecurityTradesResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SecurityTradesResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
    {
    
    }
    
    /// <summary>BusinessQueryErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BusinessQueryErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public BusinessQueryErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BusinessQueryErrorResponseBody 
    {
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message for bad requests</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type: Business</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>SystemQueryErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SystemQueryErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public SystemQueryErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SystemQueryErrorResponseBody 
    {
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message caused by server</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type: System</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous 
    {
        [System.Text.Json.Serialization.JsonPropertyName("customerDetails")]
        public System.Collections.Generic.ICollection<CustomerDetails>? CustomerDetails { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("brokerDetails")]
        public System.Collections.Generic.ICollection<BrokerDetails>? BrokerDetails { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("matchCodeDetails")]
        public System.Collections.Generic.ICollection<MatchCodeDetails>? MatchCodeDetails { get; set; }= default!;
    
        /// <summary>Identifier of the Security Trade</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityTradeId")]
        public string? SecurityTradeId { get; set; }= default!;
    
        /// <summary>Standard date field which records trade date of the account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("tradeDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? TradeDate { get; set; }= default!;
    
        /// <summary>Indicates the value date on which the underlying accounting entry is to be given value (for interest purposes)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("valueDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ValueDate { get; set; }= default!;
    
        /// <summary>Contains the swift message reference for the MT540-543</summary>
        [System.Text.Json.Serialization.JsonPropertyName("depositoryDeliveryKey")]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public string? DepositoryDeliveryKey { get; set; }= default!;
    
        /// <summary>Contains the date and time separated by '-'</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dateTime")]
        public string? DateTime { get; set; }= default!;
    
        /// <summary>Contains the incoming MT544-547 Swift message reference</summary>
        [System.Text.Json.Serialization.JsonPropertyName("depositoryConfirmationKey")]
        public string? DepositoryConfirmationKey { get; set; }= default!;
    
        /// <summary>Contains the date and time of receipt of depository confirmation swift MT544-547</summary>
        [System.Text.Json.Serialization.JsonPropertyName("depositoryConfirmationTime")]
        public string? DepositoryConfirmationTime { get; set; }= default!;
    
        /// <summary>Contains the swift message MT548 reference of the status of settlement Instruction sent</summary>
        [System.Text.Json.Serialization.JsonPropertyName("settlementStatusKey")]
        public string? SettlementStatusKey { get; set; }= default!;
    
        /// <summary>Contains the date and time of receipt of swift message MT548 (Status of Settlement Instruction)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("settlementStatusTime")]
        public string? SettlementStatusTime { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Audit2 
    {
        /// <summary>Time taken to response by T24</summary>
        [System.Text.Json.Serialization.JsonPropertyName("T24_time")]
        public int? T24_time { get; set; }= default!;
    
        /// <summary>The CURR.NO. of the record</summary>
        [System.Text.Json.Serialization.JsonPropertyName("versionNumber")]
        public string? VersionNumber { get; set; }= default!;
    
        /// <summary>Time taken to parse the request by IRIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("requestParse_time")]
        public double? RequestParse_time { get; set; }= default!;
    
        /// <summary>Time taken to parse the response by IRIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("responseParse_time")]
        public double? ResponseParse_time { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CustomerDetails 
    {
        /// <summary>Identifier of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerId")]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? CustomerId { get; set; }= default!;
    
        /// <summary>Name of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerName")]
        public string? CustomerName { get; set; }= default!;
    
        /// <summary>Holds the total amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("netAmount")]
        public string? NetAmount { get; set; }= default!;
    
        /// <summary>The accrued Interest due or accrued.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestAmount")]
        public string? InterestAmount { get; set; }= default!;
    
        /// <summary>The bank fees or commission charged for the transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("commission")]
        public string? Commission { get; set; }= default!;
    
        /// <summary>Total amount of taxes applicable on all commission or charges calculated for the transaction/payment.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("taxAmount")]
        public string? TaxAmount { get; set; }= default!;
    
        /// <summary>This field Records the Foreign Fee amount charged to the Customer for the trade.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("foreignFee")]
        public string? ForeignFee { get; set; }= default!;
    
        /// <summary>The amount of miscellaneous fees charged to the Customer for the trade</summary>
        [System.Text.Json.Serialization.JsonPropertyName("miscellaneousFee")]
        public string? MiscellaneousFee { get; set; }= default!;
    
        /// <summary>This field Records the amount of EBV Fees charged to the Customer for the trade.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("EBVFee")]
        public string? EBVFee { get; set; }= default!;
    
        /// <summary>Contains the gross amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("grossAmount")]
        public string? GrossAmount { get; set; }= default!;
    
        /// <summary>Contains the sum of gross amount and interest accrued</summary>
        [System.Text.Json.Serialization.JsonPropertyName("grossInterestAccrued")]
        public string? GrossInterestAccrued { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("nominalDetails")]
        public System.Collections.Generic.ICollection<NominalDetails>? NominalDetails { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("deliveryDetails")]
        public System.Collections.Generic.ICollection<DeliveryDetails>? DeliveryDetails { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BrokerDetails 
    {
        [System.Text.Json.Serialization.JsonPropertyName("deliveryDetails")]
        public System.Collections.Generic.ICollection<DeliveryDetails2>? DeliveryDetails { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class MatchCodeDetails 
    {
        /// <summary>Defines the status of settlement instruction for the incoming MT548 swift message. Sample values are 1. MTCH/MACH 2. IPRC/PACK</summary>
        [System.Text.Json.Serialization.JsonPropertyName("matchCode")]
        public string? MatchCode { get; set; }= default!;
    
        /// <summary>Contains the description of the status of settlement Instruction.  Sample values are 1. Matched 2. Acknowledged/Accepted</summary>
        [System.Text.Json.Serialization.JsonPropertyName("matchCodeDescription")]
        public string? MatchCodeDescription { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class NominalDetails 
    {
        /// <summary>The nominal quantity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 18D)]
        public double? Quantity { get; set; }= default!;
    
        /// <summary>The Price at which the nominal amount of the Security is to be valued for the transaction.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public string? Price { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DeliveryDetails 
    {
        /// <summary>Delivery instruction reference</summary>
        [System.Text.Json.Serialization.JsonPropertyName("deliveryKey")]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public string? DeliveryKey { get; set; }= default!;
    
        /// <summary>Contains the date and time separated by '-'</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dateTime")]
        public string? DateTime { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DeliveryDetails2 
    {
        /// <summary>Delivery instruction reference</summary>
        [System.Text.Json.Serialization.JsonPropertyName("deliveryKey")]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public string? DeliveryKey { get; set; }= default!;
    
        /// <summary>Defines the type of swift messages that are sent or received for a transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("messageType")]
        public string? MessageType { get; set; }= default!;
    
        /// <summary>Contains the date and time separated by '-'</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dateTime")]
        public string? DateTime { get; set; }= default!;
    
    
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