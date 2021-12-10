using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsHoldTypesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetHoldTypesAsync()
    {
        var result = _client.UsHoldTypesService.GetHoldTypesAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}