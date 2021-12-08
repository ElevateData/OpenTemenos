using Transact.Holding;
using Transact.Holding.Accounts;
using Transact.Holding.Alerts;
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

public class HoldingClient : IHoldingClient
{
    private readonly HttpClient _httpClient;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ICardsService AccountCardService => new CardsService(_httpClient);

    public IAccountsService AccountManagementService => new AccountsService(_httpClient);

    public IArrangementsActivitiesService ArrangementsActivityService => new ArrangementsActivitiesService(_httpClient);

    public ICashManagementBundlesService CashManagementBundleArrangementService => new CashManagementBundlesService(_httpClient);

    public IEntitlementsService CorporateActionEventManagementService => new EntitlementsService(_httpClient);

    public IDashboardsService CorporateDashboardService => new DashboardsService(_httpClient);

    public ICustomerArrangementsService CustomerArrangementService => new CustomerArrangementsService(_httpClient);

    public ICustomersService CustomerHoldingService => new CustomersService(_httpClient);

    public IDerivativesOptionsService DerivativeInstrumentOperationService => new DerivativesOptionsService(_httpClient);

    public ILimitsService LimitLiabilityAndForexLimitService => new LimitsService(_httpClient);

    public IHoldingService HoldingService => new HoldingService(_httpClient);

    public IArrangementsProductLinesService ArrangementForProductLineService => new ArrangementsProductLinesService(_httpClient);

    public IAlertsService ArrangementAccountAlertService => new AlertsService(_httpClient);

    public IArrangementsBalancesService ArrangementAccountDocumentService => new ArrangementsBalancesService(_httpClient);

    public ICollateralsService CustomerCollateralService => new CollateralsService(_httpClient);

    public IForexUtilizationsService ForexUtilizationService => new ForexUtilizationsService(_httpClient);

    public IGuaranteesService GuaranteeService => new GuaranteesService(_httpClient);

    public ILetterOfCreditService LetterOfCreditService => new LetterOfCreditService(_httpClient);

    public IPaymentStopsService PaymentStopService => new PaymentStopsService(_httpClient);

    public IPortfoliosService PortfolioService => new PortfoliosService(_httpClient);

    public IRepurchaseAgreementsService RepurchaseAgreementService => new RepurchaseAgreementsService(_httpClient);

    public ISecurityPositionsService SecurityPositionService => new SecurityPositionsService(_httpClient);

    public IPortfolioSettlementService SecuritySettlementService => new PortfolioSettlementService(_httpClient);

    public ISecurityTradesService SecurityTradeService => new SecurityTradesService(_httpClient);

    public ITransactionsService TransactionService => new TransactionsService(_httpClient);

    public ITreasury Treasury => new Treasury(_httpClient);

    public IUsModelBank UsModelBank => new UsModelBank(_httpClient);
}
