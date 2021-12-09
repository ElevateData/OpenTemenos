using Transact;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class TransactionStopServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);
}