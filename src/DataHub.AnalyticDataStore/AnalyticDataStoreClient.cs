using OpenTemenos.Shared.Data;

namespace OpenTemenos.DataHubs.AnalyticDataStore;

public class AnalyticDataStoreClient : IAnalyticDataStoreClient
{
    private readonly HttpClient _httpClient;

    public AnalyticDataStoreClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IHoldingClient Holding => new HoldingClient(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPartyClient Party => new PartyClient(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IProductClient Product => new ProductClient(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}