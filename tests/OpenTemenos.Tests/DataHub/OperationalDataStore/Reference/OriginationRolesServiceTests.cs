using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class OriginationRolesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetOriginationRolesAsync()
    {
        var result = _client.OriginationRoleService.GetOriginationRolesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}