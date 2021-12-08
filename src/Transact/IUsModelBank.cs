using Transact.Holding.UsDashboards;
using Transact.Holding.UsSafeDeposits;

namespace Transact;

public interface IUsModelBank
{
    public IUsDashboardsService HoldingSummaryService { get; }
    //public IUsLoansService LoanService { get; }
    //public IUsAccountsService AccountService { get; }
    //public IUsDepositsService DepositService { get; }
    public IUsSafeDepositsService SafeDepositService { get; }
}
