using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalInvestor;

namespace OpenTemenos;

public class FundAdministration : IFundAdministration
{
    private readonly HttpClient _httpClient;

    public FundAdministration(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IGlobalAccountingClient GlobalAccountingClient => new GlobalAccountingClient(_httpClient);

    public IGlobalInvestorClient GlobalInvestorClient => new GlobalInvestorClient(_httpClient);
}
