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

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ISweepAccountDetailsService AccountSweepService => new SweepAccountDetailsService(_httpClient);

    public IFundsTransferDetailsService FundsTransferDetailService =>
        new FundsTransferDetailsService(_httpClient);

    public IRejectedCollectionsService OrderRejectedCollectionService =>
        new RejectedCollectionsService(_httpClient);

    public IPaymentDetailsService PaymentService => new PaymentDetailsService(_httpClient);
    public IInvestigationItemsService TransactionStopService => new InvestigationItemsService(_httpClient);
    public IForexOrderDetailsService TreasuryForexOrderService => new ForexOrderDetailsService(_httpClient);

    public IAccountHoldDetailsService UsModelBankCashTransactionService =>
        new AccountHoldDetailsService(_httpClient);
}
