using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class LookupsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetEbLookupsAsync()
    {
        var result = _client.LookupsService
            .GetEbLookupsAsync(null, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}