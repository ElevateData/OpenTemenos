using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class SectorListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetSectorListAsync()
    {
        var result = _client.SectorService.GetSectorListAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}