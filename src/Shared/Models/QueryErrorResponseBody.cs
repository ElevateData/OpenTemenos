namespace Shared.Models;

public class QueryErrorResponseBody
{
    public QueryErrorResponseBody(string code, string message, string type)
    {
        Code = code;
        Message = message;
        Type = type;
    }

    /// <summary>The identifier of the error message</summary>
    [System.Text.Json.Serialization.JsonPropertyName("code")]
    public string Code { get; set; }

    /// <summary>The actual t24 error message </summary>
    [System.Text.Json.Serialization.JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>The identifier of error type: </summary>
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public string Type { get; set; }


}