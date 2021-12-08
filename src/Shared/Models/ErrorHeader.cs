namespace Shared.Models;

public class ErrorHeader
{
    public ErrorHeader(Audit audit, string status)
    {
        Audit = audit;
        Status = status;
    }

    [System.Text.Json.Serialization.JsonPropertyName("audit")]
    public Audit Audit { get; set; }

    /// <summary>Status of the API(success/failed)</summary>
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public string Status { get; set; }


}