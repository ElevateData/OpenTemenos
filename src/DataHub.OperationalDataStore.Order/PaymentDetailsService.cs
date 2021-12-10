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

namespace DataHub.OperationalDataStore.Order.PaymentDetails
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IPaymentDetailsService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the payment purpose code details such as short description, classification and definition</summary>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <returns>getPaymentOrderPurposeCodesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetPaymentOrderPurposeCodesResponse> GetPaymentOrderPurposeCodesAsync(string? recordId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the payment features defined for each product</summary>
        /// <param name="paymentProductGroupId">Payment method group details of the payment</param>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <returns>getPaymentOrderProductDetailsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetPaymentOrderProductDetailsResponse> GetPaymentOrderProductDetailsAsync(string? paymentProductGroupId = null, string? recordId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the country specific rule details such as IBAN, BIC, Bank Sort code to be allowed or not allowed, Clearing code format for each clearing channel, list of payment currencies accepted</summary>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <returns>getPaymentOrderCountryRulesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetPaymentOrderCountryRulesResponse> GetPaymentOrderCountryRulesAsync(string? recordId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the overall transaction information</summary>
        /// <param name="company">The company code</param>
        /// <param name="date">Indicates the date on which activity was performed</param>
        /// <param name="transactionReference">Contains the identifier for the transaction in the core system</param>
        /// <param name="direction">Indicates the direction of the Direct debit claim for which mandate is received. The claim can be 'Outward' i.e. Claim is sent to the other bank or 'Inward'  i.e. other bank submit their claim to debit our customer's account.</param>
        /// <param name="currency">Contains all details of each individual currency, for example, currency name, number of decimal places together with other information such as the buy and sell rates</param>
        /// <param name="amount">This is the payment amount</param>
        /// <param name="debitClientID">Indicates the debit customer client Id</param>
        /// <param name="creditClientID">Indicates the credit customer client Id</param>
        /// <param name="debitMainAccountCurrencyCode">ISO Currency for Debit Main Account</param>
        /// <param name="debitAccountId">Indicates the debit account number of the payment or transaction.</param>
        /// <param name="creditAccountId">Credit account identifier of the payment or transaction</param>
        /// <returns>getPendingPaymentsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetPendingPaymentsResponse> GetPendingPaymentsAsync(string? company = null, System.DateTimeOffset? date = null, string? transactionReference = null, string? direction = null, string? currency = null, double? amount = null, string? debitClientID = null, string? creditClientID = null, string? debitMainAccountCurrencyCode = null, string? debitAccountId = null, string? creditAccountId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the charge details applied for transactions</summary>
        /// <returns>getPaymentFeesAndChargesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetPaymentFeesAndChargesResponse> GetPaymentFeesAndChargesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the file uploading details which includes extension of the file, directory and maximum file size details</summary>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <returns>getUploadFileTypesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetUploadFileTypesResponse> GetUploadFileTypesAsync(string? recordId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    /// <summary>getPaymentOrderPurposeCodesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetPaymentOrderPurposeCodesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetPaymentOrderPurposeCodesResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetPaymentOrderPurposeCodesResponseBody 
    {
        /// <summary>Holds information related to the SEPA payment purpose codes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentPurposeCode")]
        public System.Collections.Generic.ICollection<PaymentPurposeCode>? PaymentPurposeCode { get; set; }= default!;
    
    
    }
    
    /// <summary>getPaymentOrderProductDetailsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetPaymentOrderProductDetailsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetPaymentOrderProductDetailsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetPaymentOrderProductDetailsResponseBody 
    {
        /// <summary>Payment Features that are specific to a product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentOrderProduct")]
        public System.Collections.Generic.ICollection<PaymentOrderProduct>? PaymentOrderProduct { get; set; }= default!;
    
    
    }
    
    /// <summary>getPaymentOrderCountryRulesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetPaymentOrderCountryRulesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetPaymentOrderCountryRulesResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetPaymentOrderCountryRulesResponseBody 
    {
        /// <summary>Holds Country specific validations details</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentOrderCountryRules")]
        public System.Collections.Generic.ICollection<PaymentOrderCountryRules>? PaymentOrderCountryRules { get; set; }= default!;
    
    
    }
    
    /// <summary>getPendingPaymentsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetPendingPaymentsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetPendingPaymentsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetPendingPaymentsResponseBody 
    {
        /// <summary>Information of the overall transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("porTransaction")]
        public System.Collections.Generic.ICollection<PorTransaction>? PorTransaction { get; set; }= default!;
    
    
    }
    
    /// <summary>getPaymentFeesAndChargesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetPaymentFeesAndChargesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetPaymentFeesAndChargesResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetPaymentFeesAndChargesResponseBody 
    {
        /// <summary>Holds the charges applied for a transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("postingAndConfirmation")]
        public System.Collections.Generic.ICollection<PostingAndConfirmation>? PostingAndConfirmation { get; set; }= default!;
    
    
    }
    
    /// <summary>getUploadFileTypesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetUploadFileTypesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetUploadFileTypesResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetUploadFileTypesResponseBody 
    {
        /// <summary>Application allows parameters for a type of upload to be defined. These include the upload directory, optional maximum file size limit, and optional extension</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fileUploadType")]
        public System.Collections.Generic.ICollection<FileUploadType>? FileUploadType { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentPurposeCode 
    {
        /// <summary>Unique identifier of an entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordId")]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>This indicates a full description of payment purpose code. i.e. purpose of the instruction based on a set of pre-defined categories.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("definition")]
        public string? Definition { get; set; }= default!;
    
        /// <summary>Language specific fields will be displayed under this entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("language")]
        public Language? Language { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentOrderProduct 
    {
        /// <summary>Unique identifier of an entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordId")]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Indicates the rank of the payment order product within the group. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("rank")]
        public string? Rank { get; set; }= default!;
    
        /// <summary>Defines whether payment initiation can be done by providing beneficiary details. This is applicable when beneficiary is not within the same bank</summary>
        [System.Text.Json.Serialization.JsonPropertyName("payThroughBeneficiary")]
        public string? PayThroughBeneficiary { get; set; }= default!;
    
        /// <summary>Indicates if a future dated instruction can be inputted for the specific payment order product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("futureDate")]
        public string? FutureDate { get; set; }= default!;
    
        /// <summary>Indicates if required credit value date can be inputted for the specific payment order product while initiating a payment</summary>
        [System.Text.Json.Serialization.JsonPropertyName("requiredCreditValue")]
        public string? RequiredCreditValue { get; set; }= default!;
    
        /// <summary>Check for payment support for IBAN or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("IBANSupport")]
        public string? IBANSupport { get; set; }= default!;
    
        /// <summary>Check for payment support for BIC or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("BICSupport")]
        public string? BICSupport { get; set; }= default!;
    
        /// <summary>Check for payment support for sortCode or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("sortCodeSupport")]
        public string? SortCodeSupport { get; set; }= default!;
    
        /// <summary>The additional text printed on descriptive statements in addition to the standard narrative and/or reference</summary>
        [System.Text.Json.Serialization.JsonPropertyName("narrative")]
        public string? Narrative { get; set; }= default!;
    
        /// <summary>The web link for additional information</summary>
        [System.Text.Json.Serialization.JsonPropertyName("weblink")]
        public string? Weblink { get; set; }= default!;
    
        /// <summary>Check for payment support for forex or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("forexSupport")]
        public string? ForexSupport { get; set; }= default!;
    
        /// <summary>Indicates the charge option which will be defaulted at the time of payment initiation for specific payment order product i.e. Recipient To Pay All Charges, Pay My Bank's Charges or Pay My Bank Charges Only.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("defaultChargeOption")]
        public string? DefaultChargeOption { get; set; }= default!;
    
        /// <summary>Used to set if simulation is required or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("checkTransparency")]
        public string? CheckTransparency { get; set; }= default!;
    
        /// <summary>External payment request for approval details</summary>
        [System.Text.Json.Serialization.JsonPropertyName("awaitExternalSubmit")]
        public string? AwaitExternalSubmit { get; set; }= default!;
    
        /// <summary>Language specific fields will be displayed under this entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("language")]
        public Language2? Language { get; set; }= default!;
    
        /// <summary>Payment method group details of the payment</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentProductGroupId")]
        public PaymentProductGroupId? PaymentProductGroupId { get; set; }= default!;
    
        /// <summary>The currency of payment.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentCurrencyId")]
        public PaymentCurrencyId? PaymentCurrencyId { get; set; }= default!;
    
        /// <summary>Debit Account currency specific details</summary>
        [System.Text.Json.Serialization.JsonPropertyName("orderingCurrencyId")]
        public OrderingCurrencyId? OrderingCurrencyId { get; set; }= default!;
    
        /// <summary>ISO country code of the financial institution. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryId")]
        public CountryId? CountryId { get; set; }= default!;
    
        /// <summary>Indicates the clearing channel details to be used</summary>
        [System.Text.Json.Serialization.JsonPropertyName("clearingChannelId")]
        public ClearingChannelId? ClearingChannelId { get; set; }= default!;
    
        /// <summary>Additional Information provided to add context</summary>
        [System.Text.Json.Serialization.JsonPropertyName("additionalInformation")]
        public AdditionalInformation? AdditionalInformation { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentOrderCountryRules 
    {
        /// <summary>Unique identifier of an entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordId")]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Language specific fields will be displayed under this entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("language")]
        public Language3? Language { get; set; }= default!;
    
        /// <summary>Check for payment support for IBAN or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("IBANSupport")]
        public string? IBANSupport { get; set; }= default!;
    
        /// <summary>Check for payment support for BIC or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("BICSupport")]
        public string? BICSupport { get; set; }= default!;
    
        /// <summary>Check for payment support for sortCode or not</summary>
        [System.Text.Json.Serialization.JsonPropertyName("sortCodeSupport")]
        public string? SortCodeSupport { get; set; }= default!;
    
        /// <summary>Indicates the clearing channel details to be used</summary>
        [System.Text.Json.Serialization.JsonPropertyName("clearingChannelId")]
        public ClearingChannelId2? ClearingChannelId { get; set; }= default!;
    
        /// <summary>This field holds the transaction currency or currency in which payment is initiated. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentCurrency")]
        public PaymentCurrency? PaymentCurrency { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PorTransaction 
    {
        /// <summary>The company code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }= default!;
    
        /// <summary>ISO Currency for Debit Main Account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("debitMainAccountCurrencyCode")]
        public string? DebitMainAccountCurrencyCode { get; set; }= default!;
    
        /// <summary>ISO Currency for Credit Main Account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("creditMainAccountCurrencyCode")]
        public string? CreditMainAccountCurrencyCode { get; set; }= default!;
    
        /// <summary>Indicates Customer transfer (CTR) or Bank transfer (BTR)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("ctrBtrIndicator")]
        public string? CtrBtrIndicator { get; set; }= default!;
    
        /// <summary>Date in the format YYYYMMDD. E.g. 20191231</summary>
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }= default!;
    
        /// <summary>Indicates the customer sepecified reference</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerSpecifiedReference")]
        public string? CustomerSpecifiedReference { get; set; }= default!;
    
        /// <summary>Indicates the transaction related reference</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionReferenceIncoming")]
        public string? TransactionReferenceIncoming { get; set; }= default!;
    
        /// <summary>Contains the identifier for the transaction in the core system</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionReference")]
        public string? TransactionReference { get; set; }= default!;
    
        /// <summary>Indicates the incoming sender's reference i.e. tag 20 of incoming SWIFT or in case when transaction is received from other system/ application, this can also indicate the reference number of that system/ application</summary>
        [System.Text.Json.Serialization.JsonPropertyName("sendersReference")]
        public string? SendersReference { get; set; }= default!;
    
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }= default!;
    
        /// <summary>Indicates the date and time when the record was created in DD MON YYYY HH:MM:SS.MMM format</summary>
        [System.Text.Json.Serialization.JsonPropertyName("receivedAt")]
        public string? ReceivedAt { get; set; }= default!;
    
        /// <summary>Unique identifier of an entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordId")]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Identifies the currency. E.g. USD, GBP etc</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; }= default!;
    
        /// <summary>This is the payment amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public string? Amount { get; set; }= default!;
    
        /// <summary>Indicates the direction of the Direct debit claim for which mandate is received. The claim can be 'Outward' i.e. Claim is sent to the other bank or 'Inward'  i.e. other bank submit their claim to debit our customer's account. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("direction")]
        public string? Direction { get; set; }= default!;
    
        /// <summary>Indicates the debit account number of the payment or transaction.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("debitAccountId")]
        public string? DebitAccountId { get; set; }= default!;
    
        /// <summary>Credit account identifier of the payment or transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("creditAccountId")]
        public string? CreditAccountId { get; set; }= default!;
    
        /// <summary>Indicates the credit main account company ID</summary>
        [System.Text.Json.Serialization.JsonPropertyName("creditMainAccountCompanyID")]
        public string? CreditMainAccountCompanyID { get; set; }= default!;
    
        /// <summary>Indicates the debit main account company ID</summary>
        [System.Text.Json.Serialization.JsonPropertyName("debitMainAccountCompanyID")]
        public string? DebitMainAccountCompanyID { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostingAndConfirmation 
    {
        [System.Text.Json.Serialization.JsonPropertyName("chargeBearer")]
        public ChargeBearer? ChargeBearer { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class FileUploadType 
    {
        /// <summary>specifies in which directory files will be uploaded to</summary>
        [System.Text.Json.Serialization.JsonPropertyName("uploadDirectory")]
        public string? UploadDirectory { get; set; }= default!;
    
        /// <summary>Specifies the upload file extension type. For example CSV, XML or PDF etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fileExtension")]
        public string? FileExtension { get; set; }= default!;
    
        /// <summary>Specifies a maximum size (in bytes) to be uploaded</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fileMaximumSize")]
        public string? FileMaximumSize { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Language 
    {
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }= default!;
    
        /// <summary>This indicates a high-level classification of payment purpose code. i.e. purpose of the instruction based on a set of pre-defined categories.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("classification")]
        public string? Classification { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Language2 
    {
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentProductGroupId 
    {
        /// <summary>Payment method group details of the payment</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentProductGroupId")]
        public string? PaymentProductGroupId1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentCurrencyId 
    {
        /// <summary>The currency of payment.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentCurrencyId")]
        public string? PaymentCurrencyId1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class OrderingCurrencyId 
    {
        /// <summary>Debit Account currency specific details</summary>
        [System.Text.Json.Serialization.JsonPropertyName("orderingCurrencyId")]
        public string? OrderingCurrencyId1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CountryId 
    {
        /// <summary>ISO country code of the financial institution. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("countryId")]
        public string? CountryId1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ClearingChannelId 
    {
        /// <summary>Indicates the clearing channel details to be used</summary>
        [System.Text.Json.Serialization.JsonPropertyName("clearingChannelId")]
        public string? ClearingChannelId1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AdditionalInformation 
    {
        /// <summary>Additional Information provided to add context</summary>
        [System.Text.Json.Serialization.JsonPropertyName("additionalInformation")]
        public string? AdditionalInformation1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Language3 
    {
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ClearingChannelId2 
    {
        /// <summary>Indicates the clearing channel details to be used</summary>
        [System.Text.Json.Serialization.JsonPropertyName("clearingChannelId")]
        public string? ClearingChannelId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaymentCurrency 
    {
        /// <summary>This field holds the transaction currency or currency in which payment is initiated. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentCurrency")]
        public string? PaymentCurrency1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ChargeBearer 
    {
        /// <summary>Bearer of the charges of the order. For example: BEN(All transaction charges are to be borne by the beneficiary customer.), OUR(All transaction charges are to be borne by the ordering customer.), SHA(Transaction charges on the Sender's side are to be borne by the ordering customer, transaction charges on the Receiver's side are to be borne by the beneficiary customer.)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("chargeBearer")]
        public string? ChargeBearer1 { get; set; }= default!;
    
        /// <summary>Describes the Fee type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("feeDescription")]
        public string? FeeDescription { get; set; }= default!;
    
        /// <summary>Indicates the type of fee calculated</summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeOfCharge")]
        public string? TypeOfCharge { get; set; }= default!;
    
        /// <summary>Indicates the currency code in which the fee will be charged</summary>
        [System.Text.Json.Serialization.JsonPropertyName("feeCurrency")]
        public string? FeeCurrency { get; set; }= default!;
    
        /// <summary>Indicates the charge amount equivalent in charge account currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("chargeAmount")]
        public string? ChargeAmount { get; set; }= default!;
    
        /// <summary>Indicates the charge amount equivalent in fee currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("chargeAmountFeeCcy")]
        public string? ChargeAmountFeeCcy { get; set; }= default!;
    
        /// <summary>Indicates the Fee type applied from the PPT.FEETYPE table</summary>
        [System.Text.Json.Serialization.JsonPropertyName("feeType")]
        public string? FeeType { get; set; }= default!;
    
        /// <summary>Indicates the currency code of the charge account from where the fee is deducted</summary>
        [System.Text.Json.Serialization.JsonPropertyName("chargeAmountCcy")]
        public string? ChargeAmountCcy { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016