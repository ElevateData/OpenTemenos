using Transact;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class PaymentStopsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);
}