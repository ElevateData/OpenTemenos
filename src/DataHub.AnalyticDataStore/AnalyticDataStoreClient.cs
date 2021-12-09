namespace DataHub.AnalyticDataStore;

public class AnalyticDataStoreClient : IAnalyticDataStoreClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;
    public AnalyticDataStoreClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IHoldingClient Holding => new HoldingClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPartyClient Party => new PartyClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IProductClient Product => new ProductClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}