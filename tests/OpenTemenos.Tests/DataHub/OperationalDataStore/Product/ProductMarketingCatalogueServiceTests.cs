using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass]
public class ProductMarketingCatalogueServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetProductMarketingCatalogueAsync()
    {
        var result = _client.ProductMarketingCatalogService.GetProductMarketingCatalogueAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}