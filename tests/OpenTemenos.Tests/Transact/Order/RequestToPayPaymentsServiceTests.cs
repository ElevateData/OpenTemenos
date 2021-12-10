using Transact;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class RequestToPayPaymentsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };
}