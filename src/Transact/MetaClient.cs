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
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public MetaClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IApisService ApisService => new ApisService(_httpClient) { BaseUrl = BaseUrl };
    public IDwExportPropertiesService DwExportPropertyService => new DwExportPropertiesService(_httpClient) { BaseUrl = BaseUrl };
    public IMenusService MenuService => new MenusService(_httpClient) { BaseUrl = BaseUrl };
    public IPaymentsService PaymentService => new PaymentsService(_httpClient) { BaseUrl = BaseUrl };
    public IQueriesService QueryService => new QueriesService(_httpClient) { BaseUrl = BaseUrl };
    public IScreensService ScreenService => new ScreensService(_httpClient) { BaseUrl = BaseUrl };
    public ITablesService TableService => new TablesService(_httpClient) { BaseUrl = BaseUrl };
    public IUserAdministrationInternalService UserAdministrationInternalService => new UserAdministrationInternalService(_httpClient) { BaseUrl = BaseUrl };
    public IVirtualTableService VirtualTableService => new VirtualTableService(_httpClient) { BaseUrl = BaseUrl };
}
