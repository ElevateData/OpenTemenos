namespace DataHub.OperationalDataStore;

public class OperationalDataStoreClient : IOperationalDataStoreClient
{
    private readonly HttpClient _httpClient;

    public OperationalDataStoreClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IHoldingClient Holding => new HoldingClient(_httpClient);
    public IOrderClient Order => new OrderClient(_httpClient);
    public IPartyClient Party => new PartyClient(_httpClient);
    public IProductClient Product => new ProductClient(_httpClient);
    public IReferenceClient Reference => new ReferenceClient(_httpClient);
    public ISystemClient System => new SystemClient(_httpClient);
}
