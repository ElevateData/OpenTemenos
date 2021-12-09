using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsCountyServiceTests : CredentialManagement
{
    private const string StateId = "HI";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUsCountyListAsync()
    {
        var result = _client.UsCountyService.GetUsCountyListAsync(StateId, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}