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

namespace DataHub.AnalyticDataStore.Product.RetailDepositProductBalances
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IRetailDepositProductBalancesService
    {
        /// <summary>Retrieves the retail deposit balances and counts</summary>
        /// <param name="useCurrentDate">Current Date flag for the Business date</param>
        /// <param name="businessDate">Business snapshot date of the source data</param>
        /// <returns>Retail Deposit Product balancesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetRetailDepositProductBalancesResponse> GetRetailDepositProductBalancesAsync(string? useCurrentDate, string? businessDate);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the retail deposit balances and counts</summary>
        /// <param name="useCurrentDate">Current Date flag for the Business date</param>
        /// <param name="businessDate">Business snapshot date of the source data</param>
        /// <returns>Retail Deposit Product balancesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetRetailDepositProductBalancesResponse> GetRetailDepositProductBalancesAsync(string? useCurrentDate, string? businessDate, System.Threading.CancellationToken cancellationToken);
    
    }

    /// <summary>getRetailDepositProductBalancesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetRetailDepositProductBalancesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetRetailDepositProductBalancesResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetRetailDepositProductBalancesResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("depositProductsSummary")]
        public System.Collections.Generic.ICollection<DepositProductsSummary>? DepositProductsSummary { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DepositProductsSummary 
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
    
        /// <summary>Total Balance in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalLcyBalance")]
        public string? TotalLcyBalance { get; set; }= default!;
    
        /// <summary>Number of Contracts</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractCount")]
        public string? ContractCount { get; set; }= default!;
    
        /// <summary>Number of Contracts New this Month</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractsNewThisMonthCount")]
        public string? ContractsNewThisMonthCount { get; set; }= default!;
    
        /// <summary>Number of Contracts Closed this Month</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractsClosedThisMonthCount")]
        public string? ContractsClosedThisMonthCount { get; set; }= default!;
    
        /// <summary>Average Balance in local currency in the last 30 Days</summary>
        [System.Text.Json.Serialization.JsonPropertyName("averageLcyBalance30Days")]
        public string? AverageLcyBalance30Days { get; set; }= default!;
    
        /// <summary>Min Balance in local currency in the last 30 Days</summary>
        [System.Text.Json.Serialization.JsonPropertyName("minimumLcyBalance30Days")]
        public string? MinimumLcyBalance30Days { get; set; }= default!;
    
        /// <summary>Max Balance in local currency in the last 30 Days</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maximumLcyBalance30Days")]
        public string? MaximumLcyBalance30Days { get; set; }= default!;
    
        /// <summary>Average value of the remaining term to the maturity date of the product.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("averageTermToMaturity")]
        public string? AverageTermToMaturity { get; set; }= default!;
    
        /// <summary>Number of Contracts Maturing within 30 days</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractsMaturing30Days")]
        public string? ContractsMaturing30Days { get; set; }= default!;
    
        /// <summary>Number of contracts that are overdrawn</summary>
        [System.Text.Json.Serialization.JsonPropertyName("overdrawnContractsCount")]
        public string? OverdrawnContractsCount { get; set; }= default!;
    
        /// <summary>Total Holds Amount in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalLcyHoldsAmount")]
        public string? TotalLcyHoldsAmount { get; set; }= default!;
    
        /// <summary>Average Total Holds Amount in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("averageLcyHoldsAmount")]
        public string? AverageLcyHoldsAmount { get; set; }= default!;
    
        /// <summary>Business snapshot date of the source data</summary>
        [System.Text.Json.Serialization.JsonPropertyName("businessDate")]
        public string? BusinessDate { get; set; }= default!;
    
        /// <summary>Average Overdrawn Amount in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("averageLcyOverdrawnAmount")]
        public string? AverageLcyOverdrawnAmount { get; set; }= default!;
    
        /// <summary>Total Overdrawn Amount in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalLcyOverdrawnAmount")]
        public string? TotalLcyOverdrawnAmount { get; set; }= default!;
    
        /// <summary>Current Date flag for the Business date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("useCurrentDate")]
        public string? UseCurrentDate { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016