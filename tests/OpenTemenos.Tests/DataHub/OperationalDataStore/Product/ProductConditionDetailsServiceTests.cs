using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass]
public class ProductConditionDetailsServiceTests : CredentialManagement
{
    private const string ProductId = "";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetProtectionLimitConditionsAsync()
    {
        var result = _client.ProductConditionService.GetProtectionLimitConditionsAsync(ProductId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetAvailabilityConditionsAsync()
    {
        var result = _client.ProductConditionService.GetAvailabilityConditionsAsync(ProductId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetLicensingConditionsAsync()
    {
        var result = _client.ProductConditionService.GetLicensingConditionsAsync(ProductId).Result;
        Assert.IsNotNull(result.Data);
    }
}