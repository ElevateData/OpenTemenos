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

public class HoldingClient : IHoldingClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ICardService AccountCardService => new CardService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAccountService AccountManagementService => new AccountService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IArrangementsActivityService ArrangementsActivityService => new ArrangementsActivityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICashManagementBundleService CashManagementBundleArrangementService => new CashManagementBundleService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEntitlementService CorporateActionEventManagementService => new EntitlementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDashboardService CorporateDashboardService => new DashboardService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    [Obsolete("All methods are obsolete")]
    public IDepositService DepositService => new DepositService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICurrencyPositionService CurrencyPositionService => new CurrencyPositionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerArrangementService CustomerArrangementService => new CustomerArrangementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerService CustomerHoldingService => new CustomerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDerivativesOptionService DerivativeInstrumentOperationService => new DerivativesOptionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ILimitService LimitLiabilityAndForexLimitService => new LimitService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IHoldingService HoldingService => new HoldingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IArrangementsProductLineService ArrangementForProductLineService => new ArrangementsProductLineService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAlertService ArrangementAccountAlertService => new AlertService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IArrangementsBalanceService ArrangementAccountDocumentService => new ArrangementsBalanceService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICollateralService CustomerCollateralService => new CollateralService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICreateNonDeliverableForwardService CreateNonDeliverableForwardService => new CreateNonDeliverableForwardService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IForexUtilizationService ForexUtilizationService => new ForexUtilizationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IGuaranteeService GuaranteeService => new GuaranteeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ILetterOfCreditService LetterOfCreditService => new LetterOfCreditService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentStopService PaymentStopService => new PaymentStopService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPortfolioService PortfolioService => new PortfolioService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPositionService PositionService => new PositionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IReportService ReportService => new ReportService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRepurchaseAgreementService RepurchaseAgreementService => new RepurchaseAgreementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityPositionService SecurityPositionService => new SecurityPositionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPortfolioSettlementService SecuritySettlementService => new PortfolioSettlementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityTradeService SecurityTradeService => new SecurityTradeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISwapNpvRevaluationService SwapNpvRevaluationService => new SwapNpvRevaluationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITransactionService TransactionService => new TransactionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITreasury Treasury => new Treasury(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITreasuryCurrencyService TreasuryCurrencyService => new TreasuryCurrencyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITreasuryCurrencyPairService TreasuryCurrencyPairService => new TreasuryCurrencyPairService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUsModelBank UsModelBank => new UsModelBank(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
