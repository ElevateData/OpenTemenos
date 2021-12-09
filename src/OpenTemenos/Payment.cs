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
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public Payment(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IDirectDebitsService DirectDebitManagementService => new DirectDebitsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentStopsService PaymentStopService => new PaymentStopsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IStandingOrdersService StandingOrderService => new StandingOrdersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITransactionStopService TransactionStopService => new TransactionStopService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentOrdersService PaymentOrderService => new PaymentOrdersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentsService PaymentExecutionService => new PaymentsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentOrdersConfigurationService PaymentOrderConfigurationService =>
        new PaymentOrdersConfigurationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRequestToPayPaymentsService RequestToPaymentService => new RequestToPayPaymentsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
