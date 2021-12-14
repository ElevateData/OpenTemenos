using OpenTemenos.DataHubs.OperationalDataStore.Order.AccountHoldDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Order.ForexOrderDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Order.FundsTransferDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Order.InvestigationItems;
using OpenTemenos.DataHubs.OperationalDataStore.Order.PaymentDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Order.RejectedCollections;
using OpenTemenos.DataHubs.OperationalDataStore.Order.SweepAccountDetails;

namespace OpenTemenos.DataHubs.OperationalDataStore;

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