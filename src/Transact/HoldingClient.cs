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
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ICardsService AccountCardService => new CardsService(_httpClient) { BaseUrl = BaseUrl };

    public IAccountsService AccountManagementService => new AccountsService(_httpClient) { BaseUrl = BaseUrl };

    public IArrangementsActivitiesService ArrangementsActivityService => new ArrangementsActivitiesService(_httpClient) { BaseUrl = BaseUrl };

    public ICashManagementBundlesService CashManagementBundleArrangementService => new CashManagementBundlesService(_httpClient) { BaseUrl = BaseUrl };

    public IEntitlementsService CorporateActionEventManagementService => new EntitlementsService(_httpClient) { BaseUrl = BaseUrl };

    public IDashboardsService CorporateDashboardService => new DashboardsService(_httpClient) { BaseUrl = BaseUrl };

    public ICustomerArrangementsService CustomerArrangementService => new CustomerArrangementsService(_httpClient) { BaseUrl = BaseUrl };

    public ICustomersService CustomerHoldingService => new CustomersService(_httpClient) { BaseUrl = BaseUrl };

    public IDerivativesOptionsService DerivativeInstrumentOperationService => new DerivativesOptionsService(_httpClient) { BaseUrl = BaseUrl };

    public ILimitsService LimitLiabilityAndForexLimitService => new LimitsService(_httpClient) { BaseUrl = BaseUrl };

    public IHoldingService HoldingService => new HoldingService(_httpClient) { BaseUrl = BaseUrl };

    public IArrangementsProductLinesService ArrangementForProductLineService => new ArrangementsProductLinesService(_httpClient) { BaseUrl = BaseUrl };

    public IAlertsService ArrangementAccountAlertService => new AlertsService(_httpClient) { BaseUrl = BaseUrl };

    public IArrangementsBalancesService ArrangementAccountDocumentService => new ArrangementsBalancesService(_httpClient) { BaseUrl = BaseUrl };

    public ICollateralsService CustomerCollateralService => new CollateralsService(_httpClient) { BaseUrl = BaseUrl };

    public IForexUtilizationsService ForexUtilizationService => new ForexUtilizationsService(_httpClient) { BaseUrl = BaseUrl };

    public IGuaranteesService GuaranteeService => new GuaranteesService(_httpClient) { BaseUrl = BaseUrl };

    public ILetterOfCreditService LetterOfCreditService => new LetterOfCreditService(_httpClient) { BaseUrl = BaseUrl };

    public IPaymentStopsService PaymentStopService => new PaymentStopsService(_httpClient) { BaseUrl = BaseUrl };

    public IPortfoliosService PortfolioService => new PortfoliosService(_httpClient) { BaseUrl = BaseUrl };

    public IRepurchaseAgreementsService RepurchaseAgreementService => new RepurchaseAgreementsService(_httpClient) { BaseUrl = BaseUrl };

    public ISecurityPositionsService SecurityPositionService => new SecurityPositionsService(_httpClient) { BaseUrl = BaseUrl };

    public IPortfolioSettlementService SecuritySettlementService => new PortfolioSettlementService(_httpClient) { BaseUrl = BaseUrl };

    public ISecurityTradesService SecurityTradeService => new SecurityTradesService(_httpClient) { BaseUrl = BaseUrl };

    public ITransactionsService TransactionService => new TransactionsService(_httpClient) { BaseUrl = BaseUrl };

    public ITreasury Treasury => new Treasury(_httpClient) { BaseUrl = BaseUrl };

    public IUsModelBank UsModelBank => new UsModelBank(_httpClient) { BaseUrl = BaseUrl };
}
