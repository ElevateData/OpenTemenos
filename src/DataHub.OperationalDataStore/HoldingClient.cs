using DataHub.OperationalDataStore.Holding;
using DataHub.OperationalDataStore.Holding.AccountLists;
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

    public IArrangementsDetailService ArrangementsDetailService => new ArrangementsDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITradeDetailService DerivativeInstrumentOperationService => new TradeDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IGuaranteeDetailService GuaranteeDetailService => new GuaranteeDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ILcDetailService LetterOfCreditService => new LcDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ILimitDetailService LimitDetailService => new LimitDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IAccountListService NostroVostroAccountListService => new AccountListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPaymentStopService PaymentStopService => new PaymentStopService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPortfolioService PortfolioDetailService => new PortfolioService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRepurchaseAgreementService RepurchaseAgreementService =>
        new RepurchaseAgreementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
