using Transact.Meta.Apis;
using Transact.Meta.DwExportProperties;
using Transact.Meta.Menus;
using Transact.Meta.Payments;
using Transact.Meta.Queries;
using Transact.Meta.Screens;
using Transact.Meta.Tables;
using Transact.Meta.UserAdministrationInternals;
using Transact.Meta.VirtualTables;

namespace Transact;

public interface IMetaClient
{
    public IApiService ApiService { get; }
    public IDwExportPropertyService DwExportPropertyService { get; }
    public IMenuService MenuService { get; }
    public IPaymentService PaymentService { get; }
    public IQueryService QueryService { get; }
    public IScreenService ScreenService { get; }
    public ITableService TableService { get; }
    public IUserAdministrationInternalService UserAdministrationInternalService { get; }
    public IVirtualTableService VirtualTableService { get; }

}