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

namespace Transact.Holding.Deposits
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IDepositService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the deposit Overview</summary>
        /// <param name="depositId">Indicates the Id of the deposit account</param>
        /// <param name="balanceTypes">Type of balance (e.g. current balance, credit interest accrued, deferred commission, etc.) as defined in the institution's accounting schemas.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>DepositDetailsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        System.Threading.Tasks.Task<DepositDetailsResponse> GetDepositDetailsAsync(string depositId, string? balanceTypes = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, bool? disablePagination = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    
    /// <summary>DepositDetailsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DepositDetailsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public DepositDetailsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DepositDetailsResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>Indicates the charge types which are applicable for the transaction. Example: CORRBKCHG</summary>
        [System.Text.Json.Serialization.JsonPropertyName("chargeTypes")]
        public System.Collections.Generic.ICollection<ChargeTypes>? ChargeTypes { get; set; }= default!;
    
        /// <summary>Indicates tax charged to an account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("taxRates")]
        public System.Collections.Generic.ICollection<TaxRates>? TaxRates { get; set; }= default!;
    
        /// <summary>The charges or fees for this transaction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("charges")]
        public System.Collections.Generic.ICollection<Charges>? Charges { get; set; }= default!;
    
        /// <summary>Indicates settlement conditions associated with the account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("settlements")]
        public System.Collections.Generic.ICollection<Settlements>? Settlements { get; set; }= default!;
    
        /// <summary>Indicates an unique identifier of an account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("arrangementId")]
        public string? ArrangementId { get; set; }= default!;
    
        /// <summary>Identifier of the currency. This is the 3-letter ISO 4217 code of the currency.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currencyId")]
        public string? CurrencyId { get; set; }= default!;
    
        /// <summary>Contains the date on which the transaction or payment gets initiated.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("startDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? StartDate { get; set; }= default!;
    
        /// <summary>Indicates maturity date of the contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maturityDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? MaturityDate { get; set; }= default!;
    
        /// <summary>Indicates a date or period within which an account gets matured</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maturesIn")]
        public string? MaturesIn { get; set; }= default!;
    
        /// <summary>Indicates cooling off period for an account until which pre-closure can be triggered without incurring any fees or charges.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("coolingOffDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? CoolingOffDate { get; set; }= default!;
    
        /// <summary>Indicates the period to which the BID and OFFER rates apply</summary>
        [System.Text.Json.Serialization.JsonPropertyName("term")]
        public string? Term { get; set; }= default!;
    
        /// <summary>The monetary amount applied to the account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("termAmount")]
        public double? TermAmount { get; set; }= default!;
    
        /// <summary>Indicates the Period beyond which a contract is cancelled if it not fully funded in case of deposit or fully disbursed in case of the loan</summary>
        [System.Text.Json.Serialization.JsonPropertyName("cancellationPeriod")]
        public string? CancellationPeriod { get; set; }= default!;
    
        /// <summary>Indicates the early redemption fee that is associated during closure before account maturity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("earlyRedemptionFee")]
        public double? EarlyRedemptionFee { get; set; }= default!;
    
        /// <summary>Indicates fee charged for the withdrawals</summary>
        [System.Text.Json.Serialization.JsonPropertyName("withdrawalFee")]
        public string? WithdrawalFee { get; set; }= default!;
    
        /// <summary>Identifies the bid rate of the related currency for the defined time period</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestRate")]
        public string? InterestRate { get; set; }= default!;
    
        /// <summary>Indicates interest accumulated for an account for the defined time period</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accrualAmount")]
        public double? AccrualAmount { get; set; }= default!;
    
        /// <summary>The amount of interest that has been accrued</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accruedInterest")]
        public double? AccruedInterest { get; set; }= default!;
    
        /// <summary>Indicates if the payment is Customer (C) type or Bank (B) type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentType")]
        public string? PaymentType { get; set; }= default!;
    
        /// <summary>Indicates the number of days within which an contract gets matured</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maturityInDays")]
        public string? MaturityInDays { get; set; }= default!;
    
        /// <summary>Indicates number of days remaining for maturity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("remainingMaturityInDays")]
        public string? RemainingMaturityInDays { get; set; }= default!;
    
        /// <summary>Indicates the total amount which will be lent or deposited for the term</summary>
        [System.Text.Json.Serialization.JsonPropertyName("commitmentAmount")]
        public double? CommitmentAmount { get; set; }= default!;
    
        /// <summary>Indicates the amount expected to be deposited by the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("expectedBalance")]
        public double? ExpectedBalance { get; set; }= default!;
    
        /// <summary>Flag to indicate whether withdrawals are applicable for the account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("allowWithdrawal")]
        public string? AllowWithdrawal { get; set; }= default!;
    
        /// <summary>Indicates an unallocated credit amount to an account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("unspecifiedCredit")]
        public double? UnspecifiedCredit { get; set; }= default!;
    
        /// <summary>Flag to indicate whether deposit is allowed to an account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("allowDeposit")]
        public string? AllowDeposit { get; set; }= default!;
    
        /// <summary>Flag to indicate whether withdrawals are allowed to an unallocated fund available in the account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("allowWithdrawalUnclearedCredit")]
        public string? AllowWithdrawalUnclearedCredit { get; set; }= default!;
    
        /// <summary>This is the BIC code of the institution where beneficiary holds an account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountWithBankBIC")]
        public string? AccountWithBankBIC { get; set; }= default!;
    
        /// <summary>Indicates the sum of debit transaction amounts that are yet to be processed and placed as holds on accounts, but will not be available for use</summary>
        [System.Text.Json.Serialization.JsonPropertyName("pendingDeposit")]
        public double? PendingDeposit { get; set; }= default!;
    
        /// <summary>Name of the customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerName")]
        public string? CustomerName { get; set; }= default!;
    
        /// <summary>Contains the total number of credits</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalCredits")]
        public string? TotalCredits { get; set; }= default!;
    
        /// <summary>Contains the total number of debits</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalDebits")]
        public string? TotalDebits { get; set; }= default!;
    
        /// <summary>Name of Joint Customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("jointCustomerName")]
        public string? JointCustomerName { get; set; }= default!;
    
        /// <summary>Indicates the total amount which will be lent or deposited for the term</summary>
        [System.Text.Json.Serialization.JsonPropertyName("commitmentBalance")]
        public double? CommitmentBalance { get; set; }= default!;
    
        /// <summary>Indicates the original total paid amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("lastPaidAmount")]
        public double? LastPaidAmount { get; set; }= default!;
    
        /// <summary>Date last payment was made</summary>
        [System.Text.Json.Serialization.JsonPropertyName("lastPaidDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? LastPaidDate { get; set; }= default!;
    
        /// <summary>Indicates the total due amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalDueAmount")]
        public double? TotalDueAmount { get; set; }= default!;
    
        /// <summary>Contains the total withdrawal amount on hold until payment execution date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("pendingWithdrawals")]
        public double? PendingWithdrawals { get; set; }= default!;
    
    
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
    public partial class ChargeTypes 
    {
        /// <summary>Indicates the charge types which are applicable for the transaction. Example: CORRBKCHG</summary>
        [System.Text.Json.Serialization.JsonPropertyName("chargeType")]
        public string? ChargeType { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TaxRates 
    {
        /// <summary>Indicates tax charged to an account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("taxRate")]
        public string? TaxRate { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Charges 
    {
        /// <summary>The frequency at which a payment is required to be generated</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentFrequency")]
        public string? PaymentFrequency { get; set; }= default!;
    
        /// <summary>Indicates Payment type set to an account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentTypeName")]
        public string? PaymentTypeName { get; set; }= default!;
    
        /// <summary>Indicates the Id of the product property</summary>
        [System.Text.Json.Serialization.JsonPropertyName("propertyName")]
        public string? PropertyName { get; set; }= default!;
    
        /// <summary>Method chosen to make the payment</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }= default!;
    
        /// <summary>Indicates the payment frequency associated with the charge</summary>
        [System.Text.Json.Serialization.JsonPropertyName("chargeSchedulePaymentValue")]
        public string? ChargeSchedulePaymentValue { get; set; }= default!;
    
        /// <summary>Interest accrued for the specified period</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dividentPaidYtd")]
        public double? DividentPaidYtd { get; set; }= default!;
    
        /// <summary>Deprecated - Interest accrued for the specified period</summary>
        [System.Text.Json.Serialization.JsonPropertyName("lastPaidDivident")]
        public double? LastPaidDivident { get; set; }= default!;
    
        /// <summary>Indicates the end date of the interest period</summary>
        [System.Text.Json.Serialization.JsonPropertyName("periodEnding")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? PeriodEnding { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Settlements 
    {
        /// <summary>Flag to indicate whether Payin Settlement instruction is required or not.Valid input is Yes or No.Default value is Yes.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("payinSettlement")]
        public string? PayinSettlement { get; set; }= default!;
    
        /// <summary>Indicates the Payin Settlement Account. The account from which funds are to be debited against the payment type.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("payinAccountId")]
        public string? PayinAccountId { get; set; }= default!;
    
        /// <summary>Flag to indicate whether Payout Settlement instruction is required or not.Valid input is Yes or No.Default value is Yes.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("payoutSettlement")]
        public string? PayoutSettlement { get; set; }= default!;
    
        /// <summary>Indicates the Payout Settlement Account. The account into which funds are to be credited against the payment type.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("payoutAccountId")]
        public string? PayoutAccountId { get; set; }= default!;
    
        /// <summary>The identifier of the product condition</summary>
        [System.Text.Json.Serialization.JsonPropertyName("propertyId")]
        public string? PropertyId { get; set; }= default!;
    
        /// <summary>The identifier of a condition that is used to build a product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("propertyClassId")]
        public string? PropertyClassId { get; set; }= default!;
    
    
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