using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class DealersServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetDealersAsync()
    {
        var result = _client.DealersService.GetDealersAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}