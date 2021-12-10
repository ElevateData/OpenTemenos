using Payment.DirectDebitsX;
using Payment.PaymentOrders;
using Payment.PaymentOrdersConfiguration;
using Payment.Payments;
using Payment.PaymentStops;
using Payment.RequestToPayPayments;
using Payment.StandingOrders;
using Payment.TransactionStopX;

namespace OpenTemenos;

/// <summary>
/// Payments APIs
/// </summary>
/// <remarks>These are all a subset of the Transact.Orders section and can be used interchangeably.</remarks>
public interface IPaymentClient
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