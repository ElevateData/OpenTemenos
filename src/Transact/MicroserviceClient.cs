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

    public MicroserviceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ICallbackRegistryService CallbackRegistryService => new CallbackRegistryService(_httpClient);
    public IEntitlementService EntitlementService => new EntitlementService(_httpClient);
    public IGenericConfigService ConfigurationService => new GenericConfigService(_httpClient);
    public IMeteringService ApplicationMeteringService => new MeteringService(_httpClient);
    public IServiceOrchestratorService ServiceOrchestratorService => new ServiceOrchestratorService(_httpClient);
    public ITraceabilityService TraceabilityService => new TraceabilityService(_httpClient);
}
