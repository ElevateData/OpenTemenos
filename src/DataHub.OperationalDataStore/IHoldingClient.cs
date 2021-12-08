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

public interface IHoldingClient
{
    public IArrangementsDetailsService ArrangementsDetailService { get; }
    public ITradeDetailsService DerivativeInstrumentOperationService { get; }
    public IGuaranteeDetailsService GuaranteeDetailService { get; }
    public ILcDetailsService LetterOfCreditService { get; }
    public ILimitDetailsService LimitDetailService { get; }
    public IAccountListService NostroVostroAccountListService { get; }
    public IPaymentStopsService PaymentStopService { get; }
    public IPortfoliosService PortfolioDetailService { get; }
    public IRepurchaseAgreementsService RepurchaseAgreementService { get; }

}
