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

namespace FundAdministration.GlobalInvestor.Order.Instruction
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IInstructionService
    {
        /// <summary>Creates Instructions</summary>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <param name="payload">postInstruction Payload</param>
        /// <returns>postInstruction Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PostInstructionSuccessResponse> PostInstructionAsync(string? referenceId, string? token, string? username, string? company, string? command, _0BULKPayload payload);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates Instructions</summary>
        /// <param name="referenceId">uniqueId for security purpose</param>
        /// <param name="token">unique token</param>
        /// <param name="username">username</param>
        /// <param name="company">company name</param>
        /// <param name="command">API operations like INVOKE, VALIDATE, PROCESS can be set or by default PROCESS is set</param>
        /// <param name="payload">postInstruction Payload</param>
        /// <returns>postInstruction Success Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PostInstructionSuccessResponse> PostInstructionAsync(string? referenceId, string? token, string? username, string? company, string? command, _0BULKPayload payload, System.Threading.CancellationToken cancellationToken);
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class _0BULKPayload 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public object? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public Body? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PaginationSchema 
    {
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public string? Page { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public string? Count { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public string? Total { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AuditSchema 
    {
        [System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public string? StartTime { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public string? EndTime { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("processTime")]
        public string? ProcessTime { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SuccessHeaderstatusSchema 
    {
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("HTTP_MESSAGE")]
        public string? HTTP_MESSAGE { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("HTTP_CODE")]
        public string? HTTP_CODE { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("responseId")]
        public string? ResponseId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("eTag")]
        public string? ETag { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        public string? LastModified { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostInstructionSuccessheaderResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public PaginationSchema? Pagination { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("audit")]
        public AuditSchema? Audit { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public SuccessHeaderstatusSchema? Status { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("referenceId")]
        public string? ReferenceId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostInstructionrecordsSchema : System.Collections.ObjectModel.Collection<_0>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostInstructionSuccessbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public PostInstructionrecordsSchema? Records { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostInstructionSuccessResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public PostInstructionSuccessheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public PostInstructionSuccessbodyResponse? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ErrorHeaderstatusSchema 
    {
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("HTTP_MESSAGE")]
        public string? HTTP_MESSAGE { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("HTTP_CODE")]
        public string? HTTP_CODE { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("responseId")]
        public string? ResponseId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("eTag")]
        public string? ETag { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        public string? LastModified { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("details")]
        public System.Collections.Generic.ICollection<Details>? Details { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostInstructionErrorheaderResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public PaginationSchema? Pagination { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("audit")]
        public AuditSchema? Audit { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public ErrorHeaderstatusSchema? Status { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("referenceId")]
        public string? ReferenceId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostInstructionErrorbodyResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public System.Collections.Generic.ICollection<Items>? Items { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PostInstructionErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public PostInstructionErrorheaderResponse? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class _0 
    {
        /// <summary>It specifies the type of record that is loaded</summary>
        [System.Text.Json.Serialization.JsonPropertyName("recordIndicator")]
        public string? RecordIndicator { get; set; }= default!;
    
        /// <summary>Operation</summary>
        [System.Text.Json.Serialization.JsonPropertyName("operation")]
        public string? Operation { get; set; }= default!;
    
        /// <summary>It specifies the external register identifier through which the instruction is being placed. This is taken from the interface file</summary>
        [System.Text.Json.Serialization.JsonPropertyName("nregister")]
        public string? Nregister { get; set; }= default!;
    
        /// <summary>It specifies the Register ID through which the instruction is being created. Allowed values are from the list of Registers created in MFGI for which the user has rights</summary>
        [System.Text.Json.Serialization.JsonPropertyName("nregisterId")]
        public double? NregisterId { get; set; }= default!;
    
        /// <summary>Its specifies the fund promter ID of the instruction being created. Allowed values are from the list of Fund promoters created in MFGI</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fundPromoterIdentifier")]
        public double? FundPromoterIdentifier { get; set; }= default!;
    
        /// <summary>It specifies the external agent identifier of the agent for which the instruction is being placed. This is taken from the interface file</summary>
        [System.Text.Json.Serialization.JsonPropertyName("noutlet")]
        public string? Noutlet { get; set; }= default!;
    
        /// <summary>It specifies Agent ID  linked to the register . Allowed values are from the list of Fund promoters created in MFGI</summary>
        [System.Text.Json.Serialization.JsonPropertyName("noutletId")]
        public double? NoutletId { get; set; }= default!;
    
        /// <summary>It specifies the MFGI created instruction number which is automatically incremented sequentially per register by MFGI.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("ninstruction")]
        public double? Ninstruction { get; set; }= default!;
    
        /// <summary>Multifonds Transaction type code</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionType")]
        public string? TransactionType { get; set; }= default!;
    
        /// <summary>Its specifies the frequency for the instruction. LoV is available in Cmess table TA_FREQ_IN</summary>
        [System.Text.Json.Serialization.JsonPropertyName("frequency")]
        public string? Frequency { get; set; }= default!;
    
        /// <summary>Its specifies the day of the week when the instruction needs to be exected for frequency Day of the month. LoV is available in Cmess table JOURS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("day")]
        public string? Day { get; set; }= default!;
    
        /// <summary>It specifies the allocation method chosen by the register to split the amount to be invested in the funds of the product. LoV is available in Cmess table TA_SPLIT</summary>
        [System.Text.Json.Serialization.JsonPropertyName("splitType")]
        public string? SplitType { get; set; }= default!;
    
        /// <summary>It specifies the instruction Quantity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }= default!;
    
        /// <summary>Quantity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }= default!;
    
        /// <summary>Currency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; }= default!;
    
        /// <summary>It specifies First date on which the instruction operation will take place. This date should be equal or superior to the application date</summary>
        [System.Text.Json.Serialization.JsonPropertyName("firstExecDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? FirstExecDate { get; set; }= default!;
    
        /// <summary>Number of installments of the plan.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("noOfInstallments")]
        public double? NoOfInstallments { get; set; }= default!;
    
        /// <summary>It specifies the Amount of penalty fees when the redemption is done before the authorized period</summary>
        [System.Text.Json.Serialization.JsonPropertyName("penaltiyAmount")]
        public double? PenaltiyAmount { get; set; }= default!;
    
        /// <summary>It specifies the Currency of the penalty fees. (in 3 letter ISO Code. Eg : EUR).The LoV is available in CMESS tabel MONNAIES. Mandatory if the field Penalty amount is filled in.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("penaltyCurrency")]
        public string? PenaltyCurrency { get; set; }= default!;
    
        /// <summary>It specifies the Period during which the commission is applicable to the early redemption.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("period")]
        public string? Period { get; set; }= default!;
    
        /// <summary>It specifies the Register type for Cash Handling.]The LoV is available in CMESS tabel TA_REGIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("typeRegister")]
        public string? TypeRegister { get; set; }= default!;
    
        /// <summary>It specifies the Settlement type for Cash Handling. LoV is available in CMESS tabel TA_SETTLE</summary>
        [System.Text.Json.Serialization.JsonPropertyName("settlementType")]
        public string? SettlementType { get; set; }= default!;
    
        /// <summary>It specifies the Deal type for Cash Handling. LoV is available in Cmess table TA_DEAL</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dealType")]
        public string? DealType { get; set; }= default!;
    
        /// <summary>Flag to specify whether the instruction has external cash movements. Allowed values : Y (to enable), N (to disable), Null (=N)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("extCash")]
        public string? ExtCash { get; set; }= default!;
    
        /// <summary>Flag to specify whether the instruction has Internal cash movements. Allowed values : Y (to enable), N (to disable), Null (=N)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("intCash")]
        public string? IntCash { get; set; }= default!;
    
        /// <summary>Free text field for user to add any addiotnal information</summary>
        [System.Text.Json.Serialization.JsonPropertyName("freeText")]
        public string? FreeText { get; set; }= default!;
    
        /// <summary>It specifies the number of days applicable on the specific frequency selected.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("numberOfDays")]
        public double? NumberOfDays { get; set; }= default!;
    
        /// <summary>It specifies the number of weeks applicable on the specific frequency selected.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("numberOfWeeks")]
        public double? NumberOfWeeks { get; set; }= default!;
    
        /// <summary>It specifies the payment type of the instruction. LoV is available in CMESS tabel TA_PAYTYP</summary>
        [System.Text.Json.Serialization.JsonPropertyName("paymentType")]
        public string? PaymentType { get; set; }= default!;
    
        /// <summary>It specifies the Custody settlement of the instruction. LoV is available in CMESS tabel TA_CDELIV</summary>
        [System.Text.Json.Serialization.JsonPropertyName("custodySettlement")]
        public string? CustodySettlement { get; set; }= default!;
    
        /// <summary>It specifies the Exact date on which the instruction must be processed. This field is mandatory for the Monthly frequency or blank for the other frequency codes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("regularDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? RegularDate { get; set; }= default!;
    
        /// <summary>It specifies the Last date on which the instruction will take place. End of the operation/instruction</summary>
        [System.Text.Json.Serialization.JsonPropertyName("maturityDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? MaturityDate { get; set; }= default!;
    
        /// <summary>It specifies the Date on which the shareholder wishes to cancel the instruction. </summary>
        [System.Text.Json.Serialization.JsonPropertyName("cancellationDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? CancellationDate { get; set; }= default!;
    
        /// <summary>It specifies the Name of the account holder</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountHolderName")]
        public string? AccountHolderName { get; set; }= default!;
    
        /// <summary>It specifies the Account number.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bankAccount")]
        public string? BankAccount { get; set; }= default!;
    
        /// <summary>It specifies the Bank linked to the account holder. Allowed values are from the Banks created at Central Register level in MFGI.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("bankId")]
        public double? BankId { get; set; }= default!;
    
        /// <summary>It specifies the date from which the saving plan needs to be suspened. The field will be activated only when the operation code 0001-Savings Plan is selected and when the instruction is in status 20-Validated or 60-Suspended</summary>
        [System.Text.Json.Serialization.JsonPropertyName("suspensionFrom")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? SuspensionFrom { get; set; }= default!;
    
        /// <summary>It specifies the date till which the saving plan needs to be suspened. The field will be activated only when the operation code 0001-Savings Plan is selected and when the instruction is in status 20-Validated or 60-Suspended</summary>
        [System.Text.Json.Serialization.JsonPropertyName("suspensionTo")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? SuspensionTo { get; set; }= default!;
    
        /// <summary>Flag to specify if the instruction needs to be cancelled immediately. Allowed values : Y (to enable), N (to disable), Null (=N)</summary>
        [System.Text.Json.Serialization.JsonPropertyName("immediateCancelation")]
        public string? ImmediateCancelation { get; set; }= default!;
    
        /// <summary>It specifies the External unique mandatory ref. The system will perform a uniqueness check on this field</summary>
        [System.Text.Json.Serialization.JsonPropertyName("externalUniqueMandateReference")]
        public string? ExternalUniqueMandateReference { get; set; }= default!;
    
        /// <summary>Fund ID</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fundID")]
        public string? FundID { get; set; }= default!;
    
        /// <summary>Share</summary>
        [System.Text.Json.Serialization.JsonPropertyName("shareType")]
        public string? ShareType { get; set; }= default!;
    
        /// <summary>externalSecurityIDCodeType</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIDCode")]
        public string? SecurityIDCode { get; set; }= default!;
    
        /// <summary>externalSecurityIDCode</summary>
        [System.Text.Json.Serialization.JsonPropertyName("security")]
        public string? Security { get; set; }= default!;
    
        /// <summary>quotationCurrency</summary>
        [System.Text.Json.Serialization.JsonPropertyName("quotationCurrency")]
        public string? QuotationCurrency { get; set; }= default!;
    
        /// <summary>Cond. ID</summary>
        [System.Text.Json.Serialization.JsonPropertyName("conditionId")]
        public double? ConditionId { get; set; }= default!;
    
        /// <summary>Percentage</summary>
        [System.Text.Json.Serialization.JsonPropertyName("percentage")]
        public double? Percentage { get; set; }= default!;
    
        /// <summary>Amount</summary>
        [System.Text.Json.Serialization.JsonPropertyName("reinvestAmount")]
        public double? ReinvestAmount { get; set; }= default!;
    
        /// <summary>Quantity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("reinvestQuantity")]
        public double? ReinvestQuantity { get; set; }= default!;
    
        /// <summary>Ccy.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("ccy")]
        public string? Ccy { get; set; }= default!;
    
        /// <summary>Fund ID For Reinvest</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fundIDForReinvest")]
        public string? FundIDForReinvest { get; set; }= default!;
    
        /// <summary>Share For Reinvest</summary>
        [System.Text.Json.Serialization.JsonPropertyName("shareTypeForReinvest")]
        public string? ShareTypeForReinvest { get; set; }= default!;
    
        /// <summary>externalSecurityIDCodeType For Reinvest</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityIDCodeForReinvest")]
        public string? SecurityIDCodeForReinvest { get; set; }= default!;
    
        /// <summary>externalSecurityIDCode For Reinvest</summary>
        [System.Text.Json.Serialization.JsonPropertyName("securityForReinvest")]
        public string? SecurityForReinvest { get; set; }= default!;
    
        /// <summary>quotationCurrency For Reinvest</summary>
        [System.Text.Json.Serialization.JsonPropertyName("currencyForReinvest")]
        public string? CurrencyForReinvest { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Body 
    {
        [System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public System.Collections.Generic.ICollection<_0>? Instructions { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Details 
    {
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Items 
    {
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
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