using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsCovenantServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUsCovenantListAsync()
    {
        var result = _client.UsCovenantService.GetUsCovenantListAsync(null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}