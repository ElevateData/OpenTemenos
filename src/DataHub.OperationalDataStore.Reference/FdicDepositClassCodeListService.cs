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

namespace DataHub.OperationalDataStore.Reference.FdicDepositClassCodeList
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IFdicDepositClassCodeListService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the deposit sub-classification codes provied by FDIC</summary>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <returns>getFdicDepositClassCodeListResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetFdicDepositClassCodeListResponse> GetFdicDepositClassCodeListAsync(string? recordId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    /// <summary>getFdicDepositClassCodeListResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetFdicDepositClassCodeListResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetFdicDepositClassCodeListResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetFdicDepositClassCodeListResponseBody 
    {
        /// <summary>Holds the deposit class code and the deposit class type it is linked to.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fdicDepositClassCode")]
        public System.Collections.Generic.ICollection<FdicDepositClassCode>? FdicDepositClassCode { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class FdicDepositClassCode 
    {
        /// <summary>Unique identifier of an entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordId")]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Language specific fields will be displayed under this entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("language")]
        public Language? Language { get; set; }= default!;
    
        /// <summary>Classification type categorizes the fdicclasscode based upton the general purpose of the deposit such as Retail, Commerical, state and federal government etc,.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fdicDepositClassType")]
        public string? FdicDepositClassType { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Language 
    {
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016