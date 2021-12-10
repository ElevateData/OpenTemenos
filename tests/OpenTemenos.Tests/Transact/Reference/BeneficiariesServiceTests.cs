using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class BeneficiariesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUtilityBeneficiariesAsync()
    {
        var result = _client.BeneficiariesService.GetUtilityBeneficiariesAsync(null, null, null, null, null, null, null,
            null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}