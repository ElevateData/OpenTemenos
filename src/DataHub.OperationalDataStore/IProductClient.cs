using OpenTemenos.DataHubs.OperationalDataStore.Product.InterestCatalogs;
using OpenTemenos.DataHubs.OperationalDataStore.Product.InterestConditionDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Product.ProductBuilderDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Product.ProductConditionDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Product.ProductDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Product.ProductMarketingCatalogues;

namespace OpenTemenos.DataHubs.OperationalDataStore;

public interface IProductClient
{
    public IProductBuilderDetailService ProductBuilderService { get; }
    public IProductConditionDetailService ProductConditionService { get; }
    public IProductDetailService ProductDetailService { get; }
    public IInterestCatalogService InterestCatalogService { get; }
    public IInterestConditionDetailService ProductInterestConditionService { get; }
    public IProductMarketingCatalogueService ProductMarketingCatalogService { get; }
}