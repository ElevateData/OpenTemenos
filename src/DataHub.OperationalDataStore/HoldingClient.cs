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

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IArrangementsDetailsService ArrangementsDetailService => new ArrangementsDetailsService(_httpClient);
    public ITradeDetailsService DerivativeInstrumentOperationService => new TradeDetailsService(_httpClient);
    public IGuaranteeDetailsService GuaranteeDetailService => new GuaranteeDetailsService(_httpClient);
    public ILcDetailsService LetterOfCreditService => new LcDetailsService(_httpClient);
    public ILimitDetailsService LimitDetailService => new LimitDetailsService(_httpClient);
    public IAccountListService NostroVostroAccountListService => new AccountListService(_httpClient);
    public IPaymentStopsService PaymentStopService => new PaymentStopsService(_httpClient);
    public IPortfoliosService PortfolioDetailService => new PortfoliosService(_httpClient);

    public IRepurchaseAgreementsService RepurchaseAgreementService =>
        new RepurchaseAgreementsService(_httpClient);
}
