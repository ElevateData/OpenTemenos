using DataHub.AnalyticDataStore;
using DataHub.OperationalDataStore;

namespace OpenTemenos;

public class DataHub : IDataHub
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public DataHub(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IAnalyticDataStoreClient AnalyticDataStore => new AnalyticDataStoreClient(_httpClient) { BaseUrl = BaseUrl };
    public IOperationalDataStoreClient OperationalDataStore => new OperationalDataStoreClient(_httpClient) { BaseUrl = BaseUrl };
}