using DataHub.OperationalDataStore.Order.AccountHoldDetails;
using DataHub.OperationalDataStore.Order.ForexOrderDetails;
using DataHub.OperationalDataStore.Order.FundsTransferDetails;
using DataHub.OperationalDataStore.Order.InvestigationItems;
using DataHub.OperationalDataStore.Order.PaymentDetails;
using DataHub.OperationalDataStore.Order.RejectedCollections;
using DataHub.OperationalDataStore.Order.SweepAccountDetails;

namespace DataHub.OperationalDataStore;

public interface IOrderClient
{
    public ISweepAccountDetailsService AccountSweepService { get; }
    public IFundsTransferDetailsService FundsTransferDetailService { get; }
    public IRejectedCollectionsService OrderRejectedCollectionService { get; }
    public IPaymentDetailsService PaymentService { get; }
    public IInvestigationItemsService TransactionStopService { get; }
    public IForexOrderDetailsService TreasuryForexOrderService { get; }
    public IAccountHoldDetailsService UsModelBankCashTransactionService { get; }
}
