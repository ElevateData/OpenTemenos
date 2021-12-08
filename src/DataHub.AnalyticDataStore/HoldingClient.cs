using DataHub.AnalyticDataStore.Holding;
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

public class HoldingClient : IHoldingClient
{
    private readonly HttpClient _httpClient;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IAccountTransactionDetailsService AccountTransactionDetailService =>
        new AccountTransactionDetailsService(_httpClient);

    public IAccountTransactionMetricsService AccountTransactionService =>
        new AccountTransactionMetricsService(_httpClient);

    public ICustomerDepositMaturity30DaysService CustomerDepositService =>
        new CustomerDepositMaturity30DaysService(_httpClient);

    public ICustomerLoanDelinquency30DaysService CustomerLoanDelinquencyService =>
        new CustomerLoanDelinquency30DaysService(_httpClient);

    public ICustomerAccountBalanceOverdrawnService CustomerOverdrawnAccountBalanceService =>
        new CustomerAccountBalanceOverdrawnService(_httpClient);

    public IAllCustomerProductBalancesService CustomerProductBalanceService =>
        new AllCustomerProductBalancesService(_httpClient);

    public IAllCustomerProfitabilityMetricsService CustomerProfitabilityService =>
        new AllCustomerProfitabilityMetricsService(_httpClient);

    public IAllCustomerTransactionCountService CustomerTransactionClassificationService =>
        new AllCustomerTransactionCountService(_httpClient);

    public IRetailDepositsCustomerDetailsService DepositCustomerBalanceService =>
        new RetailDepositsCustomerDetailsService(_httpClient);

    public IRetailLendingCustomerDetailsService LendingCustomerBalanceService =>
        new RetailLendingCustomerDetailsService(_httpClient);

    public IProductTransactionMetricsService ProductTransactionService =>
        new ProductTransactionMetricsService(_httpClient);
}
