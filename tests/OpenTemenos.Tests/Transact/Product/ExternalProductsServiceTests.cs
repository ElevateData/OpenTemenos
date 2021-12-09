using Transact;

namespace OpenTemenos.Tests.Transact.Product;

[TestClass]
public class ExternalProductsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient){ ReadResponseAsString = true };
}