using OpenTemenos.DataHubs.AnalyticDataStore.Holding;
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
using OpenTemenos.Shared.Data;

namespace OpenTemenos.DataHubs.AnalyticDataStore;

public class HoldingClient : IHoldingClient
{
    private readonly HttpClient _httpClient;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IAccountTransactionDetailService AccountTransactionDetailService =>
        new AccountTransactionDetailService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAccountTransactionMetricService AccountTransactionService =>
        new AccountTransactionMetricService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerDepositMaturity30DayService CustomerDepositService =>
        new CustomerDepositMaturity30DayService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerLoanDelinquency30DayService CustomerLoanDelinquencyService =>
        new CustomerLoanDelinquency30DayService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerAccountBalanceOverdrawnService CustomerOverdrawnAccountBalanceService =>
        new CustomerAccountBalanceOverdrawnService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAllCustomerProductBalanceService CustomerProductBalanceService =>
        new AllCustomerProductBalanceService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAllCustomerProfitabilityMetricService CustomerProfitabilityService =>
        new AllCustomerProfitabilityMetricService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAllCustomerTransactionCountService CustomerTransactionClassificationService =>
        new AllCustomerTransactionCountService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRetailDepositsCustomerDetailService DepositCustomerBalanceService =>
        new RetailDepositsCustomerDetailService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRetailLendingCustomerDetailService LendingCustomerBalanceService =>
        new RetailLendingCustomerDetailService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IProductTransactionMetricService ProductTransactionService =>
        new ProductTransactionMetricService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}