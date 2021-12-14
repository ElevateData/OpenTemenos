using OpenTemenos.Payments.DirectDebit;
using OpenTemenos.Payments.PaymentOrders;
using OpenTemenos.Payments.PaymentOrdersConfigurations;
using OpenTemenos.Payments.Payments;
using OpenTemenos.Payments.PaymentStops;
using OpenTemenos.Payments.RequestToPayPayments;
using OpenTemenos.Payments.StandingOrders;
using OpenTemenos.Payments.TransactionStops;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.Payments;

public class PaymentClient : IPaymentClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

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
