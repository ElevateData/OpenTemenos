using OpenTemenos.Payments;

namespace OpenTemenos;

public class OpenTemenosClient : IOpenTemenosClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public OpenTemenosClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IDataHub DataHub => new DataHub(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFinancialCrimeMitigation FinancialCrimeMitigation => throw new NotImplementedException();

    public ITransact Transact => new Transact(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundAdministration FundAdministration => new FundAdministration(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPortfolioManagement PortfolioManagement => throw new NotImplementedException();

    public IPaymentClient Payment => new PaymentClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}