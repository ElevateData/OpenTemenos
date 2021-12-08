using Transact.Product;
using Transact.Product.Customers;
using Transact.Product.ExternalProducts;
using Transact.Product.LimitProducts;
using Transact.Product.MarketingCatalogue;
using Transact.Product.UserAdmin;

namespace Transact;

public class ProductClient : IProductClient
{
    private readonly HttpClient _httpClient;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ICustomersService CustomersService => new CustomersService(_httpClient);
    public IExternalProductsService ExternalProductsService => new ExternalProductsService(_httpClient);
    public ILimitProductsService LimitProductsService => new LimitProductsService(_httpClient);
    public IMarketingCatalogueService MarketingCatalogueService => new MarketingCatalogueService(_httpClient);
    public IUserAdminService UserAdminService => new UserAdminService(_httpClient);
}
