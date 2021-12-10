using Transact.Meta;
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

public class MetaClient : IMetaClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public MetaClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IApiService ApiService => new ApiService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDwExportPropertyService DwExportPropertyService => new DwExportPropertyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IMenuService MenuService => new MenuService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPaymentService PaymentService => new PaymentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IQueryService QueryService => new QueryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IScreenService ScreenService => new ScreenService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITableService TableService => new TableService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUserAdministrationInternalService UserAdministrationInternalService => new UserAdministrationInternalService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IVirtualTableService VirtualTableService => new VirtualTableService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
