using OpenTemenos.FundAdministrations.GlobalInvestor.Order;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.Adjustments;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.Announcements;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.ContractChanges;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.ContractHistories;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.DividendRates;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.ExchangeRates;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.Instructions;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.Navs;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.OrderCancelReverses;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.OrderNotifications;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.Orders;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.PaymentAmendments;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.PaymentLogProcesses;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.Payments;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.Receipts;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.SecurityPriceUpdates;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.TradingDeskRates;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public class OrderClient : IOrderClient
{
    private readonly HttpClient _httpClient;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IAdjustmentService UnderlyingRegAdjustmentService => new AdjustmentService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAnnouncementService DividendPaymentService => new AnnouncementService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IContractChangeService RegisterContractChangeService => new ContractChangeService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IContractHistoryService RegisterHistoricalContractService => new ContractHistoryService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDividendRateService DividendRateService => new DividendRateService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IExchangeRateService ExchangeRateService => new ExchangeRateService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IInstructionService InstructionService => new InstructionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public INavService SharePriceService => new NavService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOrderCancelReverseService OrderCancellationService => new OrderCancelReverseService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOrderNotificationService ErrorInterfaceService => new OrderNotificationService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOrderService OrderService => new OrderService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentAmendmentService PaymentAmendmentService => new PaymentAmendmentService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentLogProcesseService PaymentLogService => new PaymentLogProcesseService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentService PaymentService => new PaymentService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IReceiptService CashReceiptService => new ReceiptService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityPriceUpdateService MarketValueHistoricalService => new SecurityPriceUpdateService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITradingDeskRateService TradingDeskValidationService => new TradingDeskRateService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}