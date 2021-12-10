using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class AccountOfficerServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAccountOfficersAsync()
    {
        var result = _client.AccountOfficerService.GetAccountOfficersAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}