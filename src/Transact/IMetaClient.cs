using Transact.Meta.Apis;
using Transact.Meta.DwExportProperties;
using Transact.Meta.Menus;
using Transact.Meta.Payments;
using Transact.Meta.Queries;
using Transact.Meta.Screens;
using Transact.Meta.Tables;
using Transact.Meta.UserAdministrationInternal;
using Transact.Meta.VirtualTable;

namespace Transact;

public interface IMetaClient
{
    public IApisService ApisService { get; }
    public IDwExportPropertiesService DwExportPropertyService { get; }
    public IMenusService MenuService { get; }
    public IPaymentsService PaymentService { get; }
    public IQueriesService QueryService { get; }
    public IScreensService ScreenService { get; }
    public ITablesService TableService { get; }
    public IUserAdministrationInternalService UserAdministrationInternalService { get; }
    public IVirtualTableService VirtualTableService { get; }

}