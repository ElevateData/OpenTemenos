using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class UsCovenantListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUsCovenantListAsync()
    {
        var result = _client.UsModelBankLoanCovenantService.GetUsCovenantListAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}