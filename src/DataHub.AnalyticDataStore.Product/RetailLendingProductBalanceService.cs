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

namespace DataHub.AnalyticDataStore.Product.RetailLendingProductBalances
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IRetailLendingProductBalanceService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the retail lending product balances and counts</summary>
        /// <param name="useCurrentDate">Current Date flag for the Business date</param>
        /// <param name="businessDate">Business snapshot date of the source data</param>
        /// <param name="accountClass">Indicates if account is commercial; retail or other</param>
        /// <returns>Retail Lending Product balancesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetRetailLendingProductBalancesResponse> GetRetailLendingProductBalancesAsync(string? useCurrentDate = null, string? businessDate = null, string? accountClass = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    /// <summary>getRetailLendingProductBalancesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetRetailLendingProductBalancesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetRetailLendingProductBalancesResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetRetailLendingProductBalancesResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("customerTransactionSummary")]
        public System.Collections.Generic.ICollection<CustomerTransactionSummary>? CustomerTransactionSummary { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CustomerTransactionSummary 
    {
        /// <summary>Line description of the product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productLineDescription")]
        public string? ProductLineDescription { get; set; }= default!;
    
        /// <summary>Description of product groups</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productGroupDescription")]
        public string? ProductGroupDescription { get; set; }= default!;
    
        /// <summary>Category description for a product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productCategory")]
        public string? ProductCategory { get; set; }= default!;
    
        /// <summary>Indicates if account is commercial; retail or other</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountClass")]
        public string? AccountClass { get; set; }= default!;
    
        /// <summary>Number of Contracts</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractCount")]
        public string? ContractCount { get; set; }= default!;
    
        /// <summary>Number of Contracts New this Month</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractsNewThisMonthCount")]
        public string? ContractsNewThisMonthCount { get; set; }= default!;
    
        /// <summary>Number of Contracts Closed this Month</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractsClosedThisMonthCount")]
        public string? ContractsClosedThisMonthCount { get; set; }= default!;
    
        /// <summary>Total Principal Amount in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalLcyPrincipalAmount")]
        public string? TotalLcyPrincipalAmount { get; set; }= default!;
    
        /// <summary>Average Principal Amount in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("averageLcyPrincipalAmount")]
        public string? AverageLcyPrincipalAmount { get; set; }= default!;
    
        /// <summary>Total Due Amount in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalLcyDueAmount")]
        public string? TotalLcyDueAmount { get; set; }= default!;
    
        /// <summary>Average Total Due Amount in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("averageLcyDueAmount")]
        public string? AverageLcyDueAmount { get; set; }= default!;
    
        /// <summary>Average amount in local currency of the contract's available funds</summary>
        [System.Text.Json.Serialization.JsonPropertyName("averageLcyAvailableFunds")]
        public string? AverageLcyAvailableFunds { get; set; }= default!;
    
        /// <summary>Total amount in local currency of the contract's available funds</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalLcyAvailableFunds")]
        public string? TotalLcyAvailableFunds { get; set; }= default!;
    
        /// <summary>Average amount in local currency of the contract's authorized funds</summary>
        [System.Text.Json.Serialization.JsonPropertyName("averageLcyAuthorizedFunds")]
        public string? AverageLcyAuthorizedFunds { get; set; }= default!;
    
        /// <summary>Total amount in local currency of the contract's authorized funds</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalLcyAuthorizedFunds")]
        public string? TotalLcyAuthorizedFunds { get; set; }= default!;
    
        /// <summary>Number of Delinquent Contracts/Accounts</summary>
        [System.Text.Json.Serialization.JsonPropertyName("deliquentAccounts")]
        public string? DeliquentAccounts { get; set; }= default!;
    
        /// <summary>Average number of days a???loan is delinquent</summary>
        [System.Text.Json.Serialization.JsonPropertyName("averageDelinquentDays")]
        public string? AverageDelinquentDays { get; set; }= default!;
    
        /// <summary>Average Delinquent Amount in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("averageLcyDelinquentAmount")]
        public string? AverageLcyDelinquentAmount { get; set; }= default!;
    
        /// <summary>Total Delinquent Amount in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalLcyDelinquentAmount")]
        public string? TotalLcyDelinquentAmount { get; set; }= default!;
    
        /// <summary>Business snapshot date of the source data</summary>
        [System.Text.Json.Serialization.JsonPropertyName("businessDate")]
        public string? BusinessDate { get; set; }= default!;
    
        /// <summary>Current Date flag for the Business date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("useCurrentDate")]
        public string? UseCurrentDate { get; set; }= default!;
    
        /// <summary>Weighted Average Interest Rate</summary>
        [System.Text.Json.Serialization.JsonPropertyName("averageInterestRate")]
        public string? AverageInterestRate { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016