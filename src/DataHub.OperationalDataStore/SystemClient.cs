using OpenTemenos.DataHubs.OperationalDataStore.System;
using OpenTemenos.DataHubs.OperationalDataStore.System.ServiceDetails;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.DataHubs.OperationalDataStore;

public class SystemClient : ISystemClient
{
    private readonly HttpClient _httpClient;

    public SystemClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IServiceDetailService ServiceAutomationService => new ServiceDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}