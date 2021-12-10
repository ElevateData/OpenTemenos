using Transact;
using Transact.Meta.DwExportProperties;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass, TestCategory("Transact")]
public class DwExportPropertyServiceTests : CredentialManagement
{
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateDWExportPropertiesAsync()
    {
        var dataWarehouseExportId = string.Empty;
        var payload = new DWExportProperties();
        var result = _client.DwExportPropertyService.UpdateDWExportPropertiesAsync(dataWarehouseExportId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetDWExportPropertiesAsync()
    {
        var result = _client.DwExportPropertyService.GetDWExportPropertiesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}