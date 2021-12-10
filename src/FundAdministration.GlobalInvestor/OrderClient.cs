using FundAdministration.GlobalInvestor.Order;
using FundAdministration.GlobalInvestor.Order.Adjustments;
using FundAdministration.GlobalInvestor.Order.Announcements;
using FundAdministration.GlobalInvestor.Order.ContractChanges;
using FundAdministration.GlobalInvestor.Order.ContractHistories;
using FundAdministration.GlobalInvestor.Order.DividendRates;
using FundAdministration.GlobalInvestor.Order.ExchangeRates;
using FundAdministration.GlobalInvestor.Order.Instructions;
using FundAdministration.GlobalInvestor.Order.Navs;
using FundAdministration.GlobalInvestor.Order.OrderCancelReverses;
using FundAdministration.GlobalInvestor.Order.OrderNotifications;
using FundAdministration.GlobalInvestor.Order.Orders;
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
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAdjustmentService UnderlyingRegAdjustmentService => new AdjustmentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IAnnouncementService DividendPaymentService => new AnnouncementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IContractChangeService RegisterContractChangeService => new ContractChangeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IContractHistoryService RegisterHistoricalContractService => new ContractHistoryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDividendRateService DividendRateService => new DividendRateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IExchangeRateService ExchangeRateService => new ExchangeRateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IInstructionService InstructionService => new InstructionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public INavService SharePriceService => new NavService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOrderCancelReverseService OrderCancellationService => new OrderCancelReverseService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOrderNotificationService ErrorInterfaceService => new OrderNotificationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOrderService OrderService => new OrderService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPaymentAmendmentService PaymentAmendmentService => new PaymentAmendmentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPaymentLogProcesseService PaymentLogService => new PaymentLogProcesseService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPaymentService PaymentService => new PaymentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IReceiptService CashReceiptService => new ReceiptService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecurityPriceUpdateService MarketValueHistoricalService => new SecurityPriceUpdateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITradingDeskRateService TradingDeskValidationService => new TradingDeskRateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
