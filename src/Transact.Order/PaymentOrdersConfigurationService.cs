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

namespace Transact.Order.PaymentOrdersConfiguration
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IPaymentOrdersConfigurationService
    {
        /// <summary>Retrieve payment purpose code details</summary>
        /// <param name="paymentOrderPurposeCodeId">Indicates the Id of payment purpose code i.e. purpose of the instruction based on a set of pre-defined categories.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from Transact on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>PaymentOrderPurposesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PaymentOrderPurposesResponse> GetPaymentOrderPurposesAsync(string? paymentOrderPurposeCodeId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, bool? disablePagination);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve payment purpose code details</summary>
        /// <param name="paymentOrderPurposeCodeId">Indicates the Id of payment purpose code i.e. purpose of the instruction based on a set of pre-defined categories.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from Transact on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>PaymentOrderPurposesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PaymentOrderPurposesResponse> GetPaymentOrderPurposesAsync(string? paymentOrderPurposeCodeId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, bool? disablePagination, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve payment product details</summary>
        /// <param name="paymentProductGroupId">Payment method group details of the payment</param>
        /// <param name="paymentOrderProductId">Indicates the payment order product for which payment is initiated</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from Transact on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>PaymentOrderProductsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PaymentOrderProductsResponse> GetPaymentOrderProductsAsync(string? paymentProductGroupId, string? paymentOrderProductId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, bool? disablePagination);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve payment product details</summary>
        /// <param name="paymentProductGroupId">Payment method group details of the payment</param>
        /// <param name="paymentOrderProductId">Indicates the payment order product for which payment is initiated</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from Transact on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>PaymentOrderProductsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PaymentOrderProductsResponse> GetPaymentOrderProductsAsync(string? paymentProductGroupId, string? paymentOrderProductId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, bool? disablePagination, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve payment country rule details</summary>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from Transact on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>PaymentOrderCountryRulesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PaymentOrderCountryRulesResponse> GetPaymentOrderCountryRulesAsync(string? countryId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, bool? disablePagination);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve payment country rule details</summary>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from Transact on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>PaymentOrderCountryRulesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PaymentOrderCountryRulesResponse> GetPaymentOrderCountryRulesAsync(string? countryId, int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, bool? disablePagination, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve ISO clearing codes</summary>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from Transact on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>ISOClearingCodesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ISOClearingCodesResponse> GetISOClearingCodesAsync(int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, bool? disablePagination);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve ISO clearing codes</summary>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from Transact on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>ISOClearingCodesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ISOClearingCodesResponse> GetISOClearingCodesAsync(int? page_size, int? page_start, string? page_token, string? credentials, string? companyId, string? deviceId, string? userRole, bool? disablePagination, System.Threading.CancellationToken cancellationToken);
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class QueryHeader 
    {
        [System.Text.Json.Serialization.JsonPropertyName("audit")]
        public Audit? Audit { get; set; }= default!;
    
        /// <summary>Status of the API(success/failed)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }= default!;
    
        /// <summary>The total number of records per page</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? Page_size { get; set; }= default!;
    
        /// <summary>The record from which the response should be displayed</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_start")]
        public int? Page_start { get; set; }= default!;
    
        /// <summary>The total number of records present</summary>
        [System.Text.Json.Serialization.JsonPropertyName("total_size")]
        public int? Total_size { get; set; }= default!;
    
        /// <summary>Unique id expected to get as part of response from Transact on every enquiry request</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public string? Page_token { get; set; }= default!;
    
    
    }
    
    /// <summary>PaymentOrderPurposesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentOrderPurposesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public PaymentOrderPurposesResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentOrderPurposesResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
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
    
        /// <summary>The actual Transact error message for bad requests</summary>
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
    
        /// <summary>The actual Transact error message caused by server</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type: System</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>PaymentOrderProductsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentOrderProductsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public PaymentOrderProductsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentOrderProductsResponseBody : System.Collections.ObjectModel.Collection<Anonymous2>
    {
    
    }
    
    /// <summary>PaymentOrderCountryRulesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentOrderCountryRulesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public PaymentOrderCountryRulesResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentOrderCountryRulesResponseBody : System.Collections.ObjectModel.Collection<Anonymous3>
    {
    
    }
    
    /// <summary>ISOClearingCodesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ISOClearingCodesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public ISOClearingCodesResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ISOClearingCodesResponseBody : System.Collections.ObjectModel.Collection<Anonymous4>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>Indicates the Id of payment purpose code i.e. purpose of the instruction based on a set of pre-defined categories.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentOrderPurposeCodeId")]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string? PaymentOrderPurposeCodeId { get; set; }= default!;
    
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [System.ComponentModel.DataAnnotations.StringLength(70)]
        public string? DisplayName { get; set; }= default!;
    
        /// <summary>This indicates a high-level classification of payment purpose code. i.e. purpose of the instruction based on a set of pre-defined categories.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("classification")]
        [System.ComponentModel.DataAnnotations.StringLength(70)]
        public string? Classification { get; set; }= default!;
    
        /// <summary>This indicates a full description of payment purpose code. i.e. purpose of the instruction based on a set of pre-defined categories.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("definition")]
        [System.ComponentModel.DataAnnotations.StringLength(120)]
        public string? Definition { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Audit2 
    {
        /// <summary>Time taken to response by Transact</summary>
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
    public partial class Anonymous2 
    {
        [System.Text.Json.Serialization.JsonPropertyName("paymentProductGroupIds")]
        public System.Collections.Generic.ICollection<PaymentProductGroupIds>? PaymentProductGroupIds { get; set; }= default!;
    
        /// <summary>The currency of payment.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentCurrencyIds")]
        public System.Collections.Generic.ICollection<PaymentCurrencyIds>? PaymentCurrencyIds { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("orderingCurrencyIds")]
        public System.Collections.Generic.ICollection<OrderingCurrencyIds>? OrderingCurrencyIds { get; set; }= default!;
    
        /// <summary>ISO country code of the financial institution. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryIds")]
        public System.Collections.Generic.ICollection<CountryIds>? CountryIds { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("clearingChannelIds")]
        public System.Collections.Generic.ICollection<ClearingChannelIds>? ClearingChannelIds { get; set; }= default!;
    
        /// <summary>Additional Information provided to add context</summary>
        [System.Text.Json.Serialization.JsonPropertyName("additionalInformations")]
        public System.Collections.Generic.ICollection<AdditionalInformations>? AdditionalInformations { get; set; }= default!;
    
        /// <summary>Indicates the payment order product for which payment is initiated</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentOrderProductId")]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? PaymentOrderProductId { get; set; }= default!;
    
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? DisplayName { get; set; }= default!;
    
        /// <summary>Indicates the rank of the payment order product within the group.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("rank")]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? Rank { get; set; }= default!;
    
        /// <summary>Defines whether payment initiation can be done by providing beneficiary details. This is applicable when beneficiary is not within the same bank</summary>
        [System.Text.Json.Serialization.JsonPropertyName("payThroughBeneficiary")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? PayThroughBeneficiary { get; set; }= default!;
    
        /// <summary>Indicates if a future dated instruction can be inputted for the specific payment order product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("futureDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? FutureDate { get; set; }= default!;
    
        /// <summary>Indicates if required credit value date can be inputted for the specific payment order product while initiating a payment</summary>
        [System.Text.Json.Serialization.JsonPropertyName("requiredCreditValue")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? RequiredCreditValue { get; set; }= default!;
    
        /// <summary>Check for payment support for IBAN or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("IBANSupport")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? IBANSupport { get; set; }= default!;
    
        /// <summary>Check for payment support for BIC or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("BICSupport")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? BICSupport { get; set; }= default!;
    
        /// <summary>Check for payment support for sortCode or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("sortCodeSupport")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? SortCodeSupport { get; set; }= default!;
    
        /// <summary>The additional text printed on descriptive statements in addition to the standard narrative and/or reference</summary>
        [System.Text.Json.Serialization.JsonPropertyName("narrative")]
        [System.ComponentModel.DataAnnotations.StringLength(65)]
        public string? Narrative { get; set; }= default!;
    
        /// <summary>The web link for additional information</summary>
        [System.Text.Json.Serialization.JsonPropertyName("weblink")]
        [System.ComponentModel.DataAnnotations.StringLength(70)]
        public string? Weblink { get; set; }= default!;
    
        /// <summary>Check for payment support for forex or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("forexSupport")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? ForexSupport { get; set; }= default!;
    
        /// <summary>Indicates the charge option which will be defaulted at the time of payment initiation for specific payment order product i.e. Recipient To Pay All Charges, Pay My Bank's Charges or Pay My Bank Charges Only.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("defaultChargeOption")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? DefaultChargeOption { get; set; }= default!;
    
        /// <summary>Used to set if simulation is required or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("checkTransparency")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? CheckTransparency { get; set; }= default!;
    
        /// <summary>External payment request for approval details</summary>
        [System.Text.Json.Serialization.JsonPropertyName("awaitExternalSubmit")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? AwaitExternalSubmit { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous3 
    {
        [System.Text.Json.Serialization.JsonPropertyName("clearingChannelIds")]
        public System.Collections.Generic.ICollection<ClearingChannelIds2>? ClearingChannelIds { get; set; }= default!;
    
        /// <summary>The currency of payment.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentCurrencyIds")]
        public System.Collections.Generic.ICollection<PaymentCurrencyIds2>? PaymentCurrencyIds { get; set; }= default!;
    
        /// <summary>ISO country code of the financial institution. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryId")]
        [System.ComponentModel.DataAnnotations.StringLength(9)]
        public string? CountryId { get; set; }= default!;
    
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [System.ComponentModel.DataAnnotations.StringLength(65)]
        public string? DisplayName { get; set; }= default!;
    
        /// <summary>Check for payment support for IBAN or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("IBANSupport")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? IBANSupport { get; set; }= default!;
    
        /// <summary>Check for payment support for BIC or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("BICSupport")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? BICSupport { get; set; }= default!;
    
        /// <summary>Check for payment support for sortCode or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("sortCodeSupport")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? SortCodeSupport { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous4 
    {
        /// <summary>Clearing channel specific details</summary>
        [System.Text.Json.Serialization.JsonPropertyName("clearingId")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? ClearingId { get; set; }= default!;
    
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [System.ComponentModel.DataAnnotations.StringLength(65)]
        public string? DisplayName { get; set; }= default!;
    
        /// <summary>Prefix of country specific details in payments method</summary>
        [System.Text.Json.Serialization.JsonPropertyName("swiftPrefix")]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string? SwiftPrefix { get; set; }= default!;
    
        /// <summary>Short name of country details</summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryShortName")]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string? CountryShortName { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentProductGroupIds 
    {
        /// <summary>Payment method group details of the payment</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentProductGroupId")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? PaymentProductGroupId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentCurrencyIds 
    {
        /// <summary>The currency of payment.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentCurrencyId")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? PaymentCurrencyId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class OrderingCurrencyIds 
    {
        /// <summary>Debit Account currency specific details</summary>
        [System.Text.Json.Serialization.JsonPropertyName("orderingCurrencyId")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? OrderingCurrencyId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CountryIds 
    {
        /// <summary>ISO country code of the financial institution. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryId")]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string? CountryId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ClearingChannelIds 
    {
        /// <summary>Indicates the clearing channel details to be used</summary>
        [System.Text.Json.Serialization.JsonPropertyName("clearingChannelId")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? ClearingChannelId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AdditionalInformations 
    {
        /// <summary>Additional Information provided to add context</summary>
        [System.Text.Json.Serialization.JsonPropertyName("additionalInformation")]
        [System.ComponentModel.DataAnnotations.StringLength(120)]
        public string? AdditionalInformation { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ClearingChannelIds2 
    {
        /// <summary>Indicates the clearing channel details to be used</summary>
        [System.Text.Json.Serialization.JsonPropertyName("clearingChannelId")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? ClearingChannelId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentCurrencyIds2 
    {
        /// <summary>The currency of payment.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentCurrencyId")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? PaymentCurrencyId { get; set; }= default!;
    
    
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