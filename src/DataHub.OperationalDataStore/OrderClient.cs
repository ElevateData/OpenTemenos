using OpenTemenos.DataHubs.OperationalDataStore.Order;
using OpenTemenos.DataHubs.OperationalDataStore.Order.AccountHoldDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Order.ForexOrderDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Order.FundsTransferDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Order.InvestigationItems;
using OpenTemenos.DataHubs.OperationalDataStore.Order.PaymentDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Order.RejectedCollections;
using OpenTemenos.DataHubs.OperationalDataStore.Order.SweepAccountDetails;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.DataHubs.OperationalDataStore;

public class OrderClient : IOrderClient
{
    private readonly HttpClient _httpClient;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public ISweepAccountDetailService AccountSweepService => new SweepAccountDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundsTransferDetailService FundsTransferDetailService =>
        new FundsTransferDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRejectedCollectionService OrderRejectedCollectionService =>
        new RejectedCollectionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentDetailService PaymentService => new PaymentDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IInvestigationItemService TransactionStopService => new InvestigationItemService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IForexOrderDetailService TreasuryForexOrderService => new ForexOrderDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAccountHoldDetailService UsModelBankCashTransactionService =>
        new AccountHoldDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}