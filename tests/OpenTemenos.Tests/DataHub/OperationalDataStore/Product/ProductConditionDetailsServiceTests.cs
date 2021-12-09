using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass]
public class ProductConditionDetailsServiceTests : CredentialManagement
{
    private const string ProductId = "";
    private readonly IProductClient _client = new ProductClient(HttpClient);

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