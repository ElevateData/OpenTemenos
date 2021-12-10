using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsIdDocumentsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUsIdDocListAsync()
    {
        var result = _client.UsIdDocumentsService.GetUsIdDoclistAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}