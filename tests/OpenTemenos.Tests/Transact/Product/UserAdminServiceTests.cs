using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Product;

[TestClass]
[TestCategory("Transact")]
public class UserAdminServiceTests : CredentialManagement
{
    private const string ProductId = "CURRENT.ACCOUNT";
    private const string ProductLineId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetHomePurchaseCatalogAsync()
    {
        var result = _client.UserAdminService.GetProtectionLimitConditionsAsync(ProductId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetAvailabilityConditionsAsync()
    {
        var result = _client.UserAdminService.GetAvailabilityConditionsAsync(ProductId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetProductsByProductLineAsync()
    {
        var result = _client.UserAdminService.GetProductsByProductLineAsync(ProductLineId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPermissionConditionsAsync()
    {
        var result = _client.UserAdminService.GetPermissionConditionsAsync(ProductId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetLicensingConditionsAsync()
    {
        var result = _client.UserAdminService.GetLicensingConditionsAsync(ProductId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPrivilegeConditionsAsync()
    {
        var result = _client.UserAdminService.GetPrivilegeConditionsAsync(ProductId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}