using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass]
public class InterestCatalogServiceTests : CredentialManagement
{
    private const string RecordId = "";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetInterestCatalogAsync()
    {
        var result = _client.InterestCatalogService.GetInterestCatalogAsync(RecordId).Result;
        Assert.IsNotNull(result.Data);
    }
}