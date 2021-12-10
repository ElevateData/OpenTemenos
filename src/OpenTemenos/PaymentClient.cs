using Payment;
using Payment.DirectDebit;
using Payment.PaymentOrders;
using Payment.PaymentOrdersConfigurations;
using Payment.Payments;
using Payment.PaymentStops;
using Payment.RequestToPayPayments;
using Payment.StandingOrders;
using Payment.TransactionStops;

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

    public IDirectDebitService DirectDebitManagementService => new DirectDebitService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentStopService PaymentStopService => new PaymentStopService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IStandingOrderService StandingOrderService => new StandingOrderService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITransactionStopService TransactionStopService => new TransactionStopService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentOrderService PaymentOrderService => new PaymentOrderService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentService PaymentExecutionService => new PaymentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentOrdersConfigurationService PaymentOrderConfigurationService =>
        new PaymentOrdersConfigurationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRequestToPayPaymentService RequestToPaymentService => new RequestToPayPaymentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
