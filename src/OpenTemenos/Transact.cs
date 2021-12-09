using Transact;

namespace OpenTemenos;

public class Transact : ITransact
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public Transact(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IEnterpriseClient Enterprise => new EnterpriseClient(_httpClient){BaseUrl = BaseUrl};
    public IHoldingClient Holding => new HoldingClient(_httpClient){BaseUrl = BaseUrl};
    public ILoanClient Loan => new LoanClient(_httpClient){BaseUrl = BaseUrl};
    public IMetaClient Meta => new MetaClient(_httpClient){BaseUrl = BaseUrl};
    public IMicroserviceClient Microservice => new MicroserviceClient(_httpClient){BaseUrl = BaseUrl};
    public IOrderClient Order => new OrderClient(_httpClient){BaseUrl = BaseUrl};
    public IPartyClient Party => new PartyClient(_httpClient){BaseUrl = BaseUrl};
    public IProductClient Product => new ProductClient(_httpClient){BaseUrl = BaseUrl};
    public IReferenceClient Reference => new ReferenceClient(_httpClient){BaseUrl = BaseUrl};
    public ISystemClient System => new SystemClient(_httpClient){BaseUrl = BaseUrl};
}
