using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsStateServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetUsStateListAsync()
    {
        var result = _client.UsStateService
            .GetUsStateListAsync(null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}