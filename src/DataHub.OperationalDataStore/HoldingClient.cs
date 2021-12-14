using OpenTemenos.DataHubs.OperationalDataStore.Holding;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.AccountLists;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.ArrangementsDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.GuaranteeDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.LcDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.LimitDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.PaymentStops;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.Portfolios;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.RepurchaseAgreements;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.TradeDetails;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.DataHubs.OperationalDataStore;

public class HoldingClient : IHoldingClient
{
    private readonly HttpClient _httpClient;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IArrangementsDetailService ArrangementsDetailService => new ArrangementsDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITradeDetailService DerivativeInstrumentOperationService => new TradeDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IGuaranteeDetailService GuaranteeDetailService => new GuaranteeDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ILcDetailService LetterOfCreditService => new LcDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ILimitDetailService LimitDetailService => new LimitDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAccountListService NostroVostroAccountListService => new AccountListService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentStopService PaymentStopService => new PaymentStopService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPortfolioService PortfolioDetailService => new PortfolioService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRepurchaseAgreementService RepurchaseAgreementService =>
        new RepurchaseAgreementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}