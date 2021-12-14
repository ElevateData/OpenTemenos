using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class BalanceTypeServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetBalanceTypesAsync()
    {
        var result = _client.BalanceTypeService.GetBalanceTypesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}