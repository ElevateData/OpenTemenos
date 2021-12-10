using DataHub.OperationalDataStore.Order;
using DataHub.OperationalDataStore.Order.AccountHoldDetails;
using DataHub.OperationalDataStore.Order.ForexOrderDetails;
using DataHub.OperationalDataStore.Order.FundsTransferDetails;
using DataHub.OperationalDataStore.Order.InvestigationItems;
using DataHub.OperationalDataStore.Order.PaymentDetails;
using DataHub.OperationalDataStore.Order.RejectedCollections;
using DataHub.OperationalDataStore.Order.SweepAccountDetails;

namespace DataHub.OperationalDataStore;

public class OrderClient : IOrderClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ISweepAccountDetailService AccountSweepService => new SweepAccountDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundsTransferDetailService FundsTransferDetailService =>
        new FundsTransferDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRejectedCollectionService OrderRejectedCollectionService =>
        new RejectedCollectionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentDetailService PaymentService => new PaymentDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IInvestigationItemService TransactionStopService => new InvestigationItemService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IForexOrderDetailService TreasuryForexOrderService => new ForexOrderDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAccountHoldDetailService UsModelBankCashTransactionService =>
        new AccountHoldDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
