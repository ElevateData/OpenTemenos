using Transact.Order;
using Transact.Order.AccountTransfers;
using Transact.Order.CashManagementSweep;
using Transact.Order.CreditorReferences;
using Transact.Order.DerivativeOrders;
using Transact.Order.FiduciaryOrders;
using Transact.Order.ForexCustomerOrders;
using Transact.Order.IPOSecurityOrders;
using Transact.Order.OrderSimulations;
using Transact.Order.PaymentsConfiguration;
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
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAccountTransfersService AccountFundTransferService => new AccountTransfersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICashManagementSweepService CashManagementSweepService => new CashManagementSweepService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICreditorReferencesService CreditorReferenceService => new CreditorReferencesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDerivativeOrdersService DerivativeInstrumentOrderService => new DerivativeOrdersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFiduciaryOrdersService FiduciaryOrderService => new FiduciaryOrdersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IForexCustomerOrdersService TreasuryForexOrderService => new ForexCustomerOrdersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IIPOSecurityOrdersService InitialPublicOfferingSecurityOrderService => new IPOSecurityOrdersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOrderSimulationsService SecurityOrderSimulationService => new OrderSimulationsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPositionTransferOrdersRequestService SecurityPositionTransferService => new PositionTransferOrdersRequestService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPrivateEquityOrdersService PrivateEquityOrderService => new PrivateEquityOrdersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPaymentsConfigurationService PaymentConfigurationService => new PaymentsConfigurationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecurityOrdersService SecurityOrderService => new SecurityOrdersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecurityTransferOrdersService SecurityTransferService => new SecurityTransferOrdersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISweepsService AccountSweepService => new SweepsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
