using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class FdicDepositClassCodeListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetFdicDepositClassCodeListAsync()
    {
        var result = _client.UsModelBankFdicSubClassificationCodeService.GetFdicDepositClassCodeListAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}