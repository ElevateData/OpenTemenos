using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsBenOwnerTypesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUsBeneficialOwnerTypesAsync()
    {
        var result = _client.UsBenOwnerTypesService.GetUsBeneficialOwnerTypesAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}