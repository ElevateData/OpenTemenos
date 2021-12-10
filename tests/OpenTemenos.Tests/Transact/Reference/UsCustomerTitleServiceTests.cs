using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsCustomerTitleServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUsCustomerTitlesAsync()
    {
        var result = _client.UsCustomerTitleService.GetUsCustomerTitlesAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}