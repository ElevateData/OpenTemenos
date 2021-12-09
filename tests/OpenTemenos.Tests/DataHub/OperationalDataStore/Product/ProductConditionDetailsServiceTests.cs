using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass]
public class ProductConditionDetailsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string ProductId = "";

    [TestMethod]
    public void GetProtectionLimitConditionsAsync()
    {
        var result = _client.ProductConditionService.GetProtectionLimitConditionsAsync(ProductId, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetAvailabilityConditionsAsync()
    {
        var result = _client.ProductConditionService.GetAvailabilityConditionsAsync(ProductId, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetLicensingConditionsAsync()
    {
        var result = _client.ProductConditionService.GetLicensingConditionsAsync(ProductId, null).Result;
        Assert.IsNotNull(result.Data);
    }
}