using Transact;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class OrderSimulationsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient){ ReadResponseAsString = true };
}