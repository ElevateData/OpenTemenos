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

namespace Transact.Holding.Position
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IPositionService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves cash inflow and outflow positions</summary>
        /// <param name="currency">Identifies the currency. E.g. USD, GBP etc</param>
        /// <param name="dealerDesk">The dealer/desk responsible for monitoring and managing the currency positions.</param>
        /// <param name="currencyMarket">Identifies the currency market to be used to get the correct exchange and revaluation rates to be applied to each currency</param>
        /// <param name="calendar">Identifies the calendar to be used for the spreading of different position data into different time buckets. Ex: CAL-Standard calendar and DE1-Deutsche calendar</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>TreasuryCashPositionResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<TreasuryCashPositionResponse> GetTreasuryCashPositionAsync(string currency, string? dealerDesk = null, string? currencyMarket = null, string? calendar = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, bool? disablePagination = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves interest rate mismatch position</summary>
        /// <param name="currency">Identifies the currency. E.g. USD, GBP etc</param>
        /// <param name="dealerDesk">The dealer/desk responsible for monitoring and managing the currency positions.</param>
        /// <param name="currencyMarket">Identifies the currency market to be used to get the correct exchange and revaluation rates to be applied to each currency</param>
        /// <param name="calendar">Identifies the calendar to be used for the spreading of different position data into different time buckets. Ex: CAL-Standard calendar and DE1-Deutsche calendar</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>TreasuryGapPositionResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<TreasuryGapPositionResponse> GetTreasuryGapPositionAsync(string currency, string? dealerDesk = null, string? currencyMarket = null, string? calendar = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, bool? disablePagination = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the mark to market revaluation of foreign exchange positions.</summary>
        /// <param name="currency">Identifies the currency. E.g. USD, GBP etc</param>
        /// <param name="currencyMarket">Identifies the currency market to be used to get the correct exchange and revaluation rates to be applied to each currency</param>
        /// <param name="dealerDesk">The dealer/desk responsible for monitoring and managing the currency positions.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>ForexRevaluationPositionsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ForexRevaluationPositionsResponse> GetForexRevaluationPositionsAsync(string? currency = null, string? currencyMarket = null, string? dealerDesk = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, bool? disablePagination = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves transaction details resulting daily cash flow, interest rate mismatch and foreign currency positions.</summary>
        /// <param name="transactionId">Unique transaction identifier for retrieving the details of the transaction. For example: FT0102030333 etc.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>TreasuryTransactionDetailsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<TreasuryTransactionDetailsResponse> GetTreasuryTransactionDetailsAsync(string transactionId, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, bool? disablePagination = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class QueryHeader 
    {
        [System.Text.Json.Serialization.JsonPropertyName("audit")]
        public Audit? Audit { get; set; }= default!;
    
        /// <summary>Status of the API(success/failed)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }= default!;
    
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
    
    /// <summary>TreasuryCashPositionResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TreasuryCashPositionResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public TreasuryCashPositionResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TreasuryCashPositionResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
    {
    
    }
    
    /// <summary>BusinessQueryErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BusinessQueryErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public BusinessQueryErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BusinessQueryErrorResponseBody 
    {
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message for bad requests</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type: Business</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>SystemQueryErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SystemQueryErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public SystemQueryErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SystemQueryErrorResponseBody 
    {
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message caused by server</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type: System</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>TreasuryGapPositionResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TreasuryGapPositionResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public TreasuryGapPositionResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TreasuryGapPositionResponseBody : System.Collections.ObjectModel.Collection<Anonymous2>
    {
    
    }
    
    /// <summary>ForexRevaluationPositionsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ForexRevaluationPositionsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public ForexRevaluationPositionsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ForexRevaluationPositionsResponseBody : System.Collections.ObjectModel.Collection<Anonymous3>
    {
    
    }
    
    /// <summary>TreasuryTransactionDetailsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TreasuryTransactionDetailsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public TreasuryTransactionDetailsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TreasuryTransactionDetailsResponseBody : System.Collections.ObjectModel.Collection<Anonymous4>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>Indicates the date on which activity was performed</summary>
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string? Date { get; set; }= default!;
    
        /// <summary>The amount of cash inflow.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("amountIn")]
        public double? AmountIn { get; set; }= default!;
    
        /// <summary>The amount of cash outflow. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("amountOut")]
        public double? AmountOut { get; set; }= default!;
    
        /// <summary>Holds the total amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("netAmount")]
        public double? NetAmount { get; set; }= default!;
    
        /// <summary>The balance amount carried forward for the next period.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("amountCarryForward")]
        public double? AmountCarryForward { get; set; }= default!;
    
        /// <summary>Unique transaction identifier for retrieving the details of the transaction. For example: FT0102030333 etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionIds")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? TransactionIds { get; set; }= default!;
    
    
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
    
        /// <summary>Time taken to parse the request by IRIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("requestParse_time")]
        public double? RequestParse_time { get; set; }= default!;
    
        /// <summary>Time taken to parse the response by IRIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("responseParse_time")]
        public double? ResponseParse_time { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous2 
    {
        /// <summary>Indicates spread of time buckets.Ex: 3M,6M,9M,10Y etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("period")]
        [System.ComponentModel.DataAnnotations.StringLength(8)]
        public string? Period { get; set; }= default!;
    
        /// <summary>The asset amount.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("assetAmount")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 35D)]
        public double? AssetAmount { get; set; }= default!;
    
        /// <summary>Weighted average rate for the asset balance amount.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("assetRate")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 15D)]
        public double? AssetRate { get; set; }= default!;
    
        /// <summary>This is a system populated field that indicates the total liability amount in respect of each issued or confirmed letters of credit</summary>
        [System.Text.Json.Serialization.JsonPropertyName("liabilityAmount")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 35D)]
        public double? LiabilityAmount { get; set; }= default!;
    
        /// <summary>Weighted average rate for the liability balance amount.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("liabilityRate")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 15D)]
        public double? LiabilityRate { get; set; }= default!;
    
        /// <summary>Holds the total amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("netAmount")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 35D)]
        public double? NetAmount { get; set; }= default!;
    
        /// <summary>Rate at which there is no loss or profit.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("breakEvenAmount")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 15D)]
        public double? BreakEvenAmount { get; set; }= default!;
    
        /// <summary>Unique transaction identifier for retrieving the details of the transaction. For example: FT0102030333 etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionIds")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? TransactionIds { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous3 
    {
        /// <summary>Indicates spread of time buckets.Ex: 3M,6M,9M,10Y etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("period")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public string? Period { get; set; }= default!;
    
        /// <summary>Net of buy and sell positions.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("netPosition")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 35D)]
        public double? NetPosition { get; set; }= default!;
    
        /// <summary>Indicates the actual interest rate applied for the account after adjustment/tier calculation/based on basic or Periodic index value</summary>
        [System.Text.Json.Serialization.JsonPropertyName("effectiveRate")]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string? EffectiveRate { get; set; }= default!;
    
        /// <summary>The rate used to revalue the currency positions.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("revaluationRate")]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string? RevaluationRate { get; set; }= default!;
    
        /// <summary>The unrealised profit or loss i.e. Profit or loss arising out of revaluation of open positions.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("unrealProfitLoss")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 35D)]
        public double? UnrealProfitLoss { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous4 
    {
        /// <summary>Indicates the date on which activity was performed</summary>
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? Date { get; set; }= default!;
    
        /// <summary>Unique transaction identifier for retrieving the details of the transaction. For example: FT0102030333 etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        [System.ComponentModel.DataAnnotations.StringLength(16)]
        public string? TransactionId { get; set; }= default!;
    
        /// <summary>Identifies the currency. E.g. USD, GBP etc</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? Currency { get; set; }= default!;
    
        /// <summary>Contains the transaction amount. This is based on the currency, either local or foreign currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionAmount")]
        public double? TransactionAmount { get; set; }= default!;
    
        /// <summary>The total amount of the transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionTotal")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 20D)]
        public double? TransactionTotal { get; set; }= default!;
    
        /// <summary>Total of transaction amount.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalTransactionAmount")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 20D)]
        public double? TotalTransactionAmount { get; set; }= default!;
    
        /// <summary>Total of conversion amounts.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalConversionAmount")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 20D)]
        public double? TotalConversionAmount { get; set; }= default!;
    
        /// <summary>Total for the day.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dailyTotal")]
        [System.ComponentModel.DataAnnotations.Range(double.MinValue, 34D)]
        public double? DailyTotal { get; set; }= default!;
    
    
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