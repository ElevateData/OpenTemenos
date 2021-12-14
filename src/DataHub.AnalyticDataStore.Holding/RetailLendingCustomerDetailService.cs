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

namespace OpenTemenos.DataHubs.AnalyticDataStore.Holding.RetailLendingCustomerDetails
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IRetailLendingCustomerDetailService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves lending accounts/contracts details with customer information for a specific business date or for the current date</summary>
        /// <param name="businessDate">Business snapshot date of the source data</param>
        /// <param name="useCurrentDate">Current Date flag for the Business date</param>
        /// <returns>Lending Customer balancesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetRetailLendingCustomerDetailsResponse> GetRetailLendingCustomerDetailsAsync(string? businessDate = null, string? useCurrentDate = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    /// <summary>getRetailLendingCustomerDetailsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetRetailLendingCustomerDetailsResponse 
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GetRetailLendingCustomerDetailsResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetRetailLendingCustomerDetailsResponseBody 
    {
        [Newtonsoft.Json.JsonProperty("lendingCustomerAccountDetails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LendingCustomerAccountDetails>? LendingCustomerAccountDetails { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class LendingCustomerAccountDetails 
    {
        /// <summary>Indicates if account is commercial; retail or other</summary>
        [Newtonsoft.Json.JsonProperty("accountClass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AccountClass { get; set; }= default!;
    
        /// <summary>The affluent bucket of total balance to identify customer segment</summary>
        [Newtonsoft.Json.JsonProperty("affluentSegment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AffluentSegment { get; set; }= default!;
    
        /// <summary>Age Group</summary>
        [Newtonsoft.Json.JsonProperty("ageGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AgeGroup { get; set; }= default!;
    
        /// <summary>The amortization maturity date.</summary>
        [Newtonsoft.Json.JsonProperty("amortizationMatureDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AmortizationMatureDate { get; set; }= default!;
    
        /// <summary>Authorized amount (approved credit limit of the loan; mortgage or LOC)</summary>
        [Newtonsoft.Json.JsonProperty("authorizedAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AuthorizedAmount { get; set; }= default!;
    
        /// <summary>Authorized amount in local currency (approved credit limit of the loan; mortgage or LOC)</summary>
        [Newtonsoft.Json.JsonProperty("lcyAuthorizedAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LcyAuthorizedAmount { get; set; }= default!;
    
        /// <summary>Current balance of the account in reporting currency.</summary>
        [Newtonsoft.Json.JsonProperty("balance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Balance { get; set; }= default!;
    
        /// <summary>Groups based on balance</summary>
        [Newtonsoft.Json.JsonProperty("balanceGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BalanceGroup { get; set; }= default!;
    
        /// <summary>Current balance in local currency of the contract</summary>
        [Newtonsoft.Json.JsonProperty("lcyBalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LcyBalance { get; set; }= default!;
    
        /// <summary>The name of the broker for the contract if applicable</summary>
        [Newtonsoft.Json.JsonProperty("brokerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BrokerName { get; set; }= default!;
    
        /// <summary>Business snapshot date of the source data</summary>
        [Newtonsoft.Json.JsonProperty("businessDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BusinessDate { get; set; }= default!;
    
        /// <summary>Date the contract was closed</summary>
        [Newtonsoft.Json.JsonProperty("closedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ClosedDate { get; set; }= default!;
    
        /// <summary>Identifier field with no business meaning - Foreign key linking to Contract to Branch</summary>
        [Newtonsoft.Json.JsonProperty("contractBranchKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContractBranchKey { get; set; }= default!;
    
        /// <summary>Branch name where Contract was created</summary>
        [Newtonsoft.Json.JsonProperty("contractBranchName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContractBranchName { get; set; }= default!;
    
        /// <summary>Branch Number</summary>
        [Newtonsoft.Json.JsonProperty("contractBranchNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContractBranchNumber { get; set; }= default!;
    
        /// <summary>Grouping for delinquency days: 'N/A', '1-29 days', '30-89 days', '90-179 days', '180-364 days', '365-999 days', '1000+ days'</summary>
        [Newtonsoft.Json.JsonProperty("contractDelinquencyDayGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContractDelinquencyDayGroup { get; set; }= default!;
    
        /// <summary>Full name of the employee associated with the Contract</summary>
        [Newtonsoft.Json.JsonProperty("contractEmployeeFullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContractEmployeeFullName { get; set; }= default!;
    
        /// <summary>Identifier field with no business meaning - Foreign key linking to Contract to Employee</summary>
        [Newtonsoft.Json.JsonProperty("contractEmployeeKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContractEmployeeKey { get; set; }= default!;
    
        /// <summary>Employee number of the employee associated with the Contract</summary>
        [Newtonsoft.Json.JsonProperty("contractEmployeeNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContractEmployeeNumber { get; set; }= default!;
    
        /// <summary>Contract number of specific savings; chequing; term deposit; loan, letter of credit, etc.</summary>
        [Newtonsoft.Json.JsonProperty("contractNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContractNumber { get; set; }= default!;
    
        /// <summary>Region of the branch associated with the Contract</summary>
        [Newtonsoft.Json.JsonProperty("contractRegion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContractRegion { get; set; }= default!;
    
        /// <summary>The status of the Contract. i.e Active, Closed, Dormant, Inactive etc</summary>
        [Newtonsoft.Json.JsonProperty("contractStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContractStatus { get; set; }= default!;
    
        /// <summary>The currency type for the contract.  Typically the standard ISO 3 character country code such as CAD; USD; EUR.</summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Currency { get; set; }= default!;
    
        /// <summary>Current Date flag for the Business date</summary>
        [Newtonsoft.Json.JsonProperty("useCurrentDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UseCurrentDate { get; set; }= default!;
    
        /// <summary>A Yes/No flag indicating if the customer has been closed within a month of the business date</summary>
        [Newtonsoft.Json.JsonProperty("customerClosedThisMonth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CustomerClosedThisMonth { get; set; }= default!;
    
        /// <summary>A Yes/No flag indication if the customer has been opened within a month of the business date</summary>
        [Newtonsoft.Json.JsonProperty("customerNewThisMonth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CustomerNewThisMonth { get; set; }= default!;
    
        /// <summary>The classification for the member either retail or commercial</summary>
        [Newtonsoft.Json.JsonProperty("customerClass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CustomerClass { get; set; }= default!;
    
        /// <summary>The customer number or customer identification number</summary>
        [Newtonsoft.Json.JsonProperty("customerNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CustomerNumber { get; set; }= default!;
    
        /// <summary>Date Customer started with�the FI�(customer opened date)</summary>
        [Newtonsoft.Json.JsonProperty("customerStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CustomerStartDate { get; set; }= default!;
    
        /// <summary>The amount that is past due on the loan contract. Immediate payment of this amount is required to put the loan in good standing</summary>
        [Newtonsoft.Json.JsonProperty("delinquentAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DelinquentAmount { get; set; }= default!;
    
        /// <summary>The amount in local currency that is past due on the loan contract. Immediate payment of this amount is required to put the loan in good standing</summary>
        [Newtonsoft.Json.JsonProperty("delinquentAmountLcy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DelinquentAmountLcy { get; set; }= default!;
    
        /// <summary>Number of Days a loan is delinquent</summary>
        [Newtonsoft.Json.JsonProperty("delinquentDays", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DelinquentDays { get; set; }= default!;
    
        /// <summary>Grouping for delinquency days: 'N/A', '1-29 days', '30-89 days', '90-179 days', '180-364 days', '365-999 days', '1000+ days'</summary>
        [Newtonsoft.Json.JsonProperty("delinquencyDayGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DelinquencyDayGroup { get; set; }= default!;
    
        /// <summary>The date that loan has been disbursed/funded. If more than 1 disbursal; this will be the last disbursal date</summary>
        [Newtonsoft.Json.JsonProperty("disburseDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisburseDate { get; set; }= default!;
    
        /// <summary>Drawdown Account</summary>
        [Newtonsoft.Json.JsonProperty("drawdownAccount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DrawdownAccount { get; set; }= default!;
    
        /// <summary>The external risk rating code for the account.  This is typically used for reporting to external regulators.</summary>
        [Newtonsoft.Json.JsonProperty("extenalRiskCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExtenalRiskCode { get; set; }= default!;
    
        /// <summary>The description for the external risk rating code</summary>
        [Newtonsoft.Json.JsonProperty("externalRiskDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExternalRiskDescription { get; set; }= default!;
    
        /// <summary>Indicates if contract interest rate is fixed or variable</summary>
        [Newtonsoft.Json.JsonProperty("fixedOrVariable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FixedOrVariable { get; set; }= default!;
    
        /// <summary>Customer's gender</summary>
        [Newtonsoft.Json.JsonProperty("gender", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Gender { get; set; }= default!;
    
        /// <summary>The generation gap to identify the suitable product for the group of customers</summary>
        [Newtonsoft.Json.JsonProperty("generation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Generation { get; set; }= default!;
    
        /// <summary>Contract interest; not paid</summary>
        [Newtonsoft.Json.JsonProperty("interestAccrued", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestAccrued { get; set; }= default!;
    
        /// <summary>Contract interest in local currency; not paid</summary>
        [Newtonsoft.Json.JsonProperty("interestAccruedLcy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestAccruedLcy { get; set; }= default!;
    
        /// <summary>Interest paid  frequency. Determines when interest is paid to the contract. Entry provides information indicating appropriate frequency.   Ex: Monthend; SemiAnn</summary>
        [Newtonsoft.Json.JsonProperty("interestPaidFreq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestPaidFreq { get; set; }= default!;
    
        /// <summary>The interest rate for the contract</summary>
        [Newtonsoft.Json.JsonProperty("interestRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestRate { get; set; }= default!;
    
        /// <summary>Groups based on account�interest rate�- '0' -.50%; .50 - 1.00%; 1% - 3% etc.</summary>
        [Newtonsoft.Json.JsonProperty("interestRateGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestRateGroup { get; set; }= default!;
    
        /// <summary>Interest rate index Ex:Prime + 1.00. Usually configured on the banking system at the product level; defines the rate.</summary>
        [Newtonsoft.Json.JsonProperty("interestRateIndex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestRateIndex { get; set; }= default!;
    
        /// <summary>Interest Rate Type.</summary>
        [Newtonsoft.Json.JsonProperty("interestRateType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestRateType { get; set; }= default!;
    
        /// <summary>Interest Rate Type Description - LD loans and deps.</summary>
        [Newtonsoft.Json.JsonProperty("interestRateTypeDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestRateTypeDescription { get; set; }= default!;
    
        /// <summary>The contract interest rate variance. Eg. Prime -.50. -.50 is the variance.</summary>
        [Newtonsoft.Json.JsonProperty("interestRateVariance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestRateVariance { get; set; }= default!;
    
        /// <summary>BL Bill Interpolate</summary>
        [Newtonsoft.Json.JsonProperty("interpolate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Interpolate { get; set; }= default!;
    
        /// <summary>Daily interest for an contract on the business date; based on the balance and the rate. Negative if it's a demand contract; positive if it's a loan contract.</summary>
        [Newtonsoft.Json.JsonProperty("interestIncomeOrExpense", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestIncomeOrExpense { get; set; }= default!;
    
        /// <summary>Daily interest in local currency for an contract on the business date; based on the balance and the rate. Negative if it's a demand contract; positive if it's a loan contract.</summary>
        [Newtonsoft.Json.JsonProperty("interestIncomeOrExpenseLcy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestIncomeOrExpenseLcy { get; set; }= default!;
    
        /// <summary>Yes/No flag indicating if the account was closed less than a month before the business date</summary>
        [Newtonsoft.Json.JsonProperty("isClosedThisMonth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IsClosedThisMonth { get; set; }= default!;
    
        /// <summary>Yes/No flag indicating if the account was closed on the business date</summary>
        [Newtonsoft.Json.JsonProperty("isClosedToday", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IsClosedToday { get; set; }= default!;
    
        /// <summary>A Yes/No flag indicating if the account has been opened less than one month before the business date</summary>
        [Newtonsoft.Json.JsonProperty("isNewThisMonth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IsNewThisMonth { get; set; }= default!;
    
        /// <summary>A Yes/No flag indicating if the account has been opened on the business date</summary>
        [Newtonsoft.Json.JsonProperty("isNewToday", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IsNewToday { get; set; }= default!;
    
        /// <summary>Indicates if the customer is small/medium/enterprise corporate (yes/no))</summary>
        [Newtonsoft.Json.JsonProperty("isSME", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IsSME { get; set; }= default!;
    
        /// <summary>BL BILL Liquidation Mode</summary>
        [Newtonsoft.Json.JsonProperty("liquidationMode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LiquidationMode { get; set; }= default!;
    
        /// <summary>A user defined code used to classify loans into specific descriptive categories for analysis</summary>
        [Newtonsoft.Json.JsonProperty("loanCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LoanCode { get; set; }= default!;
    
        /// <summary>The text description of the loan code</summary>
        [Newtonsoft.Json.JsonProperty("loanDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LoanDescription { get; set; }= default!;
    
        /// <summary>Loan To Value</summary>
        [Newtonsoft.Json.JsonProperty("loanToValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LoanToValue { get; set; }= default!;
    
        /// <summary>Marital status of the customer such as single; married; divorced; separated</summary>
        [Newtonsoft.Json.JsonProperty("maritalStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MaritalStatus { get; set; }= default!;
    
        /// <summary>Date the loan or term account will mature</summary>
        [Newtonsoft.Json.JsonProperty("maturityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MaturityDate { get; set; }= default!;
    
        /// <summary>The working occupation of the customer.</summary>
        [Newtonsoft.Json.JsonProperty("occupation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Occupation { get; set; }= default!;
    
        /// <summary>The original start date or open date of the contract for contracts that have been renewed</summary>
        [Newtonsoft.Json.JsonProperty("originalStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OriginalStartDate { get; set; }= default!;
    
        /// <summary>The amount the account is overdrawn</summary>
        [Newtonsoft.Json.JsonProperty("overdrawnAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OverdrawnAmount { get; set; }= default!;
    
        /// <summary>The amount the account is overdrawn in local currency</summary>
        [Newtonsoft.Json.JsonProperty("overdrawnAmountLcy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OverdrawnAmountLcy { get; set; }= default!;
    
        /// <summary>The frequency that the payment should be made on the loan contract</summary>
        [Newtonsoft.Json.JsonProperty("paymentFrequency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentFrequency { get; set; }= default!;
    
        /// <summary>Primary collateral code for the loan account</summary>
        [Newtonsoft.Json.JsonProperty("primaryCollateralCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrimaryCollateralCode { get; set; }= default!;
    
        /// <summary>Primary collateral code for the loan account</summary>
        [Newtonsoft.Json.JsonProperty("primaryCollateralDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrimaryCollateralDescription { get; set; }= default!;
    
        /// <summary>Grouping of product codes</summary>
        [Newtonsoft.Json.JsonProperty("productGroupCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductGroupCode { get; set; }= default!;
    
        /// <summary>Description of product groups</summary>
        [Newtonsoft.Json.JsonProperty("productGroupDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductGroupDescription { get; set; }= default!;
    
        /// <summary>Grouping of product types</summary>
        [Newtonsoft.Json.JsonProperty("productGroupType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductGroupType { get; set; }= default!;
    
        /// <summary>Line code of the product</summary>
        [Newtonsoft.Json.JsonProperty("productLineCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductLineCode { get; set; }= default!;
    
        /// <summary>Line description of the product</summary>
        [Newtonsoft.Json.JsonProperty("productLineDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductLineDescription { get; set; }= default!;
    
        /// <summary>The code used to identify the type of product the account represents.  This  code is the base for classifying products into  classifications; categories; groups and classes.</summary>
        [Newtonsoft.Json.JsonProperty("productCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductCode { get; set; }= default!;
    
        /// <summary>The description of the product based on the product code</summary>
        [Newtonsoft.Json.JsonProperty("productDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductDescription { get; set; }= default!;
    
        /// <summary>A classification field for product which is typically less granular than product code</summary>
        [Newtonsoft.Json.JsonProperty("productType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductType { get; set; }= default!;
    
        /// <summary>Purpose code (usually a numeric value) on the loan contract; also know as purpose for borrowing.</summary>
        [Newtonsoft.Json.JsonProperty("purposeCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PurposeCode { get; set; }= default!;
    
        /// <summary>A text description of the Purpose Code.</summary>
        [Newtonsoft.Json.JsonProperty("purposeDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PurposeDescription { get; set; }= default!;
    
        /// <summary>ReasonClosed</summary>
        [Newtonsoft.Json.JsonProperty("reasonClosed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReasonClosed { get; set; }= default!;
    
        /// <summary>contract next review date; usually used for Lines of Credit</summary>
        [Newtonsoft.Json.JsonProperty("reviewDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReviewDate { get; set; }= default!;
    
        /// <summary>Code used to assign risk level to an account - FI defined</summary>
        [Newtonsoft.Json.JsonProperty("riskCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RiskCode { get; set; }= default!;
    
        /// <summary>Text description for Risk Rating Code.</summary>
        [Newtonsoft.Json.JsonProperty("riskDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RiskDescription { get; set; }= default!;
    
        /// <summary>Scheduled Payment Amount</summary>
        [Newtonsoft.Json.JsonProperty("schedulePaymentAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SchedulePaymentAmount { get; set; }= default!;
    
        /// <summary>Scheduled Payment Amount in local currency</summary>
        [Newtonsoft.Json.JsonProperty("schedulePaymentAmountLcy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SchedulePaymentAmountLcy { get; set; }= default!;
    
        /// <summary>The term length of the product calculated in standard months. i.e. 12; 24; 36 ....60.  If the term length is not a standard number; this value is rounded to the nearest standard term. For example a 13 month term is rounded to 12 months.</summary>
        [Newtonsoft.Json.JsonProperty("standardizedTerm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StandardizedTerm { get; set; }= default!;
    
        /// <summary>Date the contract was opened</summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StartDate { get; set; }= default!;
    
        /// <summary>Text description of the account that is printed on statements. i.e Vacation Account</summary>
        [Newtonsoft.Json.JsonProperty("statementDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatementDescription { get; set; }= default!;
    
        /// <summary>Term Length (0;1;3;6;9;12;18;24;36;48;60;84) could be months; days; years - see term unit.</summary>
        [Newtonsoft.Json.JsonProperty("term", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Term { get; set; }= default!;
    
        /// <summary>Term length converted to months. Calculated based on term and term Unit</summary>
        [Newtonsoft.Json.JsonProperty("termInMonths", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermInMonths { get; set; }= default!;
    
        /// <summary>The integer value of the remaining term to the maturity date of the product.</summary>
        [Newtonsoft.Json.JsonProperty("termToMaturity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermToMaturity { get; set; }= default!;
    
        /// <summary>The groups or bucketing for term to maturity</summary>
        [Newtonsoft.Json.JsonProperty("termToMaturityGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermToMaturityGroup { get; set; }= default!;
    
        /// <summary>Unit of term length (days; months; years)</summary>
        [Newtonsoft.Json.JsonProperty("termUnit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermUnit { get; set; }= default!;
    
        /// <summary>The sum of all deposit and loan balances</summary>
        [Newtonsoft.Json.JsonProperty("totalBalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotalBalance { get; set; }= default!;
    
        /// <summary>Total Balance Amount in local currency)</summary>
        [Newtonsoft.Json.JsonProperty("totalBalanceLcy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotalBalanceLcy { get; set; }= default!;
    
        /// <summary>Amount that is charged for operation by customer</summary>
        [Newtonsoft.Json.JsonProperty("totalCharges", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotalCharges { get; set; }= default!;
    
        /// <summary>Amount in local currency that is charged for operation by customer</summary>
        [Newtonsoft.Json.JsonProperty("totalChargesLcy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotalChargesLcy { get; set; }= default!;
    
        /// <summary>Total Due Amount</summary>
        [Newtonsoft.Json.JsonProperty("totalDue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotalDue { get; set; }= default!;
    
        /// <summary>Total Due Amount in local currency</summary>
        [Newtonsoft.Json.JsonProperty("totalDueLcy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotalDueLcy { get; set; }= default!;
    
        /// <summary>Unspecified Amount</summary>
        [Newtonsoft.Json.JsonProperty("unspecifiedAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UnspecifiedAmount { get; set; }= default!;
    
        /// <summary>Unspecified Amount in local currency</summary>
        [Newtonsoft.Json.JsonProperty("unspecifiedAmountLcy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UnspecifiedAmountLcy { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016