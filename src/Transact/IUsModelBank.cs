using Transact.Holding.UsDashboards;
using Transact.Holding.UsSafeDeposits;

namespace Transact;

public interface IUsModelBank
{
    public IUsDashboardService HoldingSummaryService { get; }
    //public IUsLoanService LoanService { get; }
    //public IUsAccountService AccountService { get; }
    //public IUsDepositService DepositService { get; }
    public IUsSafeDepositService SafeDepositService { get; }
}
