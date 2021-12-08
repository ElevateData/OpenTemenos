using Transact.Holding.Accounts;
using Transact.Holding.Alerts;
//using Transact.Holding.Arrangements;
using Transact.Holding.ArrangementsActivities;
using Transact.Holding.ArrangementsBalances;
using Transact.Holding.ArrangementsProductLines;
using Transact.Holding.Cards;
using Transact.Holding.CashManagementBundles;
using Transact.Holding.Collaterals;
using Transact.Holding.CustomerArrangements;
using Transact.Holding.Customers;
using Transact.Holding.Dashboards;
using Transact.Holding.DerivativesOptions;
using Transact.Holding.Entitlements;
using Transact.Holding.ForexUtilizations;
using Transact.Holding.Guarantees;
using Transact.Holding.LetterOfCreditX;
using Transact.Holding.Limits;
using Transact.Holding.PaymentStops;
using Transact.Holding.Portfolios;
using Transact.Holding.PortfolioSettlement;
using Transact.Holding.RepurchaseAgreements;
using Transact.Holding.SecurityPositions;
using Transact.Holding.SecurityTrades;
using Transact.Holding.Service;
using Transact.Holding.Transactions;

namespace Transact;

public interface IHoldingClient
{
    public ICardsService AccountCardService { get; }
    public IAccountsService AccountManagementService { get; }
    public IArrangementsActivitiesService ArrangementsActivityService { get; }
    //public IArrangementsService ArrangementDetailService { get; }
    public ICashManagementBundlesService CashManagementBundleArrangementService { get; }
    //public IUserAdminService ChannelUserAdministrationService {get;}
    public IEntitlementsService CorporateActionEventManagementService { get; }
    //public ICreditAgreementsApiService CorporateCreditAgreementsService {get;}
    public IDashboardsService CorporateDashboardService { get; }
    //public ILoansArrangementsService LoanCreationService {get;}
    //public IAccountsArrangementsService CustomerArrangementAccountService { get; }
    public ICustomerArrangementsService CustomerArrangementService { get; }
    public ICustomersService CustomerHoldingService { get; }
    public IDerivativesOptionsService DerivativeInstrumentOperationService { get; }
    //public ICalculatePayoffService InitialLoanPayoffService { get; }
    //public IUpdatePaymentHolidayService UpdatePaymentHolidayService { get; }
    public ILimitsService LimitLiabilityAndForexLimitService { get; }
    public IHoldingService HoldingService { get; }
    public IArrangementsProductLinesService ArrangementForProductLineService { get; }
    //public ILoansArrangementsService LoansCreationService { get; }
    public IAlertsService ArrangementAccountAlertService { get; }
    public IArrangementsBalancesService ArrangementAccountDocumentService { get; }
    public ICollateralsService CustomerCollateralService { get; }
    public IForexUtilizationsService ForexUtilizationService { get; }
    public IGuaranteesService GuaranteeService { get; }
    public ILetterOfCreditService LetterOfCreditService { get; }
    public IPaymentStopsService PaymentStopService { get; }
    public IPortfoliosService PortfolioService { get; }
    public IRepurchaseAgreementsService RepurchaseAgreementService { get; }
    public ISecurityPositionsService SecurityPositionService { get; }
    public IPortfolioSettlementService SecuritySettlementService { get; }
    public ISecurityTradesService SecurityTradeService { get; }
    //public IUpdatePaymentHolidaySimulationService UpdatePaymentHolidaySimulationService { get; }
    public ITransactionsService TransactionService { get; }
    public ITreasury Treasury { get; }
    public IUsModelBank UsModelBank { get; }

    //Not sure if this item is being used by Temenos
    //public IDepositsService DepositsService { get; }
}