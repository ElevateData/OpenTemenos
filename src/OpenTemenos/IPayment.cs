using Transact.Order.DirectDebitsX;
using Transact.Order.PaymentOrders;
using Transact.Order.PaymentOrdersConfiguration;
using Transact.Order.Payments;
using Transact.Order.PaymentStops;
using Transact.Order.RequestToPayPayments;
using Transact.Order.StandingOrders;
using Transact.Order.TransactionStopX;

namespace OpenTemenos;

/// <summary>
/// Payments APIs
/// </summary>
/// <remarks>These are all a subset of the Transact.Orders section and can be used interchangeably.</remarks>
public interface IPayment
{
    //public IBulkPaymentsService BulkPaymentsService { get; }
    public IDirectDebitsService DirectDebitManagementService { get; }
    public IPaymentStopsService PaymentStopService { get; }
    public IStandingOrdersService StandingOrderService { get; }
    public ITransactionStopService TransactionStopService { get; }
    public IPaymentOrdersService PaymentOrderService { get; }
    public IPaymentsService PaymentExecutionService { get; }
    public IPaymentOrdersConfigurationService PaymentOrderConfigurationService { get; }
    public IRequestToPayPaymentsService RequestToPaymentService { get; }
}