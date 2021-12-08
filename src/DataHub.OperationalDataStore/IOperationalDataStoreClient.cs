namespace DataHub.OperationalDataStore;

public interface IOperationalDataStoreClient
{
    public IHoldingClient Holding { get; }
    public IOrderClient Order { get; }
    public IPartyClient Party { get; }
    public IProductClient Product { get; }
    public IReferenceClient Reference { get; }
    public ISystemClient System { get; }
}