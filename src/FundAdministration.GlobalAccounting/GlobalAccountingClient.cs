namespace FundAdministration.GlobalAccounting;

public class GlobalAccountingClient : IGlobalAccountingClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public GlobalAccountingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IHoldingClient Holding => new HoldingClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOrderClient Order => new OrderClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IReferenceClient Reference => new ReferenceClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
