using Transact;

namespace OpenTemenos.Tests.Transact.Product;

[TestClass]
public class CustomersServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient){ ReadResponseAsString = true };
}