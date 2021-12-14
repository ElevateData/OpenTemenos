using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class OriginationRoleServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetOriginationRolesAsync()
    {
        var result = _client.OriginationRoleService.GetOriginationRolesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}