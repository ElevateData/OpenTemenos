using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class ProductMarketingCatalogueServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetProductMarketingCatalogueAsync()
    {
        var result = _client.ProductMarketingCatalogService.GetProductMarketingCatalogueAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}