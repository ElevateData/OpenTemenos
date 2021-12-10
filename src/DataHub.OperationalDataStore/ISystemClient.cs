using DataHub.OperationalDataStore.System.ServiceDetails;

namespace DataHub.OperationalDataStore;

public interface ISystemClient
{
    public IServiceDetailService ServiceAutomationService { get; }
}
