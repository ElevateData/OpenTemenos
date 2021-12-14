using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class FdicDepositClassCodeListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetFdicDepositClassCodeListAsync()
    {
        var result = _client.UsModelBankFdicSubClassificationCodeService.GetFdicDepositClassCodeListAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}