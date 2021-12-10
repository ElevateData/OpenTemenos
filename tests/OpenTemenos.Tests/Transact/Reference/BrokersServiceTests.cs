using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class BrokerServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetBrokersAsync()
    {
        var result = _client.BrokerService.GetBrokersAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}