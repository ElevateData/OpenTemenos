using Transact.Holding.Accounts;
using Transact.Holding.Alerts;
//using Transact.Holding.Arrangements;
using Transact.Holding.ArrangementsActivities;
using Transact.Holding.ArrangementsBalances;
using Transact.Holding.ArrangementsProductLines;
using Transact.Holding.Cards;
using Transact.Holding.CashManagementBundles;
using Transact.Holding.Collaterals;
using Transact.Holding.CreateNonDeliverableForwards;
using Transact.Holding.CurrencyPositions;
using Transact.Holding.CustomerArrangements;
using Transact.Holding.Customers;
using Transact.Holding.Dashboards;
using Transact.Holding.Deposits;
using Transact.Holding.DerivativesOptions;
using Transact.Holding.Entitlements;
using Transact.Holding.ForexUtilizations;
using Transact.Holding.Guarantees;
using Transact.Holding.LetterOfCredits;
using Transact.Holding.Limits;
using Transact.Holding.PaymentStops;
using Transact.Holding.Portfolios;
using Transact.Holding.PortfolioSettlements;
using Transact.Holding.Positions;
using Transact.Holding.Reports;
using Transact.Holding.RepurchaseAgreements;
using Transact.Holding.SecurityPositions;
using Transact.Holding.SecurityTrades;
using Transact.Holding.Services;
using Transact.Holding.SwapNpvRevaluations;
using Transact.Holding.Transactions;
using Transact.Holding.TreasuryCurrencies;
using Transact.Holding.TreasuryCurrencyPairs;

namespace Transact;

public interface IHoldingClient
{
    public ICardService AccountCardService { get; }
    public IAccountService AccountManagementService { get; }
    [Obsolete("All methods are obsolete")]
    public IArrangementsActivityService ArrangementsActivityService { get; }
    //public IArrangementService ArrangementDetailService { get; }
    public ICashManagementBundleService CashManagementBundleArrangementService { get; }
    //public IUserAdminService ChannelUserAdministrationService {get;}
    public IEntitlementService CorporateActionEventManagementService { get; }
    //public ICreditAgreementsApiService CorporateCreditAgreementService {get;}
    public IDashboardService CorporateDashboardService { get; }
    public IDepositService DepositService { get; }
    //public ILoansArrangementService LoanCreationService {get;}
    public ICurrencyPositionService CurrencyPositionService { get; }
    //public IAccountsArrangementService CustomerArrangementAccountService { get; }
    public ICustomerArrangementService CustomerArrangementService { get; }
    public ICustomerService CustomerHoldingService { get; }
    public IDerivativesOptionService DerivativeInstrumentOperationService { get; }
    //public ICalculatePayoffService InitialLoanPayoffService { get; }
    //public IUpdatePaymentHolidayService UpdatePaymentHolidayService { get; }
    public ILimitService LimitLiabilityAndForexLimitService { get; }
    public IHoldingService HoldingService { get; }
    public IArrangementsProductLineService ArrangementForProductLineService { get; }
    //public ILoansArrangementService LoansCreationService { get; }
    public IAlertService ArrangementAccountAlertService { get; }
    [Obsolete("All methods are obsolete")]
    public IArrangementsBalanceService ArrangementAccountDocumentService { get; }
    public ICollateralService CustomerCollateralService { get; }
    public ICreateNonDeliverableForwardService CreateNonDeliverableForwardService { get; }
    public IForexUtilizationService ForexUtilizationService { get; }
    public IGuaranteeService GuaranteeService { get; }
    public ILetterOfCreditService LetterOfCreditService { get; }
    public IPaymentStopService PaymentStopService { get; }
    public IPortfolioService PortfolioService { get; }
    public IPositionService PositionService { get; }
    public IReportService ReportService { get; }
    public IRepurchaseAgreementService RepurchaseAgreementService { get; }
    public ISecurityPositionService SecurityPositionService { get; }
    public IPortfolioSettlementService SecuritySettlementService { get; }
    public ISecurityTradeService SecurityTradeService { get; }
    public ISwapNpvRevaluationService SwapNpvRevaluationService { get; }
    //public IUpdatePaymentHolidaySimulationService UpdatePaymentHolidaySimulationService { get; }
    public ITransactionService TransactionService { get; }
    public ITreasury Treasury { get; }
    public ITreasuryCurrencyService TreasuryCurrencyService { get; }
    public ITreasuryCurrencyPairService TreasuryCurrencyPairService { get; }
    public IUsModelBank UsModelBank { get; }

    //Not sure if this item is being used by Temenos
    //public IDepositService DepositService { get; }
}