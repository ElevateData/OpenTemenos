using Transact.Product.Customers;
using Transact.Product.ExternalProducts;
using Transact.Product.LimitProducts;
using Transact.Product.MarketingCatalogues;
using Transact.Product.UserAdmins;

namespace Transact;

//TODO: Rename Transact.IProductClient methods
public interface IProductClient
{
    public ICustomerService CustomerService { get; }
    public IExternalProductService ExternalProductService { get; }
    public ILimitProductService LimitProductService { get; }
    public IMarketingCatalogueService MarketingCatalogueService { get; }
    public IUserAdminService UserAdminService { get; }

}