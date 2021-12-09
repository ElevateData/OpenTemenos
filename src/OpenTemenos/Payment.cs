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
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public Payment(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IDirectDebitsService DirectDebitManagementService => new DirectDebitsService(_httpClient){BaseUrl = BaseUrl};

    public IPaymentStopsService PaymentStopService => new PaymentStopsService(_httpClient){BaseUrl = BaseUrl};

    public IStandingOrdersService StandingOrderService => new StandingOrdersService(_httpClient){BaseUrl = BaseUrl};

    public ITransactionStopService TransactionStopService => new TransactionStopService(_httpClient){BaseUrl = BaseUrl};

    public IPaymentOrdersService PaymentOrderService => new PaymentOrdersService(_httpClient){BaseUrl = BaseUrl};

    public IPaymentsService PaymentExecutionService => new PaymentsService(_httpClient){BaseUrl = BaseUrl};

    public IPaymentOrdersConfigurationService PaymentOrderConfigurationService =>
        new PaymentOrdersConfigurationService(_httpClient){BaseUrl = BaseUrl};

    public IRequestToPayPaymentsService RequestToPaymentService => new RequestToPayPaymentsService(_httpClient){BaseUrl = BaseUrl};
}
