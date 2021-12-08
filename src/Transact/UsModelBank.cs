using Transact.Holding;
using Transact.Holding.UsDashboards;
using Transact.Holding.UsSafeDeposits;

namespace Transact;

public class UsModelBank : IUsModelBank
{
    private readonly HttpClient _httpClient;

    public UsModelBank(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IUsDashboardsService HoldingSummaryService => new UsDashboardsService(_httpClient);

    public IUsSafeDepositsService SafeDepositService => new UsSafeDepositsService(_httpClient);
}
