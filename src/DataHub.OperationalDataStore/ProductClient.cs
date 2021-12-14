using OpenTemenos.DataHubs.OperationalDataStore.Product;
using OpenTemenos.DataHubs.OperationalDataStore.Product.InterestCatalogs;
using OpenTemenos.DataHubs.OperationalDataStore.Product.InterestConditionDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Product.ProductBuilderDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Product.ProductConditionDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Product.ProductDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Product.ProductMarketingCatalogues;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.DataHubs.OperationalDataStore;

public class ProductClient : IProductClient
{
    private readonly HttpClient _httpClient;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IProductBuilderDetailService ProductBuilderService => new ProductBuilderDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IProductConditionDetailService ProductConditionService => new ProductConditionDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IProductDetailService ProductDetailService => new ProductDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IInterestCatalogService InterestCatalogService => new InterestCatalogService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IInterestConditionDetailService ProductInterestConditionService =>
        new InterestConditionDetailService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IProductMarketingCatalogueService ProductMarketingCatalogService =>
        new ProductMarketingCatalogueService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}