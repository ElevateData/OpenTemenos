using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass]
public class ProductDetailsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string ProductLineId = "";

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
        var result = _client.ProductDetailService.GetPropertyClassesAsync(null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}