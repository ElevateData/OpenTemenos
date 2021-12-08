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

namespace Transact.Meta.Menus
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IMenusService
    {
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Random and unique string for each page. Used for security purpose</param>
        /// <returns>getMainMenusResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetMainMenusResponse> GetMainMenusAsync(int? page_size, int? page_start, string? page_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Random and unique string for each page. Used for security purpose</param>
        /// <returns>getMainMenusResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetMainMenusResponse> GetMainMenusAsync(int? page_size, int? page_start, string? page_token, System.Threading.CancellationToken cancellationToken);
    
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Random and unique string for each page. Used for security purpose</param>
        /// <returns>getMainMenuResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetMainMenuResponse> GetMainMenuAsync(string menuId, int? page_size, int? page_start, string? page_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Random and unique string for each page. Used for security purpose</param>
        /// <returns>getMainMenuResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetMainMenuResponse> GetMainMenuAsync(string menuId, int? page_size, int? page_start, string? page_token, System.Threading.CancellationToken cancellationToken);
    
        /// <param name="payload">body Payload</param>
        /// <param name="validate_only">The identifier to indicate if it is set to only validate or not.</param>
        /// <returns>createMainMenuResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CreateMainMenuResponse> CreateMainMenuAsync(string menuId, CreateMainMenu payload, bool? validate_only);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="payload">body Payload</param>
        /// <param name="validate_only">The identifier to indicate if it is set to only validate or not.</param>
        /// <returns>createMainMenuResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CreateMainMenuResponse> CreateMainMenuAsync(string menuId, CreateMainMenu payload, bool? validate_only, System.Threading.CancellationToken cancellationToken);
    
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Random and unique string for each page. Used for security purpose</param>
        /// <returns>getMenusResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetMenusResponse> GetMenusAsync(int? page_size, int? page_start, string? page_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Random and unique string for each page. Used for security purpose</param>
        /// <returns>getMenusResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetMenusResponse> GetMenusAsync(int? page_size, int? page_start, string? page_token, System.Threading.CancellationToken cancellationToken);
    
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Random and unique string for each page. Used for security purpose</param>
        /// <returns>getMenuResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetMenuResponse> GetMenuAsync(string menuId, int? page_size, int? page_start, string? page_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Random and unique string for each page. Used for security purpose</param>
        /// <returns>getMenuResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<GetMenuResponse> GetMenuAsync(string menuId, int? page_size, int? page_start, string? page_token, System.Threading.CancellationToken cancellationToken);
    
        /// <param name="payload">body Payload</param>
        /// <param name="validate_only">The identifier to indicate if it is set to only validate or not.</param>
        /// <returns>createMenuResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CreateMenuResponse> CreateMenuAsync(string menuId, CreateMenu payload, bool? validate_only);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="payload">body Payload</param>
        /// <param name="validate_only">The identifier to indicate if it is set to only validate or not.</param>
        /// <returns>createMenuResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CreateMenuResponse> CreateMenuAsync(string menuId, CreateMenu payload, bool? validate_only, System.Threading.CancellationToken cancellationToken);
    
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
    
        /// <summary>Random and unique string for each page. Used for security purpose</summary>
        [System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public int? Page_token { get; set; }= default!;
    
    
    }
    
    /// <summary>getMainMenusResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMainMenusResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public GetMainMenusResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMainMenusResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
    {
    
    }
    
    /// <summary>getMainMenusErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMainMenusErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public GetMainMenusErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMainMenusErrorResponseBody 
    {
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>getMainMenuResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMainMenuResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public GetMainMenuResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMainMenuResponseBody : System.Collections.ObjectModel.Collection<Anonymous2>
    {
    
    }
    
    /// <summary>getMainMenuErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMainMenuErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public GetMainMenuErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMainMenuErrorResponseBody 
    {
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>getMenusResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMenusResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public GetMenusResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMenusResponseBody : System.Collections.ObjectModel.Collection<Anonymous3>
    {
    
    }
    
    /// <summary>getMenusErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMenusErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public GetMenusErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMenusErrorResponseBody 
    {
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>getMenuResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMenuResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public QueryHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public GetMenuResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMenuResponseBody : System.Collections.ObjectModel.Collection<Anonymous4>
    {
    
    }
    
    /// <summary>getMenuErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMenuErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public GetMenuErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetMenuErrorResponseBody 
    {
        /// <summary>The identifier of the error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PayloadHeader 
    {
        /// <summary>pass the record Id to accept all its overrides</summary>
        [System.Text.Json.Serialization.JsonPropertyName("override_acceptId")]
        public string? Override_acceptId { get; set; }= default!;
    
    
    }
    
    /// <summary>createMainMenu</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateMainMenu 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public PayloadHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public CreateMainMenuBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateMainMenuBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public System.Collections.Generic.ICollection<Title>? Title { get; set; }= default!;
    
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("helpmenuid")]
        public System.Collections.Generic.ICollection<Helpmenuid>? Helpmenuid { get; set; }= default!;
    
        /// <summary>user to request the inclusion of the ID of the menu(s) when displaying the main menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayMenuId")]
        public string? DisplayMenuId { get; set; }= default!;
    
    
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
        public Audit3? Audit { get; set; }= default!;
    
    
    }
    
    /// <summary>createMainMenuResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateMainMenuResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ScreenHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public CreateMainMenuResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateMainMenuResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public System.Collections.Generic.ICollection<Title2>? Title { get; set; }= default!;
    
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("helpmenuid")]
        public System.Collections.Generic.ICollection<Helpmenuid2>? Helpmenuid { get; set; }= default!;
    
        /// <summary>user to request the inclusion of the ID of the menu(s) when displaying the main menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayMenuId")]
        public string? DisplayMenuId { get; set; }= default!;
    
    
    }
    
    /// <summary>createMainMenuErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateMainMenuErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public CreateMainMenuErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateMainMenuErrorResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("errorDetails")]
        public System.Collections.Generic.ICollection<ErrorDetails>? ErrorDetails { get; set; }= default!;
    
        /// <summary>The identifier of error type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>createMenu</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateMenu 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public PayloadHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public CreateMenuBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateMenuBody 
    {
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("application")]
        public System.Collections.Generic.ICollection<Application>? Application { get; set; }= default!;
    
        /// <summary>Allows the user to request the inclusion of the Application name when displaying the menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayApplication")]
        public string? DisplayApplication { get; set; }= default!;
    
    
    }
    
    /// <summary>createMenuResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateMenuResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ScreenHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public CreateMenuResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateMenuResponseBody 
    {
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("application")]
        public System.Collections.Generic.ICollection<Application2>? Application { get; set; }= default!;
    
        /// <summary>Allows the user to request the inclusion of the Application name when displaying the menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayApplication")]
        public string? DisplayApplication { get; set; }= default!;
    
    
    }
    
    /// <summary>createMenuErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateMenuErrorResponse 
    {
        [System.Text.Json.Serialization.JsonPropertyName("header")]
        public ErrorHeader? Header { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public CreateMenuErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CreateMenuErrorResponseBody 
    {
        [System.Text.Json.Serialization.JsonPropertyName("errorDetails")]
        public System.Collections.Generic.ICollection<ErrorDetails2>? ErrorDetails { get; set; }= default!;
    
        /// <summary>The identifier of error type</summary>
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>Record Id for Main Menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("mainMenuId")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? MainMenuId { get; set; }= default!;
    
        /// <summary>Main menu title which user wants to display</summary>
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? Title { get; set; }= default!;
    
        /// <summary>valid record id of helptext.menu table which user wants to include in mainmenu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("helpMenuId")]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public string? HelpMenuId { get; set; }= default!;
    
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? Description { get; set; }= default!;
    
        /// <summary>user to request the inclusion of the ID of the menu(s) when displaying the main menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("menuDisplayId")]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string? MenuDisplayId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Audit2 
    {
        /// <summary>Time taken to response by T24</summary>
        [System.Text.Json.Serialization.JsonPropertyName("T24_time")]
        public int? T24_time { get; set; }= default!;
    
        /// <summary>Time taken to parse the response by IRIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("parse_time")]
        public int? Parse_time { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous2 
    {
        /// <summary>Record Id for Main Menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("mainMenuId")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? MainMenuId { get; set; }= default!;
    
        /// <summary>Main menu title which user wants to display</summary>
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? Title { get; set; }= default!;
    
        /// <summary>valid record id of helptext.menu table which user wants to include in mainmenu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("helpMenuId")]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public string? HelpMenuId { get; set; }= default!;
    
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? Description { get; set; }= default!;
    
        /// <summary>user to request the inclusion of the ID of the menu(s) when displaying the main menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("menuDisplayId")]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string? MenuDisplayId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous3 
    {
        /// <summary>Represents the ID by which each menu will be uniquely identified</summary>
        [System.Text.Json.Serialization.JsonPropertyName("menuName")]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string? MenuName { get; set; }= default!;
    
        /// <summary>Valid application name which user want to include in this specific menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("applicationName")]
        [System.ComponentModel.DataAnnotations.StringLength(65)]
        public string? ApplicationName { get; set; }= default!;
    
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? Description { get; set; }= default!;
    
        /// <summary>Allows the user to request the inclusion of the Application name when displaying the menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayApplication")]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string? DisplayApplication { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Anonymous4 
    {
        /// <summary>Represents the ID by which each menu will be uniquely identified</summary>
        [System.Text.Json.Serialization.JsonPropertyName("menuName")]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string? MenuName { get; set; }= default!;
    
        /// <summary>Valid application name which user want to include in this specific menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("applicationName")]
        [System.ComponentModel.DataAnnotations.StringLength(65)]
        public string? ApplicationName { get; set; }= default!;
    
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string? Description { get; set; }= default!;
    
        /// <summary>Allows the user to request the inclusion of the Application name when displaying the menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("displayApplication")]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string? DisplayApplication { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Title 
    {
        /// <summary>Main menu title which user wants to display</summary>
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Helpmenuid 
    {
        /// <summary>valid record id of helptext.menu table which user wants to include in mainmenu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("helpMenuId")]
        public string? HelpMenuId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public System.Collections.Generic.ICollection<Description>? Description { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Audit3 
    {
        /// <summary>Time taken to response by T24</summary>
        [System.Text.Json.Serialization.JsonPropertyName("T24_time")]
        public int? T24_time { get; set; }= default!;
    
        /// <summary>Time taken to parse the response by IRIS</summary>
        [System.Text.Json.Serialization.JsonPropertyName("parse_time")]
        public int? Parse_time { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Title2 
    {
        /// <summary>Main menu title which user wants to display</summary>
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Helpmenuid2 
    {
        /// <summary>valid record id of helptext.menu table which user wants to include in mainmenu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("helpMenuId")]
        public string? HelpMenuId { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public System.Collections.Generic.ICollection<Description2>? Description { get; set; }= default!;
    
    
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
    
        /// <summary>The actual t24 error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Application 
    {
        /// <summary>Valid application name which user want to include in this specific menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("applicationName")]
        public string? ApplicationName { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public System.Collections.Generic.ICollection<Description3>? Description { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Application2 
    {
        /// <summary>Valid application name which user want to include in this specific menu</summary>
        [System.Text.Json.Serialization.JsonPropertyName("applicationName")]
        public string? ApplicationName { get; set; }= default!;
    
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public System.Collections.Generic.ICollection<Description4>? Description { get; set; }= default!;
    
    
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
    
        /// <summary>The actual t24 error message</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Description 
    {
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description1 { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Description2 
    {
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Description3 
    {
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Description4 
    {
        /// <summary>The name used for display purposes</summary>
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016