using DataHub.AnalyticDataStore.Product;
using DataHub.AnalyticDataStore.Product.CorporateLendingProductBalances;
using DataHub.AnalyticDataStore.Product.RetailDepositProductBalances;
using DataHub.AnalyticDataStore.Product.RetailLendingProductBalances;

namespace DataHub.AnalyticDataStore;

public class ProductClient : IProductClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ICorporateLendingProductBalanceService CorporateLendingProductService =>
        new CorporateLendingProductBalanceService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRetailDepositProductBalanceService RetailDepositProductBalanceService =>
        new RetailDepositProductBalanceService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRetailLendingProductBalanceService RetailLendingProductBalanceService =>
        new RetailLendingProductBalanceService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
