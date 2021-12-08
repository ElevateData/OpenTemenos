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

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IProductBuilderDetailsService ProductBuilderService => new ProductBuilderDetailsService(_httpClient);
    public IProductConditionDetailsService ProductConditionService => new ProductConditionDetailsService(_httpClient);
    public IProductDetailsService ProductDetailService => new ProductDetailsService(_httpClient);
    public IInterestCatalogService InterestCatalogService => new InterestCatalogService(_httpClient);

    public IInterestConditionDetailsService ProductInterestConditionService =>
        new InterestConditionDetailsService(_httpClient);

    public IProductMarketingCatalogueService ProductMarketingCatalogService =>
        new ProductMarketingCatalogueService(_httpClient);
}
