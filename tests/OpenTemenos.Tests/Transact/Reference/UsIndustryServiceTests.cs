using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsIndustryServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUsIndustryListAsync()
    {
        var result = _client.UsIndustryService.GetUsIndustrylistAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}