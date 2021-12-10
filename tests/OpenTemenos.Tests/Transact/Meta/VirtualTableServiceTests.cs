using Transact;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class VirtualTableServiceTests : CredentialManagement
{
    private const string VirtualTableName = "1099C";
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetVirtualTableDataAsync()
    {
        var result = _client.VirtualTableService.GetVirtualTableDataAsync(VirtualTableName)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}