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

namespace OpenTemenos.DataHubs.OperationalDataStore.Holding.AccountLists
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IAccountListService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve the list of Nostro accounts</summary>
        /// <returns>getNostroAccountListResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetNostroAccountListResponse> GetNostroAccountListAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve the list of Vostro accounts</summary>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <param name="customerId">Identifier of the customer</param>
        /// <param name="productName">Product name of the bank for this account, proprietary definition.</param>
        /// <param name="currencyId">Identifier of the currency. This is the 3-letter ISO 4217 code of the currency.</param>
        /// <returns>getVostroAccountListResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetVostroAccountListResponse> GetVostroAccountListAsync(string? recordId = null, string? customerId = null, string? productName = null, string? currencyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    /// <summary>getNostroAccountListResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetNostroAccountListResponse 
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GetNostroAccountListResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetNostroAccountListResponseBody 
    {
        /// <summary>Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</summary>
        [Newtonsoft.Json.JsonProperty("accountId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AccountId>? AccountId { get; set; }= default!;
    
    
    }
    
    /// <summary>getVostroAccountListResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetVostroAccountListResponse 
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GetVostroAccountListResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetVostroAccountListResponseBody 
    {
        /// <summary>Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</summary>
        [Newtonsoft.Json.JsonProperty("accountId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AccountId2>? AccountId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AccountId 
    {
        /// <summary>Unique identifier of an entity</summary>
        [Newtonsoft.Json.JsonProperty("recordId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Product name of the bank for this account, proprietary definition.</summary>
        [Newtonsoft.Json.JsonProperty("productName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductName { get; set; }= default!;
    
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [Newtonsoft.Json.JsonProperty("displayName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DisplayName? DisplayName { get; set; }= default!;
    
        /// <summary>Identifier of the currency. This is the 3-letter ISO 4217 code of the currency.</summary>
        [Newtonsoft.Json.JsonProperty("currencyId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrencyId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AccountId2 
    {
        /// <summary>Unique identifier of an entity</summary>
        [Newtonsoft.Json.JsonProperty("recordId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [Newtonsoft.Json.JsonProperty("displayName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DisplayName2? DisplayName { get; set; }= default!;
    
        /// <summary>Product name of the bank for this account, proprietary definition.</summary>
        [Newtonsoft.Json.JsonProperty("productName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductName { get; set; }= default!;
    
        /// <summary>Identifier of the customer</summary>
        [Newtonsoft.Json.JsonProperty("customerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CustomerId { get; set; }= default!;
    
        /// <summary>Identifier of the currency. This is the 3-letter ISO 4217 code of the currency.</summary>
        [Newtonsoft.Json.JsonProperty("currencyId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrencyId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DisplayName 
    {
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [Newtonsoft.Json.JsonProperty("displayName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayName1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DisplayName2 
    {
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [Newtonsoft.Json.JsonProperty("displayName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayName { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016