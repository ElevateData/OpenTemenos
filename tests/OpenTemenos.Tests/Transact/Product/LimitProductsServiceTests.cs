using Transact;

namespace OpenTemenos.Tests.Transact.Product;

[TestClass]
public class LimitProductsServiceTests : CredentialManagement
{
    private const string LimitProductId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetExternalDepositProductAsync()
    {
        var result = _client.LimitProductsService.GetLimitProductAsync(LimitProductId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}