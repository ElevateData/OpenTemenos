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
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAccountTransfersService AccountFundTransferService => new AccountTransfersService(_httpClient) { BaseUrl = BaseUrl };
    public ICashManagementSweepService CashManagementSweepService => new CashManagementSweepService(_httpClient) { BaseUrl = BaseUrl };
    public ICreditorReferencesService CreditorReferenceService => new CreditorReferencesService(_httpClient) { BaseUrl = BaseUrl };
    public IDerivativeOrdersService DerivativeInstrumentOrderService => new DerivativeOrdersService(_httpClient) { BaseUrl = BaseUrl };
    public IFiduciaryOrdersService FiduciaryOrderService => new FiduciaryOrdersService(_httpClient) { BaseUrl = BaseUrl };
    public IForexCustomerOrdersService TreasuryForexOrderService => new ForexCustomerOrdersService(_httpClient) { BaseUrl = BaseUrl };
    public IIPOSecurityOrdersService InitialPublicOfferingSecurityOrderService => new IPOSecurityOrdersService(_httpClient) { BaseUrl = BaseUrl };
    public IOrderSimulationsService SecurityOrderSimulationService => new OrderSimulationsService(_httpClient) { BaseUrl = BaseUrl };
    public IPaymentsService PaymentsService => new PaymentsService(_httpClient) { BaseUrl = BaseUrl };
    public IPositionTransferOrdersRequestService SecurityPositionTransferService => new PositionTransferOrdersRequestService(_httpClient) { BaseUrl = BaseUrl };
    public IPrivateEquityOrdersService PrivateEquityOrderService => new PrivateEquityOrdersService(_httpClient) { BaseUrl = BaseUrl };
    public ISecurityOrdersService SecurityOrderService => new SecurityOrdersService(_httpClient) { BaseUrl = BaseUrl };
    public ISecurityTransferOrdersService SecurityTransferService => new SecurityTransferOrdersService(_httpClient) { BaseUrl = BaseUrl };
    public ISweepsService AccountSweepService => new SweepsService(_httpClient) { BaseUrl = BaseUrl };
}
