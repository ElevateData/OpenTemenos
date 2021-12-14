using OpenTemenos.DataHubs.OperationalDataStore.System.ServiceDetails;

namespace OpenTemenos.DataHubs.OperationalDataStore;

public interface ISystemClient
{
    public IServiceDetailService ServiceAutomationService { get; }
}