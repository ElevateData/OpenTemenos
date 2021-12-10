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

namespace DataHub.AnalyticDataStore.Holding.AllCustomerProfitabilityMetrics
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IAllCustomerProfitabilityMetricsService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the customer profitability. Filter for a business date or have a default of all customers</summary>
        /// <param name="businessDate">Business snapshot date of the source data</param>
        /// <returns>Customer ProfitabilityResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetAllCustomerProfitabilityMetricsResponse> GetAllCustomerProfitabilityMetricsAsync(string? businessDate = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    /// <summary>getAllCustomerProfitabilityMetricsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetAllCustomerProfitabilityMetricsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetAllCustomerProfitabilityMetricsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetAllCustomerProfitabilityMetricsResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("customer")]
        public System.Collections.Generic.ICollection<Customer>? Customer { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Customer 
    {
        /// <summary>Business snapshot date of the source data</summary>
        [System.Text.Json.Serialization.JsonPropertyName("businessDate")]
        public string? BusinessDate { get; set; }= default!;
    
        /// <summary>Branch Name where Contract was created</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerBranchName")]
        public string? CustomerBranchName { get; set; }= default!;
    
        /// <summary>Marital status of the customer such as single; married; divorced; separated</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maritalStatus")]
        public string? MaritalStatus { get; set; }= default!;
    
        /// <summary>This value is the sum of the MonthlyNetIncome for all accounts for this customer.  Account MonthlyNetIncome is calculated in the InsightPricing module and rolled up to the customer level.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerMonthlyNetIncome")]
        public string? CustomerMonthlyNetIncome { get; set; }= default!;
    
        /// <summary>SpreadRate * Balance.  SpreadRate is calculated in InsightPricing as the difference between the effective rate and the Funds Transfer Rate.  The account values are rolled up to the customer level</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerMonthlySpreadIncome")]
        public string? CustomerMonthlySpreadIncome { get; set; }= default!;
    
        /// <summary>Monthly costs per customer.  This is calculated in InsightPricing from period cost values and transactions costs.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerMonthlyCosts")]
        public string? CustomerMonthlyCosts { get; set; }= default!;
    
        /// <summary>Monthly service fee income from the customer.  This is calculated in InsightPricing from service fees and charges for each account and rolled up to the customer level.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerMonthlyFeeIncome")]
        public string? CustomerMonthlyFeeIncome { get; set; }= default!;
    
        /// <summary>The total number of accounts the customer has</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accounts")]
        public string? Accounts { get; set; }= default!;
    
        /// <summary>The total number of products the customer has.  Each unique classification counts as one product.  Eg. 2 Savings accounts and 2 loan accounts would be 2 products.   Sometimes products such as Membership or Overdrafts are excluded from the count.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("products")]
        public string? Products { get; set; }= default!;
    
        /// <summary>Age Group</summary>
        [System.Text.Json.Serialization.JsonPropertyName("ageGroup")]
        public string? AgeGroup { get; set; }= default!;
    
        /// <summary>The customer number or customer identification number</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerNumber")]
        public string? CustomerNumber { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016