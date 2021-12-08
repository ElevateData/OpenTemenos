using Transact;

namespace OpenTemenos;

public class Transact : ITransact
{
    private readonly HttpClient _httpClient;

    public Transact(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IEnterpriseClient Enterprise => new EnterpriseClient(_httpClient);
    public IHoldingClient Holding => new HoldingClient(_httpClient);
    public ILoanClient Loan => new LoanClient(_httpClient);
    public IMetaClient Meta => new MetaClient(_httpClient);
    public IMicroserviceClient Microservice => new MicroserviceClient(_httpClient);
    public IOrderClient Order => new OrderClient(_httpClient);
    public IPartyClient Party => new PartyClient(_httpClient);
    public IProductClient Product => new ProductClient(_httpClient);
    public IReferenceClient Reference => new ReferenceClient(_httpClient);
    public ISystemClient System => new SystemClient(_httpClient);
}
