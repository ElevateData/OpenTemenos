using DataHub.OperationalDataStore.Product;
using DataHub.OperationalDataStore.Product.InterestCatalog;
using DataHub.OperationalDataStore.Product.InterestConditionDetails;
using DataHub.OperationalDataStore.Product.ProductBuilderDetails;
using DataHub.OperationalDataStore.Product.ProductConditionDetails;
using DataHub.OperationalDataStore.Product.ProductDetails;
using DataHub.OperationalDataStore.Product.ProductMarketingCatalogue;

namespace DataHub.OperationalDataStore;

public class ProductClient : IProductClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IProductBuilderDetailsService ProductBuilderService => new ProductBuilderDetailsService(_httpClient) { BaseUrl = BaseUrl };
    public IProductConditionDetailsService ProductConditionService => new ProductConditionDetailsService(_httpClient) { BaseUrl = BaseUrl };
    public IProductDetailsService ProductDetailService => new ProductDetailsService(_httpClient) { BaseUrl = BaseUrl };
    public IInterestCatalogService InterestCatalogService => new InterestCatalogService(_httpClient) { BaseUrl = BaseUrl };

    public IInterestConditionDetailsService ProductInterestConditionService =>
        new InterestConditionDetailsService(_httpClient) { BaseUrl = BaseUrl };

    public IProductMarketingCatalogueService ProductMarketingCatalogService =>
        new ProductMarketingCatalogueService(_httpClient) { BaseUrl = BaseUrl };
}
