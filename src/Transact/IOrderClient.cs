using Transact.Order.AccountTransfers;
using Transact.Order.CashManagementSweeps;
using Transact.Order.CreditorReferences;
using Transact.Order.DerivativeOrders;
using Transact.Order.FiduciaryOrders;
using Transact.Order.ForexCustomerOrders;
using Transact.Order.IPOSecurityOrders;
using Transact.Order.OrderSimulations;
using Transact.Order.PaymentsConfigurations;
using Transact.Order.PositionTransferOrdersRequests;
using Transact.Order.PrivateEquityOrders;
using Transact.Order.SecurityOrders;
using Transact.Order.SecurityTransferOrders;
using Transact.Order.Sweeps;

namespace Transact;

public interface IOrderClient
{
    public IAccountTransferService AccountFundTransferService { get; }
    //public ICashManagementBundleService CashManagementBundleService { get; }
    public ICashManagementSweepService CashManagementSweepService { get; }
    public ICreditorReferenceService CreditorReferenceService { get; }
    public IDerivativeOrderService DerivativeInstrumentOrderService { get; }
    public IFiduciaryOrderService FiduciaryOrderService { get; }
    public IIPOSecurityOrderService InitialPublicOfferingSecurityOrderService { get; }
    public ISweepService AccountSweepService { get; }
    public IPrivateEquityOrderService PrivateEquityOrderService { get; }
    public IPaymentsConfigurationService PaymentConfigurationService { get; }
    public ISecurityOrderService SecurityOrderService { get; }
    public IOrderSimulationService SecurityOrderSimulationService { get; }
    public IPositionTransferOrdersRequestService SecurityPositionTransferService { get; }
    public ISecurityTransferOrderService SecurityTransferService { get; }
    public IForexCustomerOrderService TreasuryForexOrderService { get; }
    //public IUsPaymentService UsModelBankPaymentService { get; }


    //public IPaymentsConfigurationService PaymentsConfigurationService { get; }
}