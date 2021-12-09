using Transact;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class PaymentOrdersServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);
}