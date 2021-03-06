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

namespace DataHub.OperationalDataStore.Reference.HoldTypes
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IHoldTypeService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the available hold types in the system</summary>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <returns>getHoldTypesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetHoldTypesResponse> GetHoldTypesAsync(string? recordId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    /// <summary>getHoldTypesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetHoldTypesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetHoldTypesResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetHoldTypesResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("uscoreHoldParam")]
        public System.Collections.Generic.ICollection<UscoreHoldParam>? UscoreHoldParam { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class UscoreHoldParam 
    {
        /// <summary>Unique identifier of an entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordId")]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Number of days after which expiry date should be set in relation to the transaction date. Accept value is ND, where N is number of days.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("expirationPeriod")]
        public string? ExpirationPeriod { get; set; }= default!;
    
        /// <summary>Specifies the date convention for the maturity date calculation. When DATE.CONVENTION is specified, holiday calendar will be checked against date convention specified for the account. Otherwise the business calendar will be used for checking holidays.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maturityDateConvention")]
        public string? MaturityDateConvention { get; set; }= default!;
    
        /// <summary>Indicates if a full hold has to be placed on the account. When set to Y  any future credits made to be account will be locked automatically</summary>
        [System.Text.Json.Serialization.JsonPropertyName("placeFullHold")]
        public string? PlaceFullHold { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016