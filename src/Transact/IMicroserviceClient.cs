using Transact.Microservice.CallbackRegistry;
using Transact.Microservice.EntitlementX;
using Transact.Microservice.GenericConfig;
using Transact.Microservice.Metering;
using Transact.Microservice.ServiceOrchestrator;
using Transact.Microservice.Traceability;

namespace Transact;

public interface IMicroserviceClient
{
    public IMeteringService ApplicationMeteringService { get; }
    public ICallbackRegistryService CallbackRegistryService { get; }
    public IGenericConfigService ConfigurationService { get; }
    public IEntitlementService EntitlementService { get; }
    //public IEventStoreService EventStoreService { get; }

    public IServiceOrchestratorService ServiceOrchestratorService { get; }
    public ITraceabilityService TraceabilityService { get; }

}