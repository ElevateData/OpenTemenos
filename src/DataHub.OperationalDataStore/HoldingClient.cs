using DataHub.OperationalDataStore.Holding;
using DataHub.OperationalDataStore.Holding.AccountList;
using DataHub.OperationalDataStore.Holding.ArrangementsDetails;
using DataHub.OperationalDataStore.Holding.GuaranteeDetails;
using DataHub.OperationalDataStore.Holding.LcDetails;
using DataHub.OperationalDataStore.Holding.LimitDetails;
using DataHub.OperationalDataStore.Holding.PaymentStops;
using DataHub.OperationalDataStore.Holding.Portfolios;
using DataHub.OperationalDataStore.Holding.RepurchaseAgreements;
using DataHub.OperationalDataStore.Holding.TradeDetails;

namespace DataHub.OperationalDataStore;

public class HoldingClient : IHoldingClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IArrangementsDetailsService ArrangementsDetailService => new ArrangementsDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITradeDetailsService DerivativeInstrumentOperationService => new TradeDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IGuaranteeDetailsService GuaranteeDetailService => new GuaranteeDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ILcDetailsService LetterOfCreditService => new LcDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ILimitDetailsService LimitDetailService => new LimitDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IAccountListService NostroVostroAccountListService => new AccountListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPaymentStopsService PaymentStopService => new PaymentStopsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPortfoliosService PortfolioDetailService => new PortfoliosService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRepurchaseAgreementsService RepurchaseAgreementService =>
        new RepurchaseAgreementsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
