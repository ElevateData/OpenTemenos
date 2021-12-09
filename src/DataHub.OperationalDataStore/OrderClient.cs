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

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ISweepAccountDetailsService AccountSweepService => new SweepAccountDetailsService(_httpClient) { BaseUrl = BaseUrl };

    public IFundsTransferDetailsService FundsTransferDetailService =>
        new FundsTransferDetailsService(_httpClient) { BaseUrl = BaseUrl };

    public IRejectedCollectionsService OrderRejectedCollectionService =>
        new RejectedCollectionsService(_httpClient) { BaseUrl = BaseUrl };

    public IPaymentDetailsService PaymentService => new PaymentDetailsService(_httpClient) { BaseUrl = BaseUrl };
    public IInvestigationItemsService TransactionStopService => new InvestigationItemsService(_httpClient) { BaseUrl = BaseUrl };
    public IForexOrderDetailsService TreasuryForexOrderService => new ForexOrderDetailsService(_httpClient) { BaseUrl = BaseUrl };

    public IAccountHoldDetailsService UsModelBankCashTransactionService =>
        new AccountHoldDetailsService(_httpClient) { BaseUrl = BaseUrl };
}
