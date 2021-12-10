using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class ProductBuilderDetailServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetPropertiesAsync()
    {
        var result = _client.ProductBuilderService.GetPropertiesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetProjectsAsync()
    {
        var result = _client.ProductBuilderService.GetProjectsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetProductConditionsAsync()
    {
        var result = _client.ProductBuilderService.GetProductConditionsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}