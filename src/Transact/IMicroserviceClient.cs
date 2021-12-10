using Transact.Microservice.CallbackRegistries;
using Transact.Microservice.Entitlements;
using Transact.Microservice.GenericConfigs;
using Transact.Microservice.Meterings;
using Transact.Microservice.ServiceOrchestrators;
using Transact.Microservice.Traceabilities;

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