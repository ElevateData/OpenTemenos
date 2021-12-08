using FundAdministration.GlobalInvestor.Order;
using FundAdministration.GlobalInvestor.Order.Adjustments;
using FundAdministration.GlobalInvestor.Order.Announcements;
using FundAdministration.GlobalInvestor.Order.ContractChanges;
using FundAdministration.GlobalInvestor.Order.ContractHistory;
using FundAdministration.GlobalInvestor.Order.DividendRates;
using FundAdministration.GlobalInvestor.Order.ExchangeRate;
using FundAdministration.GlobalInvestor.Order.Instruction;
using FundAdministration.GlobalInvestor.Order.Nav;
using FundAdministration.GlobalInvestor.Order.Order;
using FundAdministration.GlobalInvestor.Order.OrderCancelReverse;
using FundAdministration.GlobalInvestor.Order.OrderNotification;
using FundAdministration.GlobalInvestor.Order.PaymentAmendments;
using FundAdministration.GlobalInvestor.Order.PaymentLogProcesses;
using FundAdministration.GlobalInvestor.Order.Payments;
using FundAdministration.GlobalInvestor.Order.Receipts;
using FundAdministration.GlobalInvestor.Order.SecurityPriceUpdates;
using FundAdministration.GlobalInvestor.Order.TradingDeskRates;

namespace FundAdministration.GlobalInvestor;

public class OrderClient : IOrderClient
{
    private readonly HttpClient _httpClient;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAdjustmentsService UnderlyingRegAdjustmentService => new AdjustmentsService(_httpClient);
    public IAnnouncementsService DividendPaymentService => new AnnouncementsService(_httpClient);
    public IContractChangesService RegisterContractChangeService => new ContractChangesService(_httpClient);
    public IContractHistoryService RegisterHistoricalContractService => new ContractHistoryService(_httpClient);
    public IDividendRatesService DividendRateService => new DividendRatesService(_httpClient);
    public IExchangeRateService ExchangeRateService => new ExchangeRateService(_httpClient);
    public IInstructionService InstructionService => new InstructionService(_httpClient);
    public INavService SharePriceService => new NavService(_httpClient);
    public IOrderCancelReverseService OrderCancellationService => new OrderCancelReverseService(_httpClient);
    public IOrderNotificationService ErrorInterfaceService => new OrderNotificationService(_httpClient);
    public IOrderService OrderService => new OrderService(_httpClient);
    public IPaymentAmendmentsService PaymentAmendmentService => new PaymentAmendmentsService(_httpClient);
    public IPaymentLogProcessesService PaymentLogService => new PaymentLogProcessesService(_httpClient);
    public IPaymentsService PaymentService => new PaymentsService(_httpClient);
    public IReceiptsService CashReceiptService => new ReceiptsService(_httpClient);
    public ISecurityPriceUpdatesService MarketValueHistoricalService => new SecurityPriceUpdatesService(_httpClient);
    public ITradingDeskRatesService TradingDeskValidationService => new TradingDeskRatesService(_httpClient);
}
