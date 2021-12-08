using Transact.Meta;
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

public class MetaClient : IMetaClient
{
    private readonly HttpClient _httpClient;

    public MetaClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IApisService ApisService => new ApisService(_httpClient);
    public IDwExportPropertiesService DwExportPropertyService => new DwExportPropertiesService(_httpClient);
    public IMenusService MenuService => new MenusService(_httpClient);
    public IPaymentsService PaymentService => new PaymentsService(_httpClient);
    public IQueriesService QueryService => new QueriesService(_httpClient);
    public IScreensService ScreenService => new ScreensService(_httpClient);
    public ITablesService TableService => new TablesService(_httpClient);
    public IUserAdministrationInternalService UserAdministrationInternalService => new UserAdministrationInternalService(_httpClient);
    public IVirtualTableService VirtualTableService => new VirtualTableService(_httpClient);
}
