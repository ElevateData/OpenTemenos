using Transact.Product;
using Transact.Product.Customers;
using Transact.Product.ExternalProducts;
using Transact.Product.LimitProducts;
using Transact.Product.MarketingCatalogues;
using Transact.Product.UserAdmins;

namespace Transact;

public class ProductClient : IProductClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ICustomerService CustomerService => new CustomerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IExternalProductService ExternalProductService => new ExternalProductService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ILimitProductService LimitProductService => new LimitProductService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IMarketingCatalogueService MarketingCatalogueService => new MarketingCatalogueService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUserAdminService UserAdminService => new UserAdminService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
