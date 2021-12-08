using DataHub.AnalyticDataStore;
using DataHub.OperationalDataStore;

namespace OpenTemenos;

public interface IDataHub
{
    public IAnalyticDataStoreClient AnalyticDataStore { get; }
    public IOperationalDataStoreClient OperationalDataStore { get; }
}