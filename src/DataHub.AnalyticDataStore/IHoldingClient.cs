using OpenTemenos.DataHubs.AnalyticDataStore.Holding.AccountTransactionDetails;
using OpenTemenos.DataHubs.AnalyticDataStore.Holding.AccountTransactionMetrics;
using OpenTemenos.DataHubs.AnalyticDataStore.Holding.AllCustomerProductBalances;
using OpenTemenos.DataHubs.AnalyticDataStore.Holding.AllCustomerProfitabilityMetrics;
using OpenTemenos.DataHubs.AnalyticDataStore.Holding.AllCustomerTransactionCounts;
using OpenTemenos.DataHubs.AnalyticDataStore.Holding.CustomerAccountBalanceOverdrawns;
using OpenTemenos.DataHubs.AnalyticDataStore.Holding.CustomerDepositMaturity30Days;
using OpenTemenos.DataHubs.AnalyticDataStore.Holding.CustomerLoanDelinquency30Days;
using OpenTemenos.DataHubs.AnalyticDataStore.Holding.ProductTransactionMetrics;
using OpenTemenos.DataHubs.AnalyticDataStore.Holding.RetailDepositsCustomerDetails;
using OpenTemenos.DataHubs.AnalyticDataStore.Holding.RetailLendingCustomerDetails;

namespace OpenTemenos.DataHubs.AnalyticDataStore;

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