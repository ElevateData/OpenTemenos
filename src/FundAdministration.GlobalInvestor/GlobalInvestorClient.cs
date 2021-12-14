using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public class GlobalInvestorClient : IGlobalInvestorClient
{
    private readonly HttpClient _httpClient;

    public GlobalInvestorClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IOrderClient OrderClient => new OrderClient(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPartyClient PartyClient => new PartyClient(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IProductClient ProductClient => new ProductClient(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IReferenceClient ReferenceClient => new ReferenceClient(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISystemClient SystemClient => new SystemClient(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}