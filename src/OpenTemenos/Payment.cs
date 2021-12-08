using Transact.Order;
using Transact.Order.DirectDebitsX;
using Transact.Order.PaymentOrders;
using Transact.Order.PaymentOrdersConfiguration;
using Transact.Order.Payments;
using Transact.Order.PaymentStops;
using Transact.Order.RequestToPayPayments;
using Transact.Order.StandingOrders;
using Transact.Order.TransactionStopX;

namespace OpenTemenos;

public class Payment : IPayment
{
    private readonly HttpClient _httpClient;

    public Payment(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IDirectDebitsService DirectDebitManagementService => new DirectDebitsService(_httpClient);

    public IPaymentStopsService PaymentStopService => new PaymentStopsService(_httpClient);

    public IStandingOrdersService StandingOrderService => new StandingOrdersService(_httpClient);

    public ITransactionStopService TransactionStopService => new TransactionStopService(_httpClient);

    public IPaymentOrdersService PaymentOrderService => new PaymentOrdersService(_httpClient);

    public IPaymentsService PaymentExecutionService => new PaymentsService(_httpClient);

    public IPaymentOrdersConfigurationService PaymentOrderConfigurationService =>
        new PaymentOrdersConfigurationService(_httpClient);

    public IRequestToPayPaymentsService RequestToPaymentService => new RequestToPayPaymentsService(_httpClient);
}
