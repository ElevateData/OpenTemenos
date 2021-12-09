﻿using FundAdministration.GlobalInvestor.Order;
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
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAdjustmentsService UnderlyingRegAdjustmentService => new AdjustmentsService(_httpClient) { BaseUrl = BaseUrl };
    public IAnnouncementsService DividendPaymentService => new AnnouncementsService(_httpClient) { BaseUrl = BaseUrl };
    public IContractChangesService RegisterContractChangeService => new ContractChangesService(_httpClient) { BaseUrl = BaseUrl };
    public IContractHistoryService RegisterHistoricalContractService => new ContractHistoryService(_httpClient) { BaseUrl = BaseUrl };
    public IDividendRatesService DividendRateService => new DividendRatesService(_httpClient) { BaseUrl = BaseUrl };
    public IExchangeRateService ExchangeRateService => new ExchangeRateService(_httpClient) { BaseUrl = BaseUrl };
    public IInstructionService InstructionService => new InstructionService(_httpClient) { BaseUrl = BaseUrl };
    public INavService SharePriceService => new NavService(_httpClient) { BaseUrl = BaseUrl };
    public IOrderCancelReverseService OrderCancellationService => new OrderCancelReverseService(_httpClient) { BaseUrl = BaseUrl };
    public IOrderNotificationService ErrorInterfaceService => new OrderNotificationService(_httpClient) { BaseUrl = BaseUrl };
    public IOrderService OrderService => new OrderService(_httpClient) { BaseUrl = BaseUrl };
    public IPaymentAmendmentsService PaymentAmendmentService => new PaymentAmendmentsService(_httpClient) { BaseUrl = BaseUrl };
    public IPaymentLogProcessesService PaymentLogService => new PaymentLogProcessesService(_httpClient) { BaseUrl = BaseUrl };
    public IPaymentsService PaymentService => new PaymentsService(_httpClient) { BaseUrl = BaseUrl };
    public IReceiptsService CashReceiptService => new ReceiptsService(_httpClient) { BaseUrl = BaseUrl };
    public ISecurityPriceUpdatesService MarketValueHistoricalService => new SecurityPriceUpdatesService(_httpClient) { BaseUrl = BaseUrl };
    public ITradingDeskRatesService TradingDeskValidationService => new TradingDeskRatesService(_httpClient) { BaseUrl = BaseUrl };
}
