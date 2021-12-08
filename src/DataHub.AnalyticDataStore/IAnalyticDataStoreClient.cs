namespace DataHub.AnalyticDataStore;

public interface IAnalyticDataStoreClient
{
    public IHoldingClient Holding { get; }
    public IPartyClient Party { get; }
    public IProductClient Product { get; }
}