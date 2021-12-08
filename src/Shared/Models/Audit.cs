namespace Shared.Models;

public class Audit
{
    public Audit(int? t24Time, string versionNumber, double? requestParseTime, double? responseParseTime)
    {
        T24Time = t24Time;
        VersionNumber = versionNumber;
        RequestParseTime = requestParseTime;
        ResponseParseTime = responseParseTime;
    }

    /// <summary>Time taken to response by T24</summary>
    [System.Text.Json.Serialization.JsonPropertyName("T24_time")]
    public int? T24Time { get; set; }

    /// <summary>The CURR.NO. of the record</summary>
    [System.Text.Json.Serialization.JsonPropertyName("versionNumber")]
    public string VersionNumber { get; set; }

    /// <summary>Time taken to parse the request by IRIS</summary>
    [System.Text.Json.Serialization.JsonPropertyName("requestParse_time")]
    public double? RequestParseTime { get; set; }

    /// <summary>Time taken to parse the response by IRIS</summary>
    [System.Text.Json.Serialization.JsonPropertyName("responseParse_time")]
    public double? ResponseParseTime { get; set; }


}