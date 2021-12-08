using DataHub.AnalyticDataStore;
using DataHub.OperationalDataStore;

namespace OpenTemenos;

public class DataHub : IDataHub
{
    private readonly HttpClient _httpClient;

    public DataHub(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IAnalyticDataStoreClient AnalyticDataStore => new AnalyticDataStoreClient(_httpClient);
    public IOperationalDataStoreClient OperationalDataStore => new OperationalDataStoreClient(_httpClient);
}