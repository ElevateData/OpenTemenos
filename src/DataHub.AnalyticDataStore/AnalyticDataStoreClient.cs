namespace DataHub.AnalyticDataStore;

public class AnalyticDataStoreClient : IAnalyticDataStoreClient
{
    private readonly HttpClient _httpClient;
    public AnalyticDataStoreClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IHoldingClient Holding => new HoldingClient(_httpClient);
    public IPartyClient Party => new PartyClient(_httpClient);
    public IProductClient Product => new ProductClient(_httpClient);
}