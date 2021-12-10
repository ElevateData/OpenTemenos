using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class DealersServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetDealersAsync()
    {
        var result = _client.DealersService.GetDealersAsync(null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}