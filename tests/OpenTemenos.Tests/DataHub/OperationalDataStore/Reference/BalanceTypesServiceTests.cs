using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class BalanceTypesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetBalanceTypesAsync()
    {
        var result = _client.BalanceTypeService.GetBalanceTypesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}