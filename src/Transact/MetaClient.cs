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
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public MetaClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IApisService ApisService => new ApisService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDwExportPropertiesService DwExportPropertyService => new DwExportPropertiesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IMenusService MenuService => new MenusService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPaymentsService PaymentService => new PaymentsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IQueriesService QueryService => new QueriesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IScreensService ScreenService => new ScreensService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITablesService TableService => new TablesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUserAdministrationInternalService UserAdministrationInternalService => new UserAdministrationInternalService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IVirtualTableService VirtualTableService => new VirtualTableService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
