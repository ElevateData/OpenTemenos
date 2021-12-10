using DataHub.OperationalDataStore.Product.InterestCatalogs;
using DataHub.OperationalDataStore.Product.InterestConditionDetails;
using DataHub.OperationalDataStore.Product.ProductBuilderDetails;
using DataHub.OperationalDataStore.Product.ProductConditionDetails;
using DataHub.OperationalDataStore.Product.ProductDetails;
using DataHub.OperationalDataStore.Product.ProductMarketingCatalogues;

namespace DataHub.OperationalDataStore;

public interface IProductClient
{
    public IProductBuilderDetailService ProductBuilderService { get; }
    public IProductConditionDetailService ProductConditionService { get; }
    public IProductDetailService ProductDetailService { get; }
    public IInterestCatalogService InterestCatalogService { get; }
    public IInterestConditionDetailService ProductInterestConditionService { get; }
    public IProductMarketingCatalogueService ProductMarketingCatalogService { get; }
}
