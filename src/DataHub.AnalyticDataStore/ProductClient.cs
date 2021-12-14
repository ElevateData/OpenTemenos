using OpenTemenos.DataHubs.AnalyticDataStore.Product;
using OpenTemenos.DataHubs.AnalyticDataStore.Product.CorporateLendingProductBalances;
using OpenTemenos.DataHubs.AnalyticDataStore.Product.RetailDepositProductBalances;
using OpenTemenos.DataHubs.AnalyticDataStore.Product.RetailLendingProductBalances;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.DataHubs.AnalyticDataStore;

public class ProductClient : IProductClient
{
    private readonly HttpClient _httpClient;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public ICorporateLendingProductBalanceService CorporateLendingProductService =>
        new CorporateLendingProductBalanceService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRetailDepositProductBalanceService RetailDepositProductBalanceService =>
        new RetailDepositProductBalanceService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRetailLendingProductBalanceService RetailLendingProductBalanceService =>
        new RetailLendingProductBalanceService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}