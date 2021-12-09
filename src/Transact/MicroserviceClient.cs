using Transact.Microservice;
using Transact.Microservice.CallbackRegistry;
using Transact.Microservice.EntitlementX;
using Transact.Microservice.GenericConfig;
using Transact.Microservice.Metering;
using Transact.Microservice.ServiceOrchestrator;
using Transact.Microservice.Traceability;

namespace Transact;

public class MicroserviceClient : IMicroserviceClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public MicroserviceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ICallbackRegistryService CallbackRegistryService => new CallbackRegistryService(_httpClient) { BaseUrl = BaseUrl };
    public IEntitlementService EntitlementService => new EntitlementService(_httpClient) { BaseUrl = BaseUrl };
    public IGenericConfigService ConfigurationService => new GenericConfigService(_httpClient) { BaseUrl = BaseUrl };
    public IMeteringService ApplicationMeteringService => new MeteringService(_httpClient) { BaseUrl = BaseUrl };
    public IServiceOrchestratorService ServiceOrchestratorService => new ServiceOrchestratorService(_httpClient) { BaseUrl = BaseUrl };
    public ITraceabilityService TraceabilityService => new TraceabilityService(_httpClient) { BaseUrl = BaseUrl };
}
