using DataHub.OperationalDataStore.Product.InterestCatalog;
using DataHub.OperationalDataStore.Product.InterestConditionDetails;
using DataHub.OperationalDataStore.Product.ProductBuilderDetails;
using DataHub.OperationalDataStore.Product.ProductConditionDetails;
using DataHub.OperationalDataStore.Product.ProductDetails;
using DataHub.OperationalDataStore.Product.ProductMarketingCatalogue;

namespace DataHub.OperationalDataStore;

public interface IProductClient
{
    public IProductBuilderDetailsService ProductBuilderService { get; }
    public IProductConditionDetailsService ProductConditionService { get; }
    public IProductDetailsService ProductDetailService { get; }
    public IInterestCatalogService InterestCatalogService { get; }
    public IInterestConditionDetailsService ProductInterestConditionService { get; }
    public IProductMarketingCatalogueService ProductMarketingCatalogService { get; }
}
