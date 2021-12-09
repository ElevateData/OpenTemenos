namespace OpenTemenos;

public class OpenTemenosClient : IOpenTemenosClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public OpenTemenosClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IDataHub DataHub => new DataHub(_httpClient){BaseUrl = BaseUrl};

    [Obsolete]
    public IFinancialCrimeMitigation FinancialCrimeMitigation => throw new NotImplementedException();

    public ITransact Transact => new Transact(_httpClient){BaseUrl = BaseUrl};

    public IFundAdministration FundAdministration => new FundAdministration(_httpClient){BaseUrl = BaseUrl};

    [Obsolete]
    public IPortfolioManagement PortfolioManagement => throw new NotImplementedException();

    public IPayment Payment => new Payment(_httpClient){BaseUrl = BaseUrl};
}