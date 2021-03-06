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

namespace DataHub.OperationalDataStore.Holding.GuaranteeDetails
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IGuaranteeDetailService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the Corporate customer's guarantees issuance request details</summary>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <param name="customerId">Identifier of the customer</param>
        /// <param name="eventStatus">Specifies the status of the request.Allowed values are - With Bank_With Customer_Approved_Rejected.</param>
        /// <returns>getGuaranteeIssuanceRequestsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetGuaranteeIssuanceRequestsResponse> GetGuaranteeIssuanceRequestsAsync(string? recordId = null, string? customerId = null, string? eventStatus = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    /// <summary>getGuaranteeIssuanceRequestsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetGuaranteeIssuanceRequestsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetGuaranteeIssuanceRequestsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetGuaranteeIssuanceRequestsResponseBody 
    {
        /// <summary>Corporate customer to initiate requests for issuance of guarantees through Internet Banking</summary>
        [System.Text.Json.Serialization.JsonPropertyName("ibRequest")]
        public System.Collections.Generic.ICollection<IbRequest>? IbRequest { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class IbRequest 
    {
        /// <summary>Unique identifier of an entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordId")]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Product name of the bank for this account, proprietary definition.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productName")]
        public string? ProductName { get; set; }= default!;
    
        /// <summary>Identifier of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerId")]
        public string? CustomerId { get; set; }= default!;
    
        /// <summary>Identifier of the currency. This is the 3-letter ISO 4217 code of the currency.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currencyId")]
        public string? CurrencyId { get; set; }= default!;
    
        /// <summary>Indicates the Principal Amount of the loan or a deposit</summary>
        [System.Text.Json.Serialization.JsonPropertyName("principalAmount")]
        public string? PrincipalAmount { get; set; }= default!;
    
        /// <summary>Contains the date on which the transaction or payment gets initiated.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public string? StartDate { get; set; }= default!;
    
        /// <summary>Indicates maturity date of the contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maturityDate")]
        public string? MaturityDate { get; set; }= default!;
    
        /// <summary>Indicates the Id of beneficiary when beneficiary details are stored</summary>
        [System.Text.Json.Serialization.JsonPropertyName("beneficiaryId")]
        public BeneficiaryId? BeneficiaryId { get; set; }= default!;
    
        /// <summary>This field contains all terms, conditions and details of the guarantee undertaking. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("detailOfGuarantee")]
        public DetailOfGuarantee? DetailOfGuarantee { get; set; }= default!;
    
        /// <summary>To specify the Corporate customer's reference</summary>
        [System.Text.Json.Serialization.JsonPropertyName("clientReference")]
        public string? ClientReference { get; set; }= default!;
    
        /// <summary>Specifies the account from which charges is to be collected.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("chargeDebitAccountId")]
        public string? ChargeDebitAccountId { get; set; }= default!;
    
        /// <summary>Field to state the account from which the provision amount is to be debited</summary>
        [System.Text.Json.Serialization.JsonPropertyName("marginDebitAccount")]
        public string? MarginDebitAccount { get; set; }= default!;
    
        /// <summary>Specifies the account from which the invocation amount is to be debited at the time of settlement of the claim.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("commissionDebitAccountId")]
        public string? CommissionDebitAccountId { get; set; }= default!;
    
        /// <summary>The account from which the invocation amount will be settled</summary>
        [System.Text.Json.Serialization.JsonPropertyName("claimDebitAccount")]
        public string? ClaimDebitAccount { get; set; }= default!;
    
        /// <summary>This field determines whether the shipping guarantee is issued under LC Documents or Import Collection documents. Allowed values: - LC - COLLECTION</summary>
        [System.Text.Json.Serialization.JsonPropertyName("shippingGuaranteeIssuedFor")]
        public string? ShippingGuaranteeIssuedFor { get; set; }= default!;
    
        /// <summary>The ID of the Letter of Credit, to be linked to this Guarantee for the purpose of apportioning the Margin</summary>
        [System.Text.Json.Serialization.JsonPropertyName("collectionReference")]
        public string? CollectionReference { get; set; }= default!;
    
        /// <summary>Holds the attached/uploaded documents.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("supportDocument")]
        public SupportDocument? SupportDocument { get; set; }= default!;
    
        /// <summary>Specifies the reason for request of the guarantee when the system prompts that the limit is exceeded.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("limitExceedReason")]
        public LimitExceedReason? LimitExceedReason { get; set; }= default!;
    
        /// <summary>Field to input queries/clarifications by bank to be sought from Corporate customer on the request.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("messageFromBank")]
        public MessageFromBank? MessageFromBank { get; set; }= default!;
    
        /// <summary>Field to input any additional information/clarifications to be provided to the bank, by Corporate customer.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("messageFromCustomer")]
        public MessageFromCustomer? MessageFromCustomer { get; set; }= default!;
    
        /// <summary>Field to input any information that needs to be provided with regard to the issuance of guarantee.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("otherInformation")]
        public OtherInformation? OtherInformation { get; set; }= default!;
    
        /// <summary>Specifies the status of the request.Allowed values are - With Bank_With Customer_Approved_Rejected.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("eventStatus")]
        public string? EventStatus { get; set; }= default!;
    
        /// <summary>Current Number which indicates how many times the record is modified.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currNo")]
        public string? CurrNo { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BeneficiaryId 
    {
        /// <summary>Indicates the Id of beneficiary when beneficiary details are stored</summary>
        [System.Text.Json.Serialization.JsonPropertyName("beneficiaryId")]
        public string? BeneficiaryId1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DetailOfGuarantee 
    {
        /// <summary>This field contains all terms, conditions and details of the guarantee undertaking. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("detailOfGuarantee")]
        public string? DetailOfGuarantee1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SupportDocument 
    {
        /// <summary>Holds the attached/uploaded documents.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("supportDocument")]
        public string? SupportDocument1 { get; set; }= default!;
    
        /// <summary>The accepted forms of identification taken by the bank when enrolling a Customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("documentName")]
        public string? DocumentName { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class LimitExceedReason 
    {
        /// <summary>Specifies the reason for request of the guarantee when the system prompts that the limit is exceeded.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("limitExceedReason")]
        public string? LimitExceedReason1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class MessageFromBank 
    {
        /// <summary>Field to input queries/clarifications by bank to be sought from Corporate customer on the request.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("messageFromBank")]
        public string? MessageFromBank1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class MessageFromCustomer 
    {
        /// <summary>Field to input any additional information/clarifications to be provided to the bank, by Corporate customer.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("messageFromCustomer")]
        public string? MessageFromCustomer1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class OtherInformation 
    {
        /// <summary>Field to input any information that needs to be provided with regard to the issuance of guarantee.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("otherInformation")]
        public string? OtherInformation1 { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016