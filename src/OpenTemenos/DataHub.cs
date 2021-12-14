using OpenTemenos.DataHubs.AnalyticDataStore;
using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos;

public class DataHub : IDataHub
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public DataHub(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IAnalyticDataStoreClient AnalyticDataStore => new AnalyticDataStoreClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOperationalDataStoreClient OperationalDataStore => new OperationalDataStoreClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}