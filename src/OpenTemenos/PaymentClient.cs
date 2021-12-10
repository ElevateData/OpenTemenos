using Payment;
using Payment.DirectDebitsX;
using Payment.PaymentOrders;
using Payment.PaymentOrdersConfiguration;
using Payment.Payments;
using Payment.PaymentStops;
using Payment.RequestToPayPayments;
using Payment.StandingOrders;
using Payment.TransactionStopX;

namespace OpenTemenos;

public class PaymentClient : IPaymentClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public PaymentClient(HttpClient httpClient)
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
