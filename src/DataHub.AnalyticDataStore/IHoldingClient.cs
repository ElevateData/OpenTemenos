using DataHub.AnalyticDataStore.Holding.AccountTransactionDetails;
using DataHub.AnalyticDataStore.Holding.AccountTransactionMetrics;
using DataHub.AnalyticDataStore.Holding.AllCustomerProductBalances;
using DataHub.AnalyticDataStore.Holding.AllCustomerProfitabilityMetrics;
using DataHub.AnalyticDataStore.Holding.AllCustomerTransactionCount;
using DataHub.AnalyticDataStore.Holding.CustomerAccountBalanceOverdrawn;
using DataHub.AnalyticDataStore.Holding.CustomerDepositMaturity30Days;
using DataHub.AnalyticDataStore.Holding.CustomerLoanDelinquency30Days;
using DataHub.AnalyticDataStore.Holding.ProductTransactionMetrics;
using DataHub.AnalyticDataStore.Holding.RetailDepositsCustomerDetails;
using DataHub.AnalyticDataStore.Holding.RetailLendingCustomerDetails;

namespace DataHub.AnalyticDataStore;

public interface IHoldingClient
{
    public IAccountTransactionDetailsService AccountTransactionDetailService { get; }
    public IAccountTransactionMetricsService AccountTransactionService { get; }
    public ICustomerDepositMaturity30DaysService CustomerDepositService { get; }
    public ICustomerLoanDelinquency30DaysService CustomerLoanDelinquencyService { get; }
    public ICustomerAccountBalanceOverdrawnService CustomerOverdrawnAccountBalanceService { get; }
    public IAllCustomerProductBalancesService CustomerProductBalanceService { get; }
    public IAllCustomerProfitabilityMetricsService CustomerProfitabilityService { get; }
    public IAllCustomerTransactionCountService CustomerTransactionClassificationService { get; }
    public IRetailDepositsCustomerDetailsService DepositCustomerBalanceService { get; }
    public IRetailLendingCustomerDetailsService LendingCustomerBalanceService { get; }
    public IProductTransactionMetricsService ProductTransactionService { get; }
}
