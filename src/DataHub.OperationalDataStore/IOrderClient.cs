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
    public ISweepAccountDetailService AccountSweepService { get; }
    public IFundsTransferDetailService FundsTransferDetailService { get; }
    public IRejectedCollectionService OrderRejectedCollectionService { get; }
    public IPaymentDetailService PaymentService { get; }
    public IInvestigationItemService TransactionStopService { get; }
    public IForexOrderDetailService TreasuryForexOrderService { get; }
    public IAccountHoldDetailService UsModelBankCashTransactionService { get; }
}
