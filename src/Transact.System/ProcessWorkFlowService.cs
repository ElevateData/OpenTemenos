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

namespace Transact.System.ProcessWorkFlow
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IProcessWorkFlowService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves information on work item assigned to the logged in user.</summary>
        /// <param name="data">Contains any input parameters/data required for the job</param>
        /// <param name="processNumber">Identifies the process which involves multiple task for Ex: Enrolling the new customer</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>PendingWorkflowsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<PendingWorkflowsResponse> GetPendingWorkflowsAsync(string? data = null, string? processNumber = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve information on which participant's work list the activity is residing currently.</summary>
        /// <param name="activityTransaction">Process Workflow Activity Transactions</param>
        /// <param name="user">The user who created the project</param>
        /// <param name="transactionReference">Transaction reference identifier.</param>
        /// <param name="process">Process</param>
        /// <param name="pwActivityStatus">Process workflow activity status  POSSIBLE VALUES: COMPLETED APPROVED AUTHORISED</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>WorkflowPendingActivitiesResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WorkflowPendingActivitiesResponse> GetWorkflowPendingActivitiesAsync(string? activityTransaction = null, string? user = null, string? transactionReference = null, string? process = null, string? pwActivityStatus = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Process workflow transactions associated to a role</summary>
        /// <param name="userRoleQuery">User who initiated the transaction</param>
        /// <param name="originateProcess">Process Id who initiated the entire workflow of transactions</param>
        /// <param name="processId">Contains the process identifier</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRoleHeader">User who initiated the transaction</param>
        /// <returns>TransactionsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<TransactionsResponse> GetTransactionsAsync(string? userRoleQuery = null, string? originateProcess = null, string? processId = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRoleHeader = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Process workflow transactions not associated to a role</summary>
        /// <param name="processId">Contains the process identifier</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>RolelessTransactionsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<TransactionsResponse> GetRolelessTransactionsAsync(string? processId = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves information related to different participants and the users attached those participants.</summary>
        /// <param name="participantId">Process Workflow Participant ID</param>
        /// <param name="accountOfficer">Identifier of Department Account Officer</param>
        /// <param name="user">The user who created the project</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <returns>WorkflowParticipantsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WorkflowParticipantsResponse> GetWorkflowParticipantsAsync(string? participantId = null, string? accountOfficer = null, string? user = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    
    /// <summary>PendingWorkflowsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PendingWorkflowsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public PendingWorkflowsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PendingWorkflowsResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
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
    
    /// <summary>WorkflowPendingActivitiesResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class WorkflowPendingActivitiesResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public WorkflowPendingActivitiesResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class WorkflowPendingActivitiesResponseBody : System.Collections.ObjectModel.Collection<Anonymous2>
    {
    
    }
    
    /// <summary>TransactionsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TransactionsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public TransactionsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TransactionsResponseBody : System.Collections.ObjectModel.Collection<Anonymous3>
    {
    
    }
    
    /// <summary>WorkflowParticipantsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class WorkflowParticipantsResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public WorkflowParticipantsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class WorkflowParticipantsResponseBody : System.Collections.ObjectModel.Collection<Anonymous4>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>Identifies the date on which the activity is due.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dueDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? DueDate { get; set; }= default!;
    
        /// <summary>The product condition has an activity type associated that drives an action.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
        /// <summary>Identifies the name of the client.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("clientName")]
        public string? ClientName { get; set; }= default!;
    
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }= default!;
    
        /// <summary>User who defines the Campaign</summary>
        [System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }= default!;
    
        /// <summary>Identifies the unique identifier of the activity.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("referenceId")]
        public string? ReferenceId { get; set; }= default!;
    
        /// <summary>Transaction reference identifier.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionReference")]
        public string? TransactionReference { get; set; }= default!;
    
        /// <summary>Status identifier of the account. The values are 'DELETED' if the account is closed, 'BLOCKED' is there are any posting restrictions &amp; 'ENABLED' for active accounts.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }= default!;
    
    
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
        /// <summary>Contains the process identifier</summary>
        [System.Text.Json.Serialization.JsonPropertyName("processId")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? ProcessId { get; set; }= default!;
    
        /// <summary>Id of the activity, e.g. ACCOUNTS-CAPITALISE-ACCHARGE*CARDISSUEFEE</summary>
        [System.Text.Json.Serialization.JsonPropertyName("activityId")]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string? ActivityId { get; set; }= default!;
    
        /// <summary>Id of the selected activity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("activityName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? ActivityName { get; set; }= default!;
    
        /// <summary>Business Activity Status  POSSIBLE VALUES: 0: Ready  1: Running  2: Completed successfully  3: On hold or in error</summary>
        [System.Text.Json.Serialization.JsonPropertyName("activityStatus")]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string? ActivityStatus { get; set; }= default!;
    
        /// <summary>Transaction reference identifier.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionReference")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? TransactionReference { get; set; }= default!;
    
        /// <summary>The user who created the project</summary>
        [System.Text.Json.Serialization.JsonPropertyName("user")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? User { get; set; }= default!;
    
        /// <summary>User who defines the Campaign</summary>
        [System.Text.Json.Serialization.JsonPropertyName("owner")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? Owner { get; set; }= default!;
    
        /// <summary>Application Version or the enquiry name to be launched.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("launch")]
        [System.ComponentModel.DataAnnotations.StringLength(99)]
        public string? Launch { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous3 
    {
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string? DisplayName { get; set; }= default!;
    
        /// <summary>Contains the process identifier</summary>
        [System.Text.Json.Serialization.JsonPropertyName("processId")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? ProcessId { get; set; }= default!;
    
        /// <summary>Defines the activity to be processed against the Arrangement. The activity may be a user activity or a system generated activity.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("activity")]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string? Activity { get; set; }= default!;
    
        /// <summary>The department/user group who is responsible for this transaction.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("participantGroup")]
        [System.ComponentModel.DataAnnotations.StringLength(34)]
        public string? ParticipantGroup { get; set; }= default!;
    
        /// <summary>Transaction reference identifier.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transactionReference")]
        [System.ComponentModel.DataAnnotations.StringLength(24)]
        public string? TransactionReference { get; set; }= default!;
    
        /// <summary>Specifies how the Customer is considered by the bank and how he fits in with the Account Officer's overall marketing strategy</summary>
        [System.Text.Json.Serialization.JsonPropertyName("target")]
        [System.ComponentModel.DataAnnotations.StringLength(99)]
        public string? Target { get; set; }= default!;
    
        /// <summary>The target activity to be done from this transaction. It can either be a transaction or a query.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("targetId")]
        [System.ComponentModel.DataAnnotations.StringLength(99)]
        public string? TargetId { get; set; }= default!;
    
        /// <summary>Business Activity Status  POSSIBLE VALUES: 0: Ready  1: Running  2: Completed successfully  3: On hold or in error</summary>
        [System.Text.Json.Serialization.JsonPropertyName("activityStatus")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? ActivityStatus { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous4 
    {
        /// <summary>Identifier of Department Account Officer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountOfficers")]
        public System.Collections.Generic.ICollection<AccountOfficers>? AccountOfficers { get; set; }= default!;
    
        /// <summary>Process Workflow Participant ID</summary>
        [System.Text.Json.Serialization.JsonPropertyName("participantId")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? ParticipantId { get; set; }= default!;
    
        /// <summary>Contains the name used for display or enrichment purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? DisplayName { get; set; }= default!;
    
        /// <summary>The user who created the project</summary>
        [System.Text.Json.Serialization.JsonPropertyName("user")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? User { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AccountOfficers 
    {
        /// <summary>Identifier of Department Account Officer</summary>
        [System.Text.Json.Serialization.JsonPropertyName("accountOfficer")]
        public System.Collections.Generic.ICollection<double>? AccountOfficer { get; set; }= default!;
    
    
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