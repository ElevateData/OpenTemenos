using DataHub.AnalyticDataStore.Holding;
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

public class HoldingClient : IHoldingClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IAccountTransactionDetailService AccountTransactionDetailService =>
        new AccountTransactionDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAccountTransactionMetricService AccountTransactionService =>
        new AccountTransactionMetricService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerDepositMaturity30DayService CustomerDepositService =>
        new CustomerDepositMaturity30DayService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerLoanDelinquency30DayService CustomerLoanDelinquencyService =>
        new CustomerLoanDelinquency30DayService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerAccountBalanceOverdrawnService CustomerOverdrawnAccountBalanceService =>
        new CustomerAccountBalanceOverdrawnService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAllCustomerProductBalanceService CustomerProductBalanceService =>
        new AllCustomerProductBalanceService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAllCustomerProfitabilityMetricService CustomerProfitabilityService =>
        new AllCustomerProfitabilityMetricService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAllCustomerTransactionCountService CustomerTransactionClassificationService =>
        new AllCustomerTransactionCountService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRetailDepositsCustomerDetailService DepositCustomerBalanceService =>
        new RetailDepositsCustomerDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRetailLendingCustomerDetailService LendingCustomerBalanceService =>
        new RetailLendingCustomerDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IProductTransactionMetricService ProductTransactionService =>
        new ProductTransactionMetricService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
