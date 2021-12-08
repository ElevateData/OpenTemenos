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

namespace DataHub.AnalyticDataStore.Holding.AccountTransactionMetrics
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IAccountTransactionMetricsService
    {
        /// <summary>Retrieve the number of transactions and the total amount of those transactions grouped by the product hierarchy per customer for a specific business date or for the current date</summary>
        /// <param name="businessDate">Business snapshot date of the source data</param>
        /// <param name="useCurrentDate">Current Date flag for the Business date</param>
        /// <returns>Account transactionsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetAccountTransactionMetricsResponse> GetAccountTransactionMetricsAsync(string? businessDate, string? useCurrentDate);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve the number of transactions and the total amount of those transactions grouped by the product hierarchy per customer for a specific business date or for the current date</summary>
        /// <param name="businessDate">Business snapshot date of the source data</param>
        /// <param name="useCurrentDate">Current Date flag for the Business date</param>
        /// <returns>Account transactionsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetAccountTransactionMetricsResponse> GetAccountTransactionMetricsAsync(string? businessDate, string? useCurrentDate, System.Threading.CancellationToken cancellationToken);
    
    }

    /// <summary>getAccountTransactionMetricsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetAccountTransactionMetricsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetAccountTransactionMetricsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetAccountTransactionMetricsResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("accountTransactionMetrics")]
        public System.Collections.Generic.ICollection<AccountTransactionMetrics>? AccountTransactionMetrics { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AccountTransactionMetrics 
    {
        /// <summary>Business snapshot date of the source data</summary>
        [System.Text.Json.Serialization.JsonPropertyName("businessDate")]
        public string? BusinessDate { get; set; }= default!;
    
        /// <summary>Current Date flag for the Business date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("useCurrentDate")]
        public string? UseCurrentDate { get; set; }= default!;
    
        /// <summary>Grouping of product codes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productGroupCode")]
        public string? ProductGroupCode { get; set; }= default!;
    
        /// <summary>Description of product groups</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productGroupDescription")]
        public string? ProductGroupDescription { get; set; }= default!;
    
        /// <summary>Grouping of product types</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productGroupType")]
        public string? ProductGroupType { get; set; }= default!;
    
        /// <summary>Line code of the product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productLineCode")]
        public string? ProductLineCode { get; set; }= default!;
    
        /// <summary>Line description of the product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productLineDescription")]
        public string? ProductLineDescription { get; set; }= default!;
    
        /// <summary>The code used to identify the type of product the account represents.  This  code is the base for classifying products into  classifications; categories; groups and classes.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productCode")]
        public string? ProductCode { get; set; }= default!;
    
        /// <summary>The description of the product based on the product code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productDescription")]
        public string? ProductDescription { get; set; }= default!;
    
        /// <summary>A classification field for product which is typically less granular than product code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productType")]
        public string? ProductType { get; set; }= default!;
    
        /// <summary>Number of Transactions</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionCount")]
        public string? TransactionCount { get; set; }= default!;
    
        /// <summary>Average Transaction amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionAmountAvg")]
        public string? TransactionAmountAvg { get; set; }= default!;
    
        /// <summary>Contract number of specific savings; chequing; term deposit; loan, letter of credit, etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractNumber")]
        public string? ContractNumber { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016