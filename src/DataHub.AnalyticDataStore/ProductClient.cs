using DataHub.AnalyticDataStore.Product;
using DataHub.AnalyticDataStore.Product.CorporateLendingProductBalances;
using DataHub.AnalyticDataStore.Product.RetailDepositProductBalances;
using DataHub.AnalyticDataStore.Product.RetailLendingProductBalances;

namespace DataHub.AnalyticDataStore;

public class ProductClient : IProductClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ICorporateLendingProductBalancesService CorporateLendingProductService =>
        new CorporateLendingProductBalancesService(_httpClient){BaseUrl = BaseUrl};

    public IRetailDepositProductBalancesService RetailDepositProductBalanceService =>
        new RetailDepositProductBalancesService(_httpClient){BaseUrl = BaseUrl};

    public IRetailLendingProductBalancesService RetailLendingProductBalanceService =>
        new RetailLendingProductBalancesService(_httpClient){BaseUrl = BaseUrl};
}
