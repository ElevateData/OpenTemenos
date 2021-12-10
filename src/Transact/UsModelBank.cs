using Transact.Holding;
using Transact.Holding.UsDashboards;
using Transact.Holding.UsSafeDeposits;

namespace Transact;

public class UsModelBank : IUsModelBank
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public UsModelBank(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IUsDashboardService HoldingSummaryService => new UsDashboardService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUsSafeDepositService SafeDepositService => new UsSafeDepositService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
