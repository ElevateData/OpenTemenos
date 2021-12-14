using OpenTemenos.DataHubs.OperationalDataStore.Holding.AccountLists;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.ArrangementsDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.GuaranteeDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.LcDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.LimitDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.PaymentStops;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.Portfolios;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.RepurchaseAgreements;
using OpenTemenos.DataHubs.OperationalDataStore.Holding.TradeDetails;

namespace OpenTemenos.DataHubs.OperationalDataStore;

public interface IHoldingClient
{
    public IArrangementsDetailService ArrangementsDetailService { get; }
    public ITradeDetailService DerivativeInstrumentOperationService { get; }
    public IGuaranteeDetailService GuaranteeDetailService { get; }
    public ILcDetailService LetterOfCreditService { get; }
    public ILimitDetailService LimitDetailService { get; }
    public IAccountListService NostroVostroAccountListService { get; }
    public IPaymentStopService PaymentStopService { get; }
    public IPortfolioService PortfolioDetailService { get; }
    public IRepurchaseAgreementService RepurchaseAgreementService { get; }
}