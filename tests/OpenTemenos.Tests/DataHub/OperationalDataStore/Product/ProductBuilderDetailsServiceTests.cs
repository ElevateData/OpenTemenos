using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass]
public class ProductBuilderDetailsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);


    [TestMethod]
    public void GetPropertiesAsync()
    {
        var result = _client.ProductBuilderService.GetPropertiesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetProjectsAsync()
    {
        var result = _client.ProductBuilderService.GetProjectsAsync(null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetProductConditionsAsync()
    {
        var result = _client.ProductBuilderService.GetProductConditionsAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}