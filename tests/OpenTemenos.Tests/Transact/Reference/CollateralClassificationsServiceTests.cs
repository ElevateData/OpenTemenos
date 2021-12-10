using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class CollateralClassificationServiceTests : CredentialManagement
{
    private const string CollateralTypeId = "1";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCollateralTypesAsync()
    {
        var result = _client.CollateralClassificationService
            .GetCollateralTypesAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCollateralSubTypesAsync()
    {
        var result = _client.CollateralClassificationService
            .GetCollateralSubTypesAsync(CollateralTypeId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}