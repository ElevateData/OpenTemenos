using DataHub.OperationalDataStore.Product;
using DataHub.OperationalDataStore.Product.InterestCatalogs;
using DataHub.OperationalDataStore.Product.InterestConditionDetails;
using DataHub.OperationalDataStore.Product.ProductBuilderDetails;
using DataHub.OperationalDataStore.Product.ProductConditionDetails;
using DataHub.OperationalDataStore.Product.ProductDetails;
using DataHub.OperationalDataStore.Product.ProductMarketingCatalogues;

namespace DataHub.OperationalDataStore;

public class ProductClient : IProductClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IProductBuilderDetailService ProductBuilderService => new ProductBuilderDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IProductConditionDetailService ProductConditionService => new ProductConditionDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IProductDetailService ProductDetailService => new ProductDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IInterestCatalogService InterestCatalogService => new InterestCatalogService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IInterestConditionDetailService ProductInterestConditionService =>
        new InterestConditionDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IProductMarketingCatalogueService ProductMarketingCatalogService =>
        new ProductMarketingCatalogueService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
