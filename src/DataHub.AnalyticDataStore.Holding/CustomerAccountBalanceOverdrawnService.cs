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

namespace DataHub.AnalyticDataStore.Holding.CustomerAccountBalanceOverdrawn
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface ICustomerAccountBalanceOverdrawnService
    {
        /// <summary>Retrieves accounts/contracts details with customer information for current accounts that are overdrawn</summary>
        /// <param name="businessDate">Business snapshot date of the source data</param>
        /// <param name="useCurrentDate">Current Date flag for the Business date</param>
        /// <param name="productGroupCode">Grouping of product codes</param>
        /// <param name="isOverdrawn">Indicates if contract is overdrawn  (yes/no)</param>
        /// <returns>Customer overdrawn account balancesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetCustomerAccountBalanceOverdrawnResponse> GetCustomerAccountBalanceOverdrawnAsync(string? businessDate, string? useCurrentDate, string? productGroupCode, string? isOverdrawn);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves accounts/contracts details with customer information for current accounts that are overdrawn</summary>
        /// <param name="businessDate">Business snapshot date of the source data</param>
        /// <param name="useCurrentDate">Current Date flag for the Business date</param>
        /// <param name="productGroupCode">Grouping of product codes</param>
        /// <param name="isOverdrawn">Indicates if contract is overdrawn  (yes/no)</param>
        /// <returns>Customer overdrawn account balancesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetCustomerAccountBalanceOverdrawnResponse> GetCustomerAccountBalanceOverdrawnAsync(string? businessDate, string? useCurrentDate, string? productGroupCode, string? isOverdrawn, System.Threading.CancellationToken cancellationToken);
    
    }

    /// <summary>getCustomerAccountBalanceOverdrawnResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetCustomerAccountBalanceOverdrawnResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public GetCustomerAccountBalanceOverdrawnResponseBody? Data { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetCustomerAccountBalanceOverdrawnResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("depositsCustomerAccountDetails")]
        public System.Collections.Generic.ICollection<DepositsCustomerAccountDetails>? DepositsCustomerAccountDetails { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DepositsCustomerAccountDetails 
    {
        /// <summary>Indicates if account is commercial; retail or other</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountClass")]
        public string? AccountClass { get; set; }= default!;
    
        /// <summary>The affluent bucket of total balance to identify customer segment</summary>
        [System.Text.Json.Serialization.JsonPropertyName("affluentSegment")]
        public string? AffluentSegment { get; set; }= default!;
    
        /// <summary>Age Group</summary>
        [System.Text.Json.Serialization.JsonPropertyName("ageGroup")]
        public string? AgeGroup { get; set; }= default!;
    
        /// <summary>Current balance of the account in reporting currency.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public string? Balance { get; set; }= default!;
    
        /// <summary>Current balance in local currency of the contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("lcyBalance")]
        public string? LcyBalance { get; set; }= default!;
    
        /// <summary>Groups based on balance</summary>
        [System.Text.Json.Serialization.JsonPropertyName("balanceGroup")]
        public string? BalanceGroup { get; set; }= default!;
    
        /// <summary>Beneficiary for the Letter of Credit</summary>
        [System.Text.Json.Serialization.JsonPropertyName("beneficiary")]
        public string? Beneficiary { get; set; }= default!;
    
        /// <summary>Business snapshot date of the source data</summary>
        [System.Text.Json.Serialization.JsonPropertyName("businessDate")]
        public string? BusinessDate { get; set; }= default!;
    
        /// <summary>Date the contract was closed</summary>
        [System.Text.Json.Serialization.JsonPropertyName("closedDate")]
        public string? ClosedDate { get; set; }= default!;
    
        /// <summary>Identifier field with no business meaning - Foreign key linking to Contract to Branch</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractBranchKey")]
        public string? ContractBranchKey { get; set; }= default!;
    
        /// <summary>Branch name where Contract was created</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractBranchName")]
        public string? ContractBranchName { get; set; }= default!;
    
        /// <summary>Branch Number</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractBranchNumber")]
        public string? ContractBranchNumber { get; set; }= default!;
    
        /// <summary>Full name of the employee associated with the Contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractEmployeeFullName")]
        public string? ContractEmployeeFullName { get; set; }= default!;
    
        /// <summary>Identifier field with no business meaning - Foreign key linking to Contract to Employee</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractEmployeeKey")]
        public string? ContractEmployeeKey { get; set; }= default!;
    
        /// <summary>Employee number of the employee associated with the Contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractEmployeeNumber")]
        public string? ContractEmployeeNumber { get; set; }= default!;
    
        /// <summary>Contract number of specific savings; chequing; term deposit; loan, letter of credit, etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractNumber")]
        public string? ContractNumber { get; set; }= default!;
    
        /// <summary>Region of the branch associated with the Contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractRegion")]
        public string? ContractRegion { get; set; }= default!;
    
        /// <summary>The status of the Contract. i.e Active, Closed, Dormant, Inactive etc</summary>
        [System.Text.Json.Serialization.JsonPropertyName("contractStatus")]
        public string? ContractStatus { get; set; }= default!;
    
        /// <summary>The currency type for the contract.  Typically the standard ISO 3 character country code such as CAD; USD; EUR.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; }= default!;
    
        /// <summary>Current Date flag for the Business date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("useCurrentDate")]
        public string? UseCurrentDate { get; set; }= default!;
    
        /// <summary>A Yes/No flag indicating if the customer has been closed within a month of the business date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerClosedThisMonth")]
        public string? CustomerClosedThisMonth { get; set; }= default!;
    
        /// <summary>A Yes/No flag indication if the customer has been opened within a month of the business date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerNewThisMonth")]
        public string? CustomerNewThisMonth { get; set; }= default!;
    
        /// <summary>The classification for the member either retail or commercial</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerClass")]
        public string? CustomerClass { get; set; }= default!;
    
        /// <summary>The customer number or customer identification number</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerNumber")]
        public string? CustomerNumber { get; set; }= default!;
    
        /// <summary>Date Customer started with�the FI�(customer opened date)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("customerStartDate")]
        public string? CustomerStartDate { get; set; }= default!;
    
        /// <summary>Indicates if contract interest rate is fixed or variable</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fixedOrVariable")]
        public string? FixedOrVariable { get; set; }= default!;
    
        /// <summary>Customer's gender</summary>
        [System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }= default!;
    
        /// <summary>The generation gap to identify the suitable product for the group of customers</summary>
        [System.Text.Json.Serialization.JsonPropertyName("generation")]
        public string? Generation { get; set; }= default!;
    
        /// <summary>The interest rate for the contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestRate")]
        public string? InterestRate { get; set; }= default!;
    
        /// <summary>Groups based on account�interest rate�- '0' -.50%; .50 - 1.00%; 1% - 3% etc.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestRateGroup")]
        public string? InterestRateGroup { get; set; }= default!;
    
        /// <summary>Interest rate index Ex:Prime + 1.00. Usually configured on the banking system at the product level; defines the rate.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestRateIndex")]
        public string? InterestRateIndex { get; set; }= default!;
    
        /// <summary>Interest Rate Type.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestRateType")]
        public string? InterestRateType { get; set; }= default!;
    
        /// <summary>Interest Rate Type Description - LD loans and deps.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestRateTypeDescription")]
        public string? InterestRateTypeDescription { get; set; }= default!;
    
        /// <summary>The contract interest rate variance. Eg. Prime -.50. -.50 is the variance.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestRateVariance")]
        public string? InterestRateVariance { get; set; }= default!;
    
        /// <summary>BL Bill Interpolate</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interpolate")]
        public string? Interpolate { get; set; }= default!;
    
        /// <summary>Daily interest for an contract on the business date; based on the balance and the rate. Negative if it's a demand contract; positive if it's a loan contract.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestIncomeOrExpense")]
        public string? InterestIncomeOrExpense { get; set; }= default!;
    
        /// <summary>Daily interest in local currency for an contract on the business date; based on the balance and the rate. Negative if it's a demand contract; positive if it's a loan contract.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("interestIncomeOrExpenseLcy")]
        public string? InterestIncomeOrExpenseLcy { get; set; }= default!;
    
        /// <summary>Yes/No flag indicating if the account was closed less than a month before the business date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("isClosedThisMonth")]
        public string? IsClosedThisMonth { get; set; }= default!;
    
        /// <summary>Yes/No flag indicating if the account was closed on the business date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("isClosedToday")]
        public string? IsClosedToday { get; set; }= default!;
    
        /// <summary>A Yes/No flag indicating if the account has been opened less than one month before the business date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("isNewThisMonth")]
        public string? IsNewThisMonth { get; set; }= default!;
    
        /// <summary>A Yes/No flag indicating if the account has been opened on the business date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("isNewToday")]
        public string? IsNewToday { get; set; }= default!;
    
        /// <summary>Indicates if contract is overdrawn  (yes/no)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("isOverdrawn")]
        public string? IsOverdrawn { get; set; }= default!;
    
        /// <summary>Indicates if the customer is small/medium/enterprise corporate (yes/no))</summary>
        [System.Text.Json.Serialization.JsonPropertyName("isSME")]
        public string? IsSME { get; set; }= default!;
    
        /// <summary>BL BILL Liquidation Mode</summary>
        [System.Text.Json.Serialization.JsonPropertyName("liquidationMode")]
        public string? LiquidationMode { get; set; }= default!;
    
        /// <summary>Marital status of the customer such as single; married; divorced; separated</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maritalStatus")]
        public string? MaritalStatus { get; set; }= default!;
    
        /// <summary>Date the loan or term account will mature</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maturityDate")]
        public string? MaturityDate { get; set; }= default!;
    
        /// <summary>The working occupation of the customer.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("occupation")]
        public string? Occupation { get; set; }= default!;
    
        /// <summary>Operation LC and Bills</summary>
        [System.Text.Json.Serialization.JsonPropertyName("operation")]
        public string? Operation { get; set; }= default!;
    
        /// <summary>The amount the account is overdrawn</summary>
        [System.Text.Json.Serialization.JsonPropertyName("overdrawnAmount")]
        public string? OverdrawnAmount { get; set; }= default!;
    
        /// <summary>The amount the account is overdrawn in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("overdrawnAmountLcy")]
        public string? OverdrawnAmountLcy { get; set; }= default!;
    
        /// <summary>The frequency that the payment should be made on the loan contract</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentFrequency")]
        public string? PaymentFrequency { get; set; }= default!;
    
        /// <summary>Primary collateral code for the loan account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("primaryCollateralCode")]
        public string? PrimaryCollateralCode { get; set; }= default!;
    
        /// <summary>Primary collateral code for the loan account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("primaryCollateralDescription")]
        public string? PrimaryCollateralDescription { get; set; }= default!;
    
        /// <summary>Grouping of product codes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productGroupCode")]
        public string? ProductGroupCode { get; set; }= default!;
    
        /// <summary>Description of product groups</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productGroupDescription")]
        public string? ProductGroupDescription { get; set; }= default!;
    
        /// <summary>Grouping of product types</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productGroupType")]
        public string? ProductGroupType { get; set; }= default!;
    
        /// <summary>Line code of the product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productLineCode")]
        public string? ProductLineCode { get; set; }= default!;
    
        /// <summary>Line description of the product</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productLineDescription")]
        public string? ProductLineDescription { get; set; }= default!;
    
        /// <summary>The code used to identify the type of product the account represents.  This  code is the base for classifying products into  classifications; categories; groups and classes.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productCode")]
        public string? ProductCode { get; set; }= default!;
    
        /// <summary>The description of the product based on the product code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productDescription")]
        public string? ProductDescription { get; set; }= default!;
    
        /// <summary>A classification field for product which is typically less granular than product code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("productType")]
        public string? ProductType { get; set; }= default!;
    
        /// <summary>The term length of the product calculated in standard months. i.e. 12; 24; 36 ....60.  If the term length is not a standard number; this value is rounded to the nearest standard term. For example a 13 month term is rounded to 12 months.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("standardizedTerm")]
        public string? StandardizedTerm { get; set; }= default!;
    
        /// <summary>Date the contract was opened</summary>
        [System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public string? StartDate { get; set; }= default!;
    
        /// <summary>Text description of the account that is printed on statements. i.e Vacation Account</summary>
        [System.Text.Json.Serialization.JsonPropertyName("statementDescription")]
        public string? StatementDescription { get; set; }= default!;
    
        /// <summary>Term Length (0;1;3;6;9;12;18;24;36;48;60;84) could be months; days; years - see term unit.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("term")]
        public string? Term { get; set; }= default!;
    
        /// <summary>Term length converted to months. Calculated based on term and term Unit</summary>
        [System.Text.Json.Serialization.JsonPropertyName("termInMonths")]
        public string? TermInMonths { get; set; }= default!;
    
        /// <summary>The integer value of the remaining term to the maturity date of the product.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("termToMaturity")]
        public string? TermToMaturity { get; set; }= default!;
    
        /// <summary>Unit of term length (days; months; years)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("termUnit")]
        public string? TermUnit { get; set; }= default!;
    
        /// <summary>The sum of all deposit and loan balances</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalBalance")]
        public string? TotalBalance { get; set; }= default!;
    
        /// <summary>Total Balance Amount in local currency)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalBalanceLcy")]
        public string? TotalBalanceLcy { get; set; }= default!;
    
        /// <summary>Amount that is charged for operation by customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalCharges")]
        public string? TotalCharges { get; set; }= default!;
    
        /// <summary>Amount in local currency that is charged for operation by customer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalChargesLcy")]
        public string? TotalChargesLcy { get; set; }= default!;
    
        /// <summary>Total Discount Amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalDiscount")]
        public string? TotalDiscount { get; set; }= default!;
    
        /// <summary>Total Discount Amount in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("totalDiscountLcy")]
        public string? TotalDiscountLcy { get; set; }= default!;
    
        /// <summary>The funds transfer rate for the account based on values from the Profitability Model</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transferRate")]
        public string? TransferRate { get; set; }= default!;
    
        /// <summary>Unspecified Amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("unspecifiedAmount")]
        public string? UnspecifiedAmount { get; set; }= default!;
    
        /// <summary>Unspecified Amount in local currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("unspecifiedAmountLcy")]
        public string? UnspecifiedAmountLcy { get; set; }= default!;
    
        /// <summary>WaiveCharge</summary>
        [System.Text.Json.Serialization.JsonPropertyName("waiveCharge")]
        public string? WaiveCharge { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016