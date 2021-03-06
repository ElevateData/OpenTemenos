using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class UsStateServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUsStateListAsync()
    {
        var result = _client.UsStateService
            .GetUsStateListAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}