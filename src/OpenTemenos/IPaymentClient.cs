using Payment.DirectDebit;
using Payment.PaymentOrders;
using Payment.PaymentOrdersConfigurations;
using Payment.Payments;
using Payment.PaymentStops;
using Payment.RequestToPayPayments;
using Payment.StandingOrders;
using Payment.TransactionStops;

namespace OpenTemenos;

/// <summary>
/// Payments APIs
/// </summary>
/// <remarks>These are all a subset of the Transact.Orders section and can be used interchangeably.</remarks>
public interface IPaymentClient
{
    //public IBulkPaymentService BulkPaymentService { get; }
    public IDirectDebitService DirectDebitManagementService { get; }
    public IPaymentStopService PaymentStopService { get; }
    public IStandingOrderService StandingOrderService { get; }
    public ITransactionStopService TransactionStopService { get; }
    public IPaymentOrderService PaymentOrderService { get; }
    public IPaymentService PaymentExecutionService { get; }
    public IPaymentOrdersConfigurationService PaymentOrderConfigurationService { get; }
    public IRequestToPayPaymentService RequestToPaymentService { get; }
}