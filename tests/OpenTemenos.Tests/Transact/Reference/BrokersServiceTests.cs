using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class BrokersServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetBrokersAsync()
    {
        var result = _client.BrokersService.GetBrokersAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}