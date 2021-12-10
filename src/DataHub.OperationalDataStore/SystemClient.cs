using DataHub.OperationalDataStore.System;
using DataHub.OperationalDataStore.System.ServiceDetails;

namespace DataHub.OperationalDataStore;

public class SystemClient : ISystemClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public SystemClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IServiceDetailService ServiceAutomationService => new ServiceDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
