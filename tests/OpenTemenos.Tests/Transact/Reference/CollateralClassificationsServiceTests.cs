using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class CollateralClassificationsServiceTests : CredentialManagement
{
    private const string CollateralTypeId = "1";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetCollateralTypesAsync()
    {
        var result = _client.CollateralClassificationsService
            .GetCollateralTypesAsync(null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCollateralSubTypesAsync()
    {
        var result = _client.CollateralClassificationsService
            .GetCollateralSubTypesAsync(CollateralTypeId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}