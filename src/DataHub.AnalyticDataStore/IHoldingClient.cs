using DataHub.AnalyticDataStore.Holding.AccountTransactionDetails;
using DataHub.AnalyticDataStore.Holding.AccountTransactionMetrics;
using DataHub.AnalyticDataStore.Holding.AllCustomerProductBalances;
using DataHub.AnalyticDataStore.Holding.AllCustomerProfitabilityMetrics;
using DataHub.AnalyticDataStore.Holding.AllCustomerTransactionCounts;
using DataHub.AnalyticDataStore.Holding.CustomerAccountBalanceOverdrawns;
using DataHub.AnalyticDataStore.Holding.CustomerDepositMaturity30Days;
using DataHub.AnalyticDataStore.Holding.CustomerLoanDelinquency30Days;
using DataHub.AnalyticDataStore.Holding.ProductTransactionMetrics;
using DataHub.AnalyticDataStore.Holding.RetailDepositsCustomerDetails;
using DataHub.AnalyticDataStore.Holding.RetailLendingCustomerDetails;

namespace DataHub.AnalyticDataStore;

public interface IHoldingClient
{
    public IAccountTransactionDetailService AccountTransactionDetailService { get; }
    public IAccountTransactionMetricService AccountTransactionService { get; }
    public ICustomerDepositMaturity30DayService CustomerDepositService { get; }
    public ICustomerLoanDelinquency30DayService CustomerLoanDelinquencyService { get; }
    public ICustomerAccountBalanceOverdrawnService CustomerOverdrawnAccountBalanceService { get; }
    public IAllCustomerProductBalanceService CustomerProductBalanceService { get; }
    public IAllCustomerProfitabilityMetricService CustomerProfitabilityService { get; }
    public IAllCustomerTransactionCountService CustomerTransactionClassificationService { get; }
    public IRetailDepositsCustomerDetailService DepositCustomerBalanceService { get; }
    public IRetailLendingCustomerDetailService LendingCustomerBalanceService { get; }
    public IProductTransactionMetricService ProductTransactionService { get; }
}
