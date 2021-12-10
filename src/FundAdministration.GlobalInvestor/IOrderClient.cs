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

public interface IOrderClient
{
    public IReceiptService CashReceiptService { get; }
    public IAnnouncementService DividendPaymentService { get; }
    public IDividendRateService DividendRateService { get; }
    public IOrderNotificationService ErrorInterfaceService { get; }
    public IExchangeRateService ExchangeRateService { get; }
    public IInstructionService InstructionService { get; }
    public ISecurityPriceUpdateService MarketValueHistoricalService { get; }
    public IOrderCancelReverseService OrderCancellationService { get; }
    public IOrderService OrderService { get; }
    public IPaymentAmendmentService PaymentAmendmentService { get; }
    public IPaymentService PaymentService { get; }
    public IPaymentLogProcesseService PaymentLogService { get; }
    public IContractChangeService RegisterContractChangeService { get; }
    public IContractHistoryService RegisterHistoricalContractService { get; }
    public INavService SharePriceService { get; }
    public ITradingDeskRateService TradingDeskValidationService { get; }
    public IAdjustmentService UnderlyingRegAdjustmentService { get; }
}
