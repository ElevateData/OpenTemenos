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

namespace Transact.Holding.RepurchaseAgreements
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IRepurchaseAgreementsService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Allows to view the Repurchase Agreement Positions</summary>
        /// <param name="positionId">Key or Identifier of the Portfolio Position</param>
        /// <param name="portfolioId">Identifier of the portfolio or security account</param>
        /// <param name="instrumentId">The identifier of the instrument</param>
        /// <param name="depositoryId">Id of the securities depository.</param>
        /// <param name="quantity">The nominal quantity</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <returns>REPOPositionResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<REPOPositionResponse> GetREPOPositionAsync(string? positionId = null, string? portfolioId = null, string? instrumentId = null, string? depositoryId = null, string? quantity = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Allows to view the Reverse Repurchase Agreement Positions</summary>
        /// <param name="positionId">Key or Identifier of the Portfolio Position</param>
        /// <param name="portfolioId">Id of the portfolio or security account</param>
        /// <param name="instrumentId">The identifier of the instrument</param>
        /// <param name="depositoryId">Id of the securities depository.</param>
        /// <param name="quantity">The nominal quantity</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <returns>RESOPositionResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<RESOPositionResponse> GetRESOPositionAsync(string? positionId = null, string? portfolioId = null, string? instrumentId = null, string? depositoryId = null, string? quantity = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Allows to view the Repurchase Agreement Position Movements</summary>
        /// <param name="positionId">Key or Identifier of the Portfolio Position</param>
        /// <param name="portfolioId">Id of the portfolio or security account</param>
        /// <param name="instrumentId">The identifier of the instrument</param>
        /// <param name="depositoryId">Id of the securities depository.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <returns>REPOPositionMovementsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<REPOPositionMovementsResponse> GetREPOPositionMovementsAsync(string? positionId = null, string? portfolioId = null, string? instrumentId = null, string? depositoryId = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Allows to view the Reverse Repurchase Agreement Position Movements</summary>
        /// <param name="positionId">Key or Identifier of the Portfolio Position</param>
        /// <param name="portfolioId">Id of the portfolio or security account</param>
        /// <param name="instrumentId">The identifier of the instrument</param>
        /// <param name="depositoryId">Id of the securities depository.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <returns>RESOPositionMovementsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<RESOPositionMovementsResponse> GetRESOPositionMovementsAsync(string? positionId = null, string? portfolioId = null, string? instrumentId = null, string? depositoryId = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class QueryHeader 
    {
        [System.Text.Json.Serialization.JsonPropertyName("audit")]
        public Audit? Audit { get; set; }= default!;
    
        /// <summary>The total number of records per page</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? Page_size { get; set; }= default!;
    
        /// <summary>The record from which the response should be displayed</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_start")]
        public int? Page_start { get; set; }= default!;
    
        /// <summary>The total number of records present</summary>
        [System.Text.Json.Serialization.JsonPropertyName("total_size")]
        public int? Total_size { get; set; }= default!;
    
        /// <summary>Unique id expected to get as part of response from t24 on every enquiry request</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public string? Page_token { get; set; }= default!;
    
    
    }
    
    /// <summary>REPOPositionResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class REPOPositionResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public REPOPositionResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class REPOPositionResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
    {
    
    }
    
    /// <summary>RESOPositionResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class RESOPositionResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public RESOPositionResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class RESOPositionResponseBody : System.Collections.ObjectModel.Collection<Anonymous2>
    {
    
    }
    
    /// <summary>REPOPositionMovementsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class REPOPositionMovementsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public REPOPositionMovementsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class REPOPositionMovementsResponseBody : System.Collections.ObjectModel.Collection<Anonymous3>
    {
    
    }
    
    /// <summary>RESOPositionMovementsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class RESOPositionMovementsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public RESOPositionMovementsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class RESOPositionMovementsResponseBody : System.Collections.ObjectModel.Collection<Anonymous4>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>Key or Identifier of the Portfolio Position</summary>
        [System.Text.Json.Serialization.JsonPropertyName("positionId")]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public string? PositionId { get; set; }= default!;
    
        /// <summary>Id of the portfolio or security account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("portfolioId")]
        [System.ComponentModel.DataAnnotations.StringLength(14)]
        public string? PortfolioId { get; set; }= default!;
    
        /// <summary>The identifier of the instrument</summary>
        [System.Text.Json.Serialization.JsonPropertyName("instrumentId")]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string? InstrumentId { get; set; }= default!;
    
        /// <summary>Id of the securities depository.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("depositoryId")]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? DepositoryId { get; set; }= default!;
    
        /// <summary>The nominal quantity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Audit2 
    {
        /// <summary>Time taken to response by T24</summary>
        [System.Text.Json.Serialization.JsonPropertyName("T24_time")]
        public int? T24_time { get; set; }= default!;
    
        /// <summary>The CURR.NO. of the record</summary>
        [System.Text.Json.Serialization.JsonPropertyName("versionNumber")]
        public string? VersionNumber { get; set; }= default!;
    
        /// <summary>Time taken to parse the response by IRIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("parse_time")]
        public int? Parse_time { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous2 
    {
        /// <summary>Key or Identifier of the Portfolio Position</summary>
        [System.Text.Json.Serialization.JsonPropertyName("positionId")]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public string? PositionId { get; set; }= default!;
    
        /// <summary>Id of the portfolio or security account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("portfolioId")]
        [System.ComponentModel.DataAnnotations.StringLength(14)]
        public string? PortfolioId { get; set; }= default!;
    
        /// <summary>The identifier of the instrument</summary>
        [System.Text.Json.Serialization.JsonPropertyName("instrumentId")]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string? InstrumentId { get; set; }= default!;
    
        /// <summary>Id of the securities depository.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("depositoryId")]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? DepositoryId { get; set; }= default!;
    
        /// <summary>The nominal quantity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous3 
    {
        /// <summary>The identifier of the contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractId")]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public string? ContractId { get; set; }= default!;
    
        /// <summary>Id of the portfolio or security account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("portfolioId")]
        [System.ComponentModel.DataAnnotations.StringLength(14)]
        public string? PortfolioId { get; set; }= default!;
    
        /// <summary>Identifier of the currency. This is the 3-letter ISO 4217 code of the currency.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currencyId")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? CurrencyId { get; set; }= default!;
    
        /// <summary>Standard date field which records trade date of the account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("tradeDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? TradeDate { get; set; }= default!;
    
        /// <summary>Repurchase date of the REPO contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("repurchaseDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? RepurchaseDate { get; set; }= default!;
    
        /// <summary>The nominal quantity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }= default!;
    
        /// <summary>The identifier of the counter party</summary>
        [System.Text.Json.Serialization.JsonPropertyName("counterpartyId")]
        [System.ComponentModel.DataAnnotations.StringLength(16)]
        public string? CounterpartyId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous4 
    {
        /// <summary>The identifier of the contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractId")]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public string? ContractId { get; set; }= default!;
    
        /// <summary>Id of the portfolio or security account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("portfolioId")]
        [System.ComponentModel.DataAnnotations.StringLength(14)]
        public string? PortfolioId { get; set; }= default!;
    
        /// <summary>Identifier of the currency. This is the 3-letter ISO 4217 code of the currency.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currencyId")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? CurrencyId { get; set; }= default!;
    
        /// <summary>Standard date field which records trade date of the account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("tradeDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? TradeDate { get; set; }= default!;
    
        /// <summary>Repurchase date of the REPO contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("repurchaseDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? RepurchaseDate { get; set; }= default!;
    
        /// <summary>The nominal quantity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }= default!;
    
        /// <summary>The identifier of the counter party</summary>
        [System.Text.Json.Serialization.JsonPropertyName("counterpartyId")]
        [System.ComponentModel.DataAnnotations.StringLength(14)]
        public string? CounterpartyId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    internal class DateFormatConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public DateFormatConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016