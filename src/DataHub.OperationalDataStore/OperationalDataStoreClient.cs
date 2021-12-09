namespace DataHub.OperationalDataStore;

public class OperationalDataStoreClient : IOperationalDataStoreClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public OperationalDataStoreClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IHoldingClient Holding => new HoldingClient(_httpClient) { BaseUrl = BaseUrl };
    public IOrderClient Order => new OrderClient(_httpClient) { BaseUrl = BaseUrl };
    public IPartyClient Party => new PartyClient(_httpClient) { BaseUrl = BaseUrl };
    public IProductClient Product => new ProductClient(_httpClient) { BaseUrl = BaseUrl };
    public IReferenceClient Reference => new ReferenceClient(_httpClient) { BaseUrl = BaseUrl };
    public ISystemClient System => new SystemClient(_httpClient) { BaseUrl = BaseUrl };
}
