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

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

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