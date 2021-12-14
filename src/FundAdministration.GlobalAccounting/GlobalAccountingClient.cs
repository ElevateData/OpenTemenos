using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalAccounting;

public class GlobalAccountingClient : IGlobalAccountingClient
{
    private readonly HttpClient _httpClient;

    public GlobalAccountingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IHoldingClient Holding => new HoldingClient(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOrderClient Order => new OrderClient(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IReferenceClient Reference => new ReferenceClient(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}