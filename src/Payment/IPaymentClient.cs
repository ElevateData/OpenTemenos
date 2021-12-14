using OpenTemenos.Payments.DirectDebit;
using OpenTemenos.Payments.PaymentOrders;
using OpenTemenos.Payments.PaymentOrdersConfigurations;
using OpenTemenos.Payments.Payments;
using OpenTemenos.Payments.PaymentStops;
using OpenTemenos.Payments.RequestToPayPayments;
using OpenTemenos.Payments.StandingOrders;
using OpenTemenos.Payments.TransactionStops;

namespace OpenTemenos.Payments;

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