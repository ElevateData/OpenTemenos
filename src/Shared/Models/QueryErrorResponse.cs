namespace Shared.Models;

/// <summary>QueryErrorResponse</summary>
public class QueryErrorResponse
{
    public QueryErrorResponse(ErrorHeader header, QueryErrorResponseBody error)
    {
        Header = header;
        Error = error;
    }

    [System.Text.Json.Serialization.JsonPropertyName("header")]
    public ErrorHeader Header { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("error")]
    public QueryErrorResponseBody Error { get; set; }


}