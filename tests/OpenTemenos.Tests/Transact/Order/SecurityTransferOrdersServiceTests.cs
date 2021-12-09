using Transact;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class SecurityTransferOrdersServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);
}