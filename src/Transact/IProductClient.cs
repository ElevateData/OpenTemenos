using Transact.Product.Customers;
using Transact.Product.ExternalProducts;
using Transact.Product.LimitProducts;
using Transact.Product.MarketingCatalogue;
using Transact.Product.UserAdmin;

namespace Transact;

//TODO: Rename Transact.IProductClient methods
public interface IProductClient
{
    public ICustomersService CustomersService { get; }
    public IExternalProductsService ExternalProductsService { get; }
    public ILimitProductsService LimitProductsService { get; }
    public IMarketingCatalogueService MarketingCatalogueService { get; }
    public IUserAdminService UserAdminService { get; }

}