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
