using DataHub.OperationalDataStore.System;
using DataHub.OperationalDataStore.System.ServiceDetails;

namespace DataHub.OperationalDataStore;

public class SystemClient : ISystemClient
{
    private readonly HttpClient _httpClient;

    public SystemClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IServiceDetailsService ServiceAutomationService => new ServiceDetailsService(_httpClient);
}
