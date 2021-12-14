//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

using OpenTemenos.Shared.Models;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"

namespace OpenTemenos.DataHubs.AnalyticDataStore.Holding.AccountTransactionMetrics
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IAccountTransactionMetricService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve the number of transactions and the total amount of those transactions grouped by the product hierarchy per customer for a specific business date or for the current date</summary>
        /// <param name="businessDate">Business snapshot date of the source data</param>
        /// <param name="useCurrentDate">Current Date flag for the Business date</param>
        /// <returns>Account transactionsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetAccountTransactionMetricsResponse> GetAccountTransactionMetricsAsync(string? businessDate = null, string? useCurrentDate = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    /// <summary>getAccountTransactionMetricsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetAccountTransactionMetricsResponse 
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GetAccountTransactionMetricsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetAccountTransactionMetricsResponseBody 
    {
        [Newtonsoft.Json.JsonProperty("accountTransactionMetrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AccountTransactionMetrics>? AccountTransactionMetrics { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AccountTransactionMetrics 
    {
        /// <summary>Business snapshot date of the source data</summary>
        [Newtonsoft.Json.JsonProperty("businessDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BusinessDate { get; set; }= default!;
    
        /// <summary>Current Date flag for the Business date</summary>
        [Newtonsoft.Json.JsonProperty("useCurrentDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UseCurrentDate { get; set; }= default!;
    
        /// <summary>Grouping of product codes</summary>
        [Newtonsoft.Json.JsonProperty("productGroupCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductGroupCode { get; set; }= default!;
    
        /// <summary>Description of product groups</summary>
        [Newtonsoft.Json.JsonProperty("productGroupDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductGroupDescription { get; set; }= default!;
    
        /// <summary>Grouping of product types</summary>
        [Newtonsoft.Json.JsonProperty("productGroupType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductGroupType { get; set; }= default!;
    
        /// <summary>Line code of the product</summary>
        [Newtonsoft.Json.JsonProperty("productLineCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductLineCode { get; set; }= default!;
    
        /// <summary>Line description of the product</summary>
        [Newtonsoft.Json.JsonProperty("productLineDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductLineDescription { get; set; }= default!;
    
        /// <summary>The code used to identify the type of product the account represents.  This  code is the base for classifying products into  classifications; categories; groups and classes.</summary>
        [Newtonsoft.Json.JsonProperty("productCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductCode { get; set; }= default!;
    
        /// <summary>The description of the product based on the product code</summary>
        [Newtonsoft.Json.JsonProperty("productDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductDescription { get; set; }= default!;
    
        /// <summary>A classification field for product which is typically less granular than product code</summary>
        [Newtonsoft.Json.JsonProperty("productType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductType { get; set; }= default!;
    
        /// <summary>Number of Transactions</summary>
        [Newtonsoft.Json.JsonProperty("transactionCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TransactionCount { get; set; }= default!;
    
        /// <summary>Average Transaction amount</summary>
        [Newtonsoft.Json.JsonProperty("transactionAmountAvg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TransactionAmountAvg { get; set; }= default!;
    
        /// <summary>Contract number of specific savings; chequing; term deposit; loan, letter of credit, etc.</summary>
        [Newtonsoft.Json.JsonProperty("contractNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContractNumber { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016