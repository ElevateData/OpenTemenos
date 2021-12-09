using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class SectorListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetSectorListAsync()
    {
        var result = _client.SectorService.GetSectorListAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}