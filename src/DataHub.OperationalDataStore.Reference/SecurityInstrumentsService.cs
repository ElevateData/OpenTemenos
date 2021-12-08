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

namespace DataHub.OperationalDataStore.Reference.SecurityInstruments
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface ISecurityInstrumentsService
    {
        /// <summary>Retrieves the details of all securities such as Id, fixed offer price, Security description, stock exchange code, IPO book start date, IPO book end date, IPO lot size, price currency code, minimum bid price, maximum bid price</summary>
        /// <param name="ipoStatus">Indicates the IPO is open, closed, alloted, listed, reopened and so on</param>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <param name="startDate">Contains the date on which the transaction or payment gets initiated.</param>
        /// <param name="endDate">Indicates the date till which the transaction history requested. If 20120101 is the start date and 20120201 is the end date, all transactions that are booked between January 1 to February 1 2012 are returned</param>
        /// <returns>getActiveIPOsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetActiveIPOsResponse> GetActiveIPOsAsync(string? ipoStatus, string? recordId, System.DateTimeOffset? startDate, System.DateTimeOffset? endDate);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the details of all securities such as Id, fixed offer price, Security description, stock exchange code, IPO book start date, IPO book end date, IPO lot size, price currency code, minimum bid price, maximum bid price</summary>
        /// <param name="ipoStatus">Indicates the IPO is open, closed, alloted, listed, reopened and so on</param>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <param name="startDate">Contains the date on which the transaction or payment gets initiated.</param>
        /// <param name="endDate">Indicates the date till which the transaction history requested. If 20120101 is the start date and 20120201 is the end date, all transactions that are booked between January 1 to February 1 2012 are returned</param>
        /// <returns>getActiveIPOsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetActiveIPOsResponse> GetActiveIPOsAsync(string? ipoStatus, string? recordId, System.DateTimeOffset? startDate, System.DateTimeOffset? endDate, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieves the International security identification number details of all securities</summary>
        /// <param name="instrumentType">Indicates the type of the security</param>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <param name="instrumentCurrencyId">The currency of the instrument</param>
        /// <param name="mnemonic">Shortcut code for referring an Entity/Company/Branch.</param>
        /// <param name="subAssetType">Contains a further definition of an asset</param>
        /// <param name="priceType">Defines the method to be used when calculating the price of a trade</param>
        /// <param name="iSIN">The International Securities Identification Number of the instrument</param>
        /// <param name="stockExchange">The stock exchange identifier</param>
        /// <param name="depositoryId">Id of the securities depository.</param>
        /// <returns>getInstrumentsBondsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetInstrumentsBondsResponse> GetInstrumentsBondsAsync(string? instrumentType, string? recordId, string? instrumentCurrencyId, string? mnemonic, string? subAssetType, string? priceType, string? iSIN, string? stockExchange, string? depositoryId);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the International security identification number details of all securities</summary>
        /// <param name="instrumentType">Indicates the type of the security</param>
        /// <param name="recordId">Unique identifier of an entity</param>
        /// <param name="instrumentCurrencyId">The currency of the instrument</param>
        /// <param name="mnemonic">Shortcut code for referring an Entity/Company/Branch.</param>
        /// <param name="subAssetType">Contains a further definition of an asset</param>
        /// <param name="priceType">Defines the method to be used when calculating the price of a trade</param>
        /// <param name="iSIN">The International Securities Identification Number of the instrument</param>
        /// <param name="stockExchange">The stock exchange identifier</param>
        /// <param name="depositoryId">Id of the securities depository.</param>
        /// <returns>getInstrumentsBondsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetInstrumentsBondsResponse> GetInstrumentsBondsAsync(string? instrumentType, string? recordId, string? instrumentCurrencyId, string? mnemonic, string? subAssetType, string? priceType, string? iSIN, string? stockExchange, string? depositoryId, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieves the contract definitions such as contract code, description of all the FUTURE contract types</summary>
        /// <param name="contractType">Indicates the type of contract that has been traded on an exchange</param>
        /// <returns>getFutureContractsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetFutureContractsResponse> GetFutureContractsAsync(string? contractType);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the contract definitions such as contract code, description of all the FUTURE contract types</summary>
        /// <param name="contractType">Indicates the type of contract that has been traded on an exchange</param>
        /// <returns>getFutureContractsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetFutureContractsResponse> GetFutureContractsAsync(string? contractType, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieves the contract definitions such as contract code, description of all the OPTION contract types</summary>
        /// <param name="contractType">Indicates the type of contract that has been traded on an exchange</param>
        /// <returns>getOptionContractsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetOptionContractsResponse> GetOptionContractsAsync(string? contractType);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the contract definitions such as contract code, description of all the OPTION contract types</summary>
        /// <param name="contractType">Indicates the type of contract that has been traded on an exchange</param>
        /// <returns>getOptionContractsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetOptionContractsResponse> GetOptionContractsAsync(string? contractType, System.Threading.CancellationToken cancellationToken);
    
    }

    /// <summary>getActiveIPOsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetActiveIPOsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetActiveIPOsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetActiveIPOsResponseBody 
    {
        /// <summary>File is used to record and maintain details of all securities opened within the Securities module</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityMaster")]
        public System.Collections.Generic.ICollection<SecurityMaster>? SecurityMaster { get; set; }= default!;
    
    
    }
    
    /// <summary>getInstrumentsBondsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetInstrumentsBondsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetInstrumentsBondsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetInstrumentsBondsResponseBody 
    {
        /// <summary>File is used to record and maintain details of all securities opened within the Securities module</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityMaster")]
        public System.Collections.Generic.ICollection<SecurityMaster2>? SecurityMaster { get; set; }= default!;
    
    
    }
    
    /// <summary>getFutureContractsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetFutureContractsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetFutureContractsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetFutureContractsResponseBody 
    {
        /// <summary>Holds the contract definitions of all of the contract types tradable in the derivatives module</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractMaster")]
        public System.Collections.Generic.ICollection<ContractMaster>? ContractMaster { get; set; }= default!;
    
    
    }
    
    /// <summary>getOptionContractsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetOptionContractsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetOptionContractsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetOptionContractsResponseBody 
    {
        /// <summary>Holds the contract definitions of all of the contract types tradable in the derivatives module</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractMaster")]
        public System.Collections.Generic.ICollection<ContractMaster2>? ContractMaster { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SecurityMaster 
    {
        /// <summary>Unique identifier of an entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordId")]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Language specific fields will be displayed under this entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("language")]
        public Language? Language { get; set; }= default!;
    
        /// <summary>The stock exchange identifier</summary>
        [System.Text.Json.Serialization.JsonPropertyName("stockExchange")]
        public string? StockExchange { get; set; }= default!;
    
        /// <summary>Contains the date on which the transaction or payment gets initiated.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public string? StartDate { get; set; }= default!;
    
        /// <summary>Indicates the date till which the transaction history requested. If 20120101 is the start date and 20120201 is the end date, all transactions that are booked between January 1 to February 1 2012 are returned</summary>
        [System.Text.Json.Serialization.JsonPropertyName("endDate")]
        public string? EndDate { get; set; }= default!;
    
        /// <summary>The number of lots/contracts traded</summary>
        [System.Text.Json.Serialization.JsonPropertyName("lot")]
        public string? Lot { get; set; }= default!;
    
        /// <summary>The currency of the Price</summary>
        [System.Text.Json.Serialization.JsonPropertyName("priceCurrency")]
        public string? PriceCurrency { get; set; }= default!;
    
        /// <summary>Minimum price used for bidding in IPO order</summary>
        [System.Text.Json.Serialization.JsonPropertyName("minOfferPrice")]
        public string? MinOfferPrice { get; set; }= default!;
    
        /// <summary> Maximum price allowed to bid in IPO order</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maxOfferPrice")]
        public string? MaxOfferPrice { get; set; }= default!;
    
        /// <summary>Price used in IPO order when the Type of Issue is Single Bid.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("issueOfferPrice")]
        public string? IssueOfferPrice { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SecurityMaster2 
    {
        /// <summary>Unique identifier of an entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordId")]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>The International Securities Identification Number of the instrument</summary>
        [System.Text.Json.Serialization.JsonPropertyName("ISIN")]
        public string? ISIN { get; set; }= default!;
    
        /// <summary>Language specific fields will be displayed under this entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("language")]
        public Language2? Language { get; set; }= default!;
    
        /// <summary>The currency of the instrument</summary>
        [System.Text.Json.Serialization.JsonPropertyName("instrumentCurrencyId")]
        public string? InstrumentCurrencyId { get; set; }= default!;
    
        /// <summary>The stock exchange identifier</summary>
        [System.Text.Json.Serialization.JsonPropertyName("stockExchange")]
        public string? StockExchange { get; set; }= default!;
    
        /// <summary>The currency of the Price</summary>
        [System.Text.Json.Serialization.JsonPropertyName("priceCurrency")]
        public string? PriceCurrency { get; set; }= default!;
    
        /// <summary>Indicates the last recorded price of the instrument</summary>
        [System.Text.Json.Serialization.JsonPropertyName("lastPrice")]
        public string? LastPrice { get; set; }= default!;
    
        /// <summary>Effective Date of Last Price of the Security</summary>
        [System.Text.Json.Serialization.JsonPropertyName("lastPriceDate")]
        public string? LastPriceDate { get; set; }= default!;
    
        /// <summary>Defines the method to be used when calculating the price of a trade</summary>
        [System.Text.Json.Serialization.JsonPropertyName("priceType")]
        public string? PriceType { get; set; }= default!;
    
        /// <summary>Identifies the bid rate of the related currency for the defined time period</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestRate")]
        public InterestRate? InterestRate { get; set; }= default!;
    
        /// <summary>Effective Date of Coupon Rate</summary>
        [System.Text.Json.Serialization.JsonPropertyName("couponDate")]
        public CouponDate? CouponDate { get; set; }= default!;
    
        /// <summary>Component of Bond Security on which the inflation Index is applicable. - Interest - Principal - Both (Interest and Pricipal)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("inflationIndexComponent")]
        public string? InflationIndexComponent { get; set; }= default!;
    
        /// <summary>Indicates maturity date of the contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maturityDate")]
        public string? MaturityDate { get; set; }= default!;
    
        /// <summary>Specifies the smallest nominal amount that may be traded</summary>
        [System.Text.Json.Serialization.JsonPropertyName("tradingUnit")]
        public string? TradingUnit { get; set; }= default!;
    
        /// <summary>Id of the securities depository.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("depositoryId")]
        public string? DepositoryId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ContractMaster 
    {
        /// <summary>Unique identifier of an entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordId")]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Language specific fields will be displayed under this entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("language")]
        public Language3? Language { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ContractMaster2 
    {
        /// <summary>Unique identifier of an entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordId")]
        public string? RecordId { get; set; }= default!;
    
        /// <summary>Language specific fields will be displayed under this entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("language")]
        public Language4? Language { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Language 
    {
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Language2 
    {
        /// <summary>Contains the name of the account, basically the short title of the account.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("shortName")]
        public string? ShortName { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class InterestRate 
    {
        /// <summary>Identifies the bid rate of the related currency for the defined time period</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestRate")]
        public string? InterestRate1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CouponDate 
    {
        /// <summary>Inflation Index to be considered for the Bonds</summary>
        [System.Text.Json.Serialization.JsonPropertyName("inflationIndex")]
        public string? InflationIndex { get; set; }= default!;
    
        /// <summary>Rate at which a periodic payment is made under a bond/security and also in interest rate derivatives such as Interest rate Swaps.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("couponRate")]
        public string? CouponRate { get; set; }= default!;
    
        /// <summary>Effective Date of Coupon Rate</summary>
        [System.Text.Json.Serialization.JsonPropertyName("couponDate")]
        public string? CouponDate1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Language3 
    {
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Language4 
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