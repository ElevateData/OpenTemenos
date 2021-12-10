using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class AccountOfficersServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAccountOfficersAsync()
    {
        var result = _client.AccountOfficerService.GetAccountOfficersAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}