using Transact.Holding;
using Transact.Holding.Accounts;
using Transact.Holding.Alerts;
using Transact.Holding.ArrangementsActivities;
using Transact.Holding.ArrangementsBalances;
using Transact.Holding.ArrangementsProductLines;
using Transact.Holding.Cards;
using Transact.Holding.CashManagementBundles;
using Transact.Holding.Collaterals;
using Transact.Holding.CreateNonDeliverableForwards;
using Transact.Holding.CurrencyPosition;
using Transact.Holding.CustomerArrangements;
using Transact.Holding.Customers;
using Transact.Holding.Dashboards;
using Transact.Holding.Deposits;
using Transact.Holding.DerivativesOptions;
using Transact.Holding.Entitlements;
using Transact.Holding.ForexUtilizations;
using Transact.Holding.Guarantees;
using Transact.Holding.LetterOfCreditX;
using Transact.Holding.Limits;
using Transact.Holding.PaymentStops;
using Transact.Holding.Portfolios;
using Transact.Holding.PortfolioSettlement;
using Transact.Holding.Position;
using Transact.Holding.Reports;
using Transact.Holding.RepurchaseAgreements;
using Transact.Holding.SecurityPositions;
using Transact.Holding.SecurityTrades;
using Transact.Holding.Service;
using Transact.Holding.SwapNpvRevaluation;
using Transact.Holding.Transactions;
using Transact.Holding.TreasuryCurrencies;
using Transact.Holding.TreasuryCurrencyPairs;
using Transact.Holding.UsDashboards;

namespace Transact;

public class HoldingClient : IHoldingClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ICardsService AccountCardService => new CardsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAccountsService AccountManagementService => new AccountsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IArrangementsActivitiesService ArrangementsActivityService => new ArrangementsActivitiesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICashManagementBundlesService CashManagementBundleArrangementService => new CashManagementBundlesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEntitlementsService CorporateActionEventManagementService => new EntitlementsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDashboardsService CorporateDashboardService => new DashboardsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    [Obsolete("All methods are obsolete")]
    public IDepositsService DepositService => new DepositsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICurrencyPositionService CurrencyPositionService => new CurrencyPositionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerArrangementsService CustomerArrangementService => new CustomerArrangementsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomersService CustomerHoldingService => new CustomersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDerivativesOptionsService DerivativeInstrumentOperationService => new DerivativesOptionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ILimitsService LimitLiabilityAndForexLimitService => new LimitsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IHoldingService HoldingService => new HoldingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IArrangementsProductLinesService ArrangementForProductLineService => new ArrangementsProductLinesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAlertsService ArrangementAccountAlertService => new AlertsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IArrangementsBalancesService ArrangementAccountDocumentService => new ArrangementsBalancesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICollateralsService CustomerCollateralService => new CollateralsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICreateNonDeliverableForwardsService CreateNonDeliverableForwardService => new CreateNonDeliverableForwardsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IForexUtilizationsService ForexUtilizationService => new ForexUtilizationsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IGuaranteesService GuaranteeService => new GuaranteesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ILetterOfCreditService LetterOfCreditService => new LetterOfCreditService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentStopsService PaymentStopService => new PaymentStopsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPortfoliosService PortfolioService => new PortfoliosService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPositionService PositionService => new PositionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IReportsService ReportService => new ReportsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRepurchaseAgreementsService RepurchaseAgreementService => new RepurchaseAgreementsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityPositionsService SecurityPositionService => new SecurityPositionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPortfolioSettlementService SecuritySettlementService => new PortfolioSettlementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityTradesService SecurityTradeService => new SecurityTradesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISwapNpvRevaluationService SwapNpvRevaluationService => new SwapNpvRevaluationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITransactionsService TransactionService => new TransactionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITreasury Treasury => new Treasury(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITreasuryCurrenciesService TreasuryCurrencyService => new TreasuryCurrenciesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITreasuryCurrencyPairsService TreasuryCurrencyPairService => new TreasuryCurrencyPairsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUsModelBank UsModelBank => new UsModelBank(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
