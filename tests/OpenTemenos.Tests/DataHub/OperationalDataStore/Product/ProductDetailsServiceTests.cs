using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class ProductDetailServiceTests : CredentialManagement
{
    private const string ProductLineId = "";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetProductGroupAsync()
    {
        var result = _client.ProductDetailService.GetProductGroupAsync(ProductLineId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetProductLineActivitiesAsync()
    {
        var result = _client.ProductDetailService.GetProductLineActivitiesAsync(ProductLineId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetProductLinesAsync()
    {
        var result = _client.ProductDetailService.GetProductLinesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetProductGroupsAsync()
    {
        var result = _client.ProductDetailService.GetProductGroupsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPropertyClassesAsync()
    {
        var result = _client.ProductDetailService.GetPropertyClassesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}