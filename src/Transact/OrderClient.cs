using Transact.Order;
using Transact.Order.AccountTransfers;
using Transact.Order.CashManagementSweep;
using Transact.Order.CreditorReferences;
using Transact.Order.DerivativeOrders;
using Transact.Order.FiduciaryOrders;
using Transact.Order.ForexCustomerOrders;
using Transact.Order.IPOSecurityOrders;
using Transact.Order.OrderSimulations;
using Transact.Order.Payments;
using Transact.Order.PositionTransferOrdersRequest;
using Transact.Order.PrivateEquityOrders;
using Transact.Order.SecurityOrders;
using Transact.Order.SecurityTransferOrders;
using Transact.Order.Sweeps;

namespace Transact;

public class OrderClient : IOrderClient
{
    private readonly HttpClient _httpClient;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAccountTransfersService AccountFundTransferService => new AccountTransfersService(_httpClient);
    public ICashManagementSweepService CashManagementSweepService => new CashManagementSweepService(_httpClient);
    public ICreditorReferencesService CreditorReferenceService => new CreditorReferencesService(_httpClient);
    public IDerivativeOrdersService DerivativeInstrumentOrderService => new DerivativeOrdersService(_httpClient);
    public IFiduciaryOrdersService FiduciaryOrderService => new FiduciaryOrdersService(_httpClient);
    public IForexCustomerOrdersService TreasuryForexOrderService => new ForexCustomerOrdersService(_httpClient);
    public IIPOSecurityOrdersService InitialPublicOfferingSecurityOrderService => new IPOSecurityOrdersService(_httpClient);
    public IOrderSimulationsService SecurityOrderSimulationService => new OrderSimulationsService(_httpClient);
    public IPaymentsService PaymentsService => new PaymentsService(_httpClient);
    public IPositionTransferOrdersRequestService SecurityPositionTransferService => new PositionTransferOrdersRequestService(_httpClient);
    public IPrivateEquityOrdersService PrivateEquityOrderService => new PrivateEquityOrdersService(_httpClient);
    public ISecurityOrdersService SecurityOrderService => new SecurityOrdersService(_httpClient);
    public ISecurityTransferOrdersService SecurityTransferService => new SecurityTransferOrdersService(_httpClient);
    public ISweepsService AccountSweepService => new SweepsService(_httpClient);
}
