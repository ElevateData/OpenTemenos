using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsIdDocumentsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUsIdDocListAsync()
    {
        var result = _client.UsIdDocumentsService.GetUsIdDoclistAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}