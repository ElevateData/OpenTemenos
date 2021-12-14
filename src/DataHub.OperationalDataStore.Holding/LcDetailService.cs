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

namespace OpenTemenos.DataHubs.OperationalDataStore.Holding.LcDetails
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface ILcDetailService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the Letter of credit enrichment details</summary>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <returns>getIncoTermsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetIncoTermsResponse> GetIncoTermsAsync(string? recordId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the Letter of credit tenor details</summary>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <returns>getLcTenorsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetLcTenorsResponse> GetLcTenorsAsync(string? recordId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    /// <summary>getIncoTermsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetIncoTermsResponse 
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GetIncoTermsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetIncoTermsResponseBody 
    {
        /// <summary>The file contains enrichment data that the user requires to be displayed when inputting L/C transactions.</summary>
        [Newtonsoft.Json.JsonProperty("lcEnrichment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LcEnrichment>? LcEnrichment { get; set; }= default!;
    
    
    }
    
    /// <summary>getLcTenorsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetLcTenorsResponse 
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GetLcTenorsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetLcTenorsResponseBody 
    {
        /// <summary>Indicates the identifier of payment type enrichment for letter of credit.</summary>
        [Newtonsoft.Json.JsonProperty("lcPayTypeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LcPayTypeId>? LcPayTypeId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class LcEnrichment 
    {
        /// <summary>Unique identifier of an entity</summary>
        [Newtonsoft.Json.JsonProperty("recordId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Language specific fields will be displayed under this entity</summary>
        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Language? Language { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class LcPayTypeId 
    {
        /// <summary>Unique identifier of an entity</summary>
        [Newtonsoft.Json.JsonProperty("recordId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Language specific fields will be displayed under this entity</summary>
        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Language2? Language { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Language 
    {
        /// <summary>This field holds the valid incoterms code</summary>
        [Newtonsoft.Json.JsonProperty("incoTerms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IncoTerms { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Language2 
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