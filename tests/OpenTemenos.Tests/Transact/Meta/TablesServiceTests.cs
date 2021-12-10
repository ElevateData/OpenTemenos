using Transact;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass, TestCategory("Transact")]
public class TableServiceTests : CredentialManagement
{
    private const string TableId = "1";
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetFieldNamesAsync()
    {
        var result = _client.TableService.GetTablesAsync(TableId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetTablesAsync()
    {
        var result = _client.TableService.GetTablesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetTableScreensAsync()
    {
        var result = _client.TableService.GetTableScreensAsync(TableId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}