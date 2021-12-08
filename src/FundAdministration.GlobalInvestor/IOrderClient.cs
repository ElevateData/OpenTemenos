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

public interface IOrderClient
{
    public IReceiptsService CashReceiptService { get; }
    public IAnnouncementsService DividendPaymentService { get; }
    public IDividendRatesService DividendRateService { get; }
    public IOrderNotificationService ErrorInterfaceService { get; }
    public IExchangeRateService ExchangeRateService { get; }
    public IInstructionService InstructionService { get; }
    public ISecurityPriceUpdatesService MarketValueHistoricalService { get; }
    public IOrderCancelReverseService OrderCancellationService { get; }
    public IOrderService OrderService { get; }
    public IPaymentAmendmentsService PaymentAmendmentService { get; }
    public IPaymentsService PaymentService { get; }
    public IPaymentLogProcessesService PaymentLogService { get; }
    public IContractChangesService RegisterContractChangeService { get; }
    public IContractHistoryService RegisterHistoricalContractService { get; }
    public INavService SharePriceService { get; }
    public ITradingDeskRatesService TradingDeskValidationService { get; }
    public IAdjustmentsService UnderlyingRegAdjustmentService { get; }
}
