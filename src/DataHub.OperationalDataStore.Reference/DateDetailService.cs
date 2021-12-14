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

namespace OpenTemenos.DataHubs.OperationalDataStore.Reference.DateDetails
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IDateDetailService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the details of date for a specific company identifier</summary>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <param name="currentWorkingDate">Date of the current business day for all online activities in the selected Company. This field is updated automatically with the date from 'nextWorkingDay' during the Close of Business processing.</param>
        /// <param name="lastWorkingDate">Date of the last business day processed for this Company. This field will be set with the date from Today table by the batch (overnight) processing system.</param>
        /// <param name="nextWorkingDate">Date of the next business day which will be processed in this Company.</param>
        /// <returns>getDatesByCompanyResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetDatesByCompanyResponse> GetDatesByCompanyAsync(string recordId, System.DateTimeOffset? currentWorkingDate = null, System.DateTimeOffset? lastWorkingDate = null, System.DateTimeOffset? nextWorkingDate = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the run dates informations such as the previous, the current and the next working days of all legal entities</summary>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <param name="nextWorkingDate">Date of the next business day which will be processed in this Company.</param>
        /// <param name="lastWorkingDate">Date of the last business day processed for this Company. This field will be set with the date from Today table by the batch (overnight) processing system.</param>
        /// <returns>getDatesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetDatesResponse> GetDatesAsync(string? recordId = null, System.DateTimeOffset? nextWorkingDate = null, System.DateTimeOffset? lastWorkingDate = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    /// <summary>getDatesByCompanyResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetDatesByCompanyResponse 
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GetDatesByCompanyResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetDatesByCompanyResponseBody 
    {
        [Newtonsoft.Json.JsonProperty("dates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Dates>? Dates { get; set; }= default!;
    
    
    }
    
    /// <summary>getDatesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetDatesResponse 
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GetDatesResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetDatesResponseBody 
    {
        [Newtonsoft.Json.JsonProperty("dates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Dates2>? Dates { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Dates 
    {
        /// <summary>Unique identifier of an entity</summary>
        [Newtonsoft.Json.JsonProperty("recordId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Date of the current business day for all online activities in the selected Company. This field is updated automatically with the date from 'nextWorkingDay' during the Close of Business processing.</summary>
        [Newtonsoft.Json.JsonProperty("currentWorkingDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrentWorkingDate { get; set; }= default!;
    
        /// <summary>Date of the last business day processed for this Company. This field will be set with the date from Today table by the batch (overnight) processing system.</summary>
        [Newtonsoft.Json.JsonProperty("lastWorkingDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LastWorkingDate { get; set; }= default!;
    
        /// <summary>Date of the next business day which will be processed in this Company.</summary>
        [Newtonsoft.Json.JsonProperty("nextWorkingDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NextWorkingDate { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Dates2 
    {
        /// <summary>Unique identifier of an entity</summary>
        [Newtonsoft.Json.JsonProperty("recordId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Date of the last business day processed for this Company. This field will be set with the date from Today table by the batch (overnight) processing system.</summary>
        [Newtonsoft.Json.JsonProperty("lastWorkingDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LastWorkingDate { get; set; }= default!;
    
        /// <summary>Date of the next business day which will be processed in this Company.</summary>
        [Newtonsoft.Json.JsonProperty("nextWorkingDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NextWorkingDate { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016