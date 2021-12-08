namespace OpenTemenos;

public class OpenTemenosClient : IOpenTemenosClient
{
    private readonly HttpClient _httpClient;

    public OpenTemenosClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IDataHub DataHub => new DataHub(_httpClient);

    [Obsolete]
    public IFinancialCrimeMitigation FinancialCrimeMitigation => throw new NotImplementedException();

    public ITransact Transact => new Transact(_httpClient);

    public IFundAdministration FundAdministration => new FundAdministration(_httpClient);

    [Obsolete]
    public IPortfolioManagement PortfolioManagement => throw new NotImplementedException();

    public IPayment Payment => new Payment(_httpClient);
}