using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class UsCovenantListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUsCovenantListAsync()
    {
        var result = _client.UsModelBankLoanCovenantService.GetUsCovenantListAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}