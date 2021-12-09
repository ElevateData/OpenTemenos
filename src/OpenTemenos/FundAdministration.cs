using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalInvestor;

namespace OpenTemenos;

public class FundAdministration : IFundAdministration
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public FundAdministration(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IGlobalAccountingClient GlobalAccountingClient => new GlobalAccountingClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IGlobalInvestorClient GlobalInvestorClient => new GlobalInvestorClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
