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
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IAccountTransactionDetailsService AccountTransactionDetailService =>
        new AccountTransactionDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAccountTransactionMetricsService AccountTransactionService =>
        new AccountTransactionMetricsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerDepositMaturity30DaysService CustomerDepositService =>
        new CustomerDepositMaturity30DaysService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerLoanDelinquency30DaysService CustomerLoanDelinquencyService =>
        new CustomerLoanDelinquency30DaysService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerAccountBalanceOverdrawnService CustomerOverdrawnAccountBalanceService =>
        new CustomerAccountBalanceOverdrawnService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAllCustomerProductBalancesService CustomerProductBalanceService =>
        new AllCustomerProductBalancesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAllCustomerProfitabilityMetricsService CustomerProfitabilityService =>
        new AllCustomerProfitabilityMetricsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAllCustomerTransactionCountService CustomerTransactionClassificationService =>
        new AllCustomerTransactionCountService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRetailDepositsCustomerDetailsService DepositCustomerBalanceService =>
        new RetailDepositsCustomerDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRetailLendingCustomerDetailsService LendingCustomerBalanceService =>
        new RetailLendingCustomerDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IProductTransactionMetricsService ProductTransactionService =>
        new ProductTransactionMetricsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
