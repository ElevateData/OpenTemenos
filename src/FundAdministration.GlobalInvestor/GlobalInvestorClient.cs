namespace FundAdministration.GlobalInvestor;

public class GlobalInvestorClient : IGlobalInvestorClient
{
    private readonly HttpClient _httpClient;

    public GlobalInvestorClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IOrderClient OrderClient => new OrderClient(_httpClient);

    public IPartyClient PartyClient => new PartyClient(_httpClient);

    public IProductClient ProductClient => new ProductClient(_httpClient);

    public IReferenceClient ReferenceClient => new ReferenceClient(_httpClient);

    public ISystemClient SystemClient => new SystemClient(_httpClient);
}
