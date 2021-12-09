namespace FundAdministration.GlobalInvestor;

public class GlobalInvestorClient : IGlobalInvestorClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public GlobalInvestorClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IOrderClient OrderClient => new OrderClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPartyClient PartyClient => new PartyClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IProductClient ProductClient => new ProductClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IReferenceClient ReferenceClient => new ReferenceClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISystemClient SystemClient => new SystemClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
