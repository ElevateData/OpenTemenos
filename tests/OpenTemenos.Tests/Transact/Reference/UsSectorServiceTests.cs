using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsSectorServiceTests : CredentialManagement
{
    private const string CustomerType = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUsSectorListAsync()
    {
        var result = _client.UsSectorService.GetUsSectorlistAsync(CustomerType, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}