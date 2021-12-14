
using OpenTemenos.DataHubs.AnalyticDataStore;
using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos;

public interface IDataHub
{
    public IAnalyticDataStoreClient AnalyticDataStore { get; }
    public IOperationalDataStoreClient OperationalDataStore { get; }
}