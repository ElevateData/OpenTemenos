namespace FundAdministration.GlobalInvestor;

public class GlobalInvestorClient : IGlobalInvestorClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public GlobalInvestorClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IOrderClient OrderClient => new OrderClient(_httpClient) { BaseUrl = BaseUrl };

    public IPartyClient PartyClient => new PartyClient(_httpClient) { BaseUrl = BaseUrl };

    public IProductClient ProductClient => new ProductClient(_httpClient) { BaseUrl = BaseUrl };

    public IReferenceClient ReferenceClient => new ReferenceClient(_httpClient) { BaseUrl = BaseUrl };

    public ISystemClient SystemClient => new SystemClient(_httpClient) { BaseUrl = BaseUrl };
}
