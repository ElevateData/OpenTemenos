using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
[TestCategory("Transact")]
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
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}