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

namespace Transact.Order.OrderSimulations
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IOrderSimulationsService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the security order simulation</summary>
        /// <returns>SecurityOrderSimulationResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<SecurityOrderSimulationResponse> GetSecurityOrderSimulationAsync(string orderSimulationId, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates the security order simulation</summary>
        /// <param name="payload">body Payload</param>
        /// <param name="validate_only">The identifier to indicate if it is set to only validate or not.</param>
        /// <returns>SecurityOrderSimulationResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<SecurityOrderSimulationResponse> CreateSecurityOrderSimulationAsync(string orderSimulationId, SecurityOrderSimulation payload, bool? validate_only = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PayloadHeader 
    {
        [System.Text.Json.Serialization.JsonPropertyName("override")]
        public Override? Override { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("audit")]
        public Audit? Audit { get; set; }= default!;
    
    
    }
    
    /// <summary>SecurityOrderSimulation</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SecurityOrderSimulation 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public PayloadHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public SecurityOrderSimulationBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SecurityOrderSimulationBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("orderDetails")]
        public System.Collections.Generic.ICollection<OrderDetails>? OrderDetails { get; set; }= default!;
    
        /// <summary>Contains the information about any breach on Collateral</summary>
        [System.Text.Json.Serialization.JsonPropertyName("breachInformations")]
        public System.Collections.Generic.ICollection<BreachInformations>? BreachInformations { get; set; }= default!;
    
        /// <summary>Identifier of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerId")]
        public double? CustomerId { get; set; }= default!;
    
        /// <summary>Id of the portfolio or security account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("portfolioId")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? PortfolioId { get; set; }= default!;
    
        /// <summary>The initial market value for the portfolio before considering the new orders from the session.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("initialMarketValue")]
        public double? InitialMarketValue { get; set; }= default!;
    
        /// <summary>The initial margin value for the portfolio before considering the new orders from the session.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("initialMarginValue")]
        public double? InitialMarginValue { get; set; }= default!;
    
        /// <summary>The initial liability value for the portfolio before considering new orders from the session.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("initialLiabilityPosition")]
        public double? InitialLiabilityPosition { get; set; }= default!;
    
        /// <summary>Collateral Surplus before considering the new orders from this session</summary>
        [System.Text.Json.Serialization.JsonPropertyName("initialCollateralSurplusDeficit")]
        public double? InitialCollateralSurplusDeficit { get; set; }= default!;
    
        /// <summary>The market value for the portfolio after considering the new orders from the session.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("newMarketValue")]
        public double? NewMarketValue { get; set; }= default!;
    
        /// <summary>The margin value for the portfolio after considering the new orders from the session.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("newMarginValue")]
        public double? NewMarginValue { get; set; }= default!;
    
        /// <summary>The liability value for the portfolio after considering the new orders from the session</summary>
        [System.Text.Json.Serialization.JsonPropertyName("newLiabilityPosition")]
        public double? NewLiabilityPosition { get; set; }= default!;
    
        /// <summary>Collateral Surplus after considering the new orders from the session</summary>
        [System.Text.Json.Serialization.JsonPropertyName("collateralSurplusDeficit")]
        public double? CollateralSurplusDeficit { get; set; }= default!;
    
        /// <summary>Set to yes if the Collateral Surplus Deficit is positive</summary>
        [System.Text.Json.Serialization.JsonPropertyName("creditCheck")]
        public bool? CreditCheck { get; set; }= default!;
    
        /// <summary>Checks the Collateral of the Portfolio</summary>
        [System.Text.Json.Serialization.JsonPropertyName("collateralCheck")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? CollateralCheck { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ScreenHeader 
    {
        /// <summary>The Identifier of the record created</summary>
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }= default!;
    
        /// <summary>The status of the record</summary>
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }= default!;
    
        /// <summary>The status of the transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionStatus")]
        public string? TransactionStatus { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("audit")]
        public Audit2? Audit { get; set; }= default!;
    
    
    }
    
    /// <summary>SecurityOrderSimulationResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SecurityOrderSimulationResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ScreenHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public SecurityOrderSimulationResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SecurityOrderSimulationResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("orderDetails")]
        public System.Collections.Generic.ICollection<OrderDetails2>? OrderDetails { get; set; }= default!;
    
        /// <summary>Contains the information about any breach on Collateral</summary>
        [System.Text.Json.Serialization.JsonPropertyName("breachInformations")]
        public System.Collections.Generic.ICollection<BreachInformations2>? BreachInformations { get; set; }= default!;
    
        /// <summary>Identifier of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerId")]
        public double? CustomerId { get; set; }= default!;
    
        /// <summary>Id of the portfolio or security account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("portfolioId")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? PortfolioId { get; set; }= default!;
    
        /// <summary>The initial market value for the portfolio before considering the new orders from the session.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("initialMarketValue")]
        public double? InitialMarketValue { get; set; }= default!;
    
        /// <summary>The initial margin value for the portfolio before considering the new orders from the session.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("initialMarginValue")]
        public double? InitialMarginValue { get; set; }= default!;
    
        /// <summary>The initial liability value for the portfolio before considering new orders from the session.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("initialLiabilityPosition")]
        public double? InitialLiabilityPosition { get; set; }= default!;
    
        /// <summary>Collateral Surplus before considering the new orders from this session</summary>
        [System.Text.Json.Serialization.JsonPropertyName("initialCollateralSurplusDeficit")]
        public double? InitialCollateralSurplusDeficit { get; set; }= default!;
    
        /// <summary>The market value for the portfolio after considering the new orders from the session.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("newMarketValue")]
        public double? NewMarketValue { get; set; }= default!;
    
        /// <summary>The margin value for the portfolio after considering the new orders from the session.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("newMarginValue")]
        public double? NewMarginValue { get; set; }= default!;
    
        /// <summary>The liability value for the portfolio after considering the new orders from the session</summary>
        [System.Text.Json.Serialization.JsonPropertyName("newLiabilityPosition")]
        public double? NewLiabilityPosition { get; set; }= default!;
    
        /// <summary>Collateral Surplus after considering the new orders from the session</summary>
        [System.Text.Json.Serialization.JsonPropertyName("collateralSurplusDeficit")]
        public double? CollateralSurplusDeficit { get; set; }= default!;
    
        /// <summary>Set to yes if the Collateral Surplus Deficit is positive</summary>
        [System.Text.Json.Serialization.JsonPropertyName("creditCheck")]
        public bool? CreditCheck { get; set; }= default!;
    
        /// <summary>Checks the Collateral of the Portfolio</summary>
        [System.Text.Json.Serialization.JsonPropertyName("collateralCheck")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? CollateralCheck { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class OverrideBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("overrideDetails")]
        public System.Collections.Generic.ICollection<OverrideDetails>? OverrideDetails { get; set; }= default!;
    
    
    }
    
    /// <summary>ScreenErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ScreenErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public ScreenErrorResponseBody? Error { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("override")]
        public OverrideBody? Override { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ScreenErrorResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("errorDetails")]
        public System.Collections.Generic.ICollection<ErrorDetails>? ErrorDetails { get; set; }= default!;
    
        /// <summary>The identifier of error type: </summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>BusinessScreenErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BusinessScreenErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public BusinessScreenErrorResponseBody? Error { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("override")]
        public OverrideBody? Override { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BusinessScreenErrorResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("errorDetails")]
        public System.Collections.Generic.ICollection<ErrorDetails2>? ErrorDetails { get; set; }= default!;
    
        /// <summary>The identifier of error type: Business</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>SystemScreenErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SystemScreenErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public SystemScreenErrorResponseBody? Error { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("override")]
        public OverrideBody? Override { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SystemScreenErrorResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("errorDetails")]
        public System.Collections.Generic.ICollection<ErrorDetails3>? ErrorDetails { get; set; }= default!;
    
        /// <summary>The identifier of error type: System</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Override 
    {
        [System.Text.Json.Serialization.JsonPropertyName("overrideDetails")]
        public System.Collections.Generic.ICollection<OverrideDetails2>? OverrideDetails { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class OrderDetails 
    {
        /// <summary>The identifier of the instrument</summary>
        [System.Text.Json.Serialization.JsonPropertyName("instrumentId")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? InstrumentId { get; set; }= default!;
    
        /// <summary>The identifier of the contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractId")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? ContractId { get; set; }= default!;
    
        /// <summary>Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? AccountId { get; set; }= default!;
    
        /// <summary>Indicates if the position is related to Loan, Deposit ,FX-Forward/FX-Swap</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractType")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? ContractType { get; set; }= default!;
    
        /// <summary>Indicates whether the transaction is a call or put.  Allowed values: - CALL  - PUT</summary>
        [System.Text.Json.Serialization.JsonPropertyName("callOrPut")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? CallOrPut { get; set; }= default!;
    
        /// <summary>Indicates maturity date of the contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maturityDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? MaturityDate { get; set; }= default!;
    
        /// <summary>ISO Currency code for the bought currency.  </summary>
        [System.Text.Json.Serialization.JsonPropertyName("buyCurrency")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? BuyCurrency { get; set; }= default!;
    
        /// <summary>ISO Currency code for the sold currency.  </summary>
        [System.Text.Json.Serialization.JsonPropertyName("sellCurrency")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? SellCurrency { get; set; }= default!;
    
        /// <summary>Currency in which the market value for the associated position belongs to</summary>
        [System.Text.Json.Serialization.JsonPropertyName("marketValueCurrency")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? MarketValueCurrency { get; set; }= default!;
    
        /// <summary>Market value for the associated position</summary>
        [System.Text.Json.Serialization.JsonPropertyName("marketValue")]
        public double? MarketValue { get; set; }= default!;
    
        /// <summary>Margin value for the associated position</summary>
        [System.Text.Json.Serialization.JsonPropertyName("marginValue")]
        public double? MarginValue { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BreachInformations 
    {
        /// <summary>Contains the information about any breach on Collateral</summary>
        [System.Text.Json.Serialization.JsonPropertyName("breachInformation")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? BreachInformation { get; set; }= default!;
    
    
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
        public int? RequestParse_time { get; set; }= default!;
    
        /// <summary>Time taken to parse the response by IRIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("responseParse_time")]
        public int? ResponseParse_time { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class OrderDetails2 
    {
        /// <summary>The identifier of the instrument</summary>
        [System.Text.Json.Serialization.JsonPropertyName("instrumentId")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? InstrumentId { get; set; }= default!;
    
        /// <summary>The identifier of the contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractId")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? ContractId { get; set; }= default!;
    
        /// <summary>Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? AccountId { get; set; }= default!;
    
        /// <summary>Indicates if the position is related to Loan, Deposit ,FX-Forward/FX-Swap</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractType")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? ContractType { get; set; }= default!;
    
        /// <summary>Indicates whether the transaction is a call or put.  Allowed values: - CALL  - PUT</summary>
        [System.Text.Json.Serialization.JsonPropertyName("callOrPut")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? CallOrPut { get; set; }= default!;
    
        /// <summary>Indicates maturity date of the contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maturityDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? MaturityDate { get; set; }= default!;
    
        /// <summary>ISO Currency code for the bought currency.  </summary>
        [System.Text.Json.Serialization.JsonPropertyName("buyCurrency")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? BuyCurrency { get; set; }= default!;
    
        /// <summary>ISO Currency code for the sold currency.  </summary>
        [System.Text.Json.Serialization.JsonPropertyName("sellCurrency")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? SellCurrency { get; set; }= default!;
    
        /// <summary>Currency in which the market value for the associated position belongs to</summary>
        [System.Text.Json.Serialization.JsonPropertyName("marketValueCurrency")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? MarketValueCurrency { get; set; }= default!;
    
        /// <summary>Market value for the associated position</summary>
        [System.Text.Json.Serialization.JsonPropertyName("marketValue")]
        public double? MarketValue { get; set; }= default!;
    
        /// <summary>Margin value for the associated position</summary>
        [System.Text.Json.Serialization.JsonPropertyName("marginValue")]
        public double? MarginValue { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BreachInformations2 
    {
        /// <summary>Contains the information about any breach on Collateral</summary>
        [System.Text.Json.Serialization.JsonPropertyName("breachInformation")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? BreachInformation { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Audit3 
    {
        /// <summary>Time taken to response by T24</summary>
        [System.Text.Json.Serialization.JsonPropertyName("T24_time")]
        public int? T24_time { get; set; }= default!;
    
        /// <summary>The CURR.NO. of the record</summary>
        [System.Text.Json.Serialization.JsonPropertyName("versionNumber")]
        public string? VersionNumber { get; set; }= default!;
    
        /// <summary>Time taken to parse the request by IRIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("requestParse_time")]
        public int? RequestParse_time { get; set; }= default!;
    
        /// <summary>Time taken to parse the response by IRIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("responseParse_time")]
        public int? ResponseParse_time { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class OverrideDetails 
    {
        /// <summary>The identifier of the override</summary>
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }= default!;
    
        /// <summary>The actual override message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }= default!;
    
        /// <summary>The usable options for the override</summary>
        [System.Text.Json.Serialization.JsonPropertyName("options")]
        public System.Collections.Generic.ICollection<string>? Options { get; set; }= default!;
    
        /// <summary>The type of the override</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ErrorDetails 
    {
        /// <summary>The name of the field</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fieldName")]
        public string? FieldName { get; set; }= default!;
    
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message </summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ErrorDetails2 
    {
        /// <summary>The name of the field</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fieldName")]
        public string? FieldName { get; set; }= default!;
    
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message for bad requests</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ErrorDetails3 
    {
        /// <summary>The name of the field</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fieldName")]
        public string? FieldName { get; set; }= default!;
    
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message caused by server</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class OverrideDetails2 
    {
        /// <summary>The identifier of the override</summary>
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }= default!;
    
        /// <summary>The actual override message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }= default!;
    
        /// <summary>The user input to accept/reject the override.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("responseCode")]
        public string? ResponseCode { get; set; }= default!;
    
    
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