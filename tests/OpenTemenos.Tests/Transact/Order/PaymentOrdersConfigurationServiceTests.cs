using Transact;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class PaymentOrdersConfigurationServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);
}