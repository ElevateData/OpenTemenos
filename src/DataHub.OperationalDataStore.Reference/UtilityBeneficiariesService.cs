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

namespace DataHub.OperationalDataStore.Reference.UtilityBeneficiaries
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IUtilityBeneficiariesService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the beneficiary informations such as beneficiary Id, nick name, category,  beneficiary account number, sort code, payment amount</summary>
        /// <param name="productName">Product name of the bank for this account, proprietary definition.</param>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <param name="beneficiaryAccountId">Unique account identifier of the beneficiary account number.</param>
        /// <param name="bankSortCode">The sort code or the national clearing code of the beneficiary bank.</param>
        /// <param name="transactionType">Identifies the transaction type applicable to the transaction being processed, i.e. outward or inward payment. For example: ACPX, OTPX etc.</param>
        /// <param name="paymentProduct">Preferred payment product can be specified for Beneficiary. This will be used for defaulting the payment product for specific beneficiary.</param>
        /// <param name="companyName">The company in which payment is processed</param>
        /// <param name="beneficiaryIBAN">International Bank Account Number (IBAN) of the beneficiary account, required only for International transfers/payments outside the Bank. For example: GB98 MIDL07009312345678, FR7630006000011234567890189</param>
        /// <param name="owningCustomerId">This field specifies the customer to which beneficiary is linked to. Allowed only in case of customer defined beneficiaries</param>
        /// <returns>getUtilityBeneficiariesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetUtilityBeneficiariesResponse> GetUtilityBeneficiariesAsync(string? productName = null, string? recordId = null, string? beneficiaryAccountId = null, string? bankSortCode = null, string? transactionType = null, string? paymentProduct = null, string? companyName = null, string? beneficiaryIBAN = null, string? owningCustomerId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    /// <summary>getUtilityBeneficiariesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetUtilityBeneficiariesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetUtilityBeneficiariesResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetUtilityBeneficiariesResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("beneficiaryId")]
        public System.Collections.Generic.ICollection<BeneficiaryId>? BeneficiaryId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BeneficiaryId 
    {
        /// <summary>Unique identifier of an entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordId")]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Product name of the bank for this account, proprietary definition.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productName")]
        public string? ProductName { get; set; }= default!;
    
        /// <summary>Unique account identifier of the beneficiary account number.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("beneficiaryAccountId")]
        public string? BeneficiaryAccountId { get; set; }= default!;
    
        /// <summary>The sort code or the national clearing code of the beneficiary bank. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("bankSortCode")]
        public string? BankSortCode { get; set; }= default!;
    
        /// <summary>Preferred payment product can be specified for Beneficiary. This will be used for defaulting the payment product for specific beneficiary. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentProduct")]
        public string? PaymentProduct { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016