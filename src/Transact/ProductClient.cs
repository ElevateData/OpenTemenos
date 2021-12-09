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
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ICustomersService CustomersService => new CustomersService(_httpClient) { BaseUrl = BaseUrl };
    public IExternalProductsService ExternalProductsService => new ExternalProductsService(_httpClient) { BaseUrl = BaseUrl };
    public ILimitProductsService LimitProductsService => new LimitProductsService(_httpClient) { BaseUrl = BaseUrl };
    public IMarketingCatalogueService MarketingCatalogueService => new MarketingCatalogueService(_httpClient) { BaseUrl = BaseUrl };
    public IUserAdminService UserAdminService => new UserAdminService(_httpClient) { BaseUrl = BaseUrl };
}
