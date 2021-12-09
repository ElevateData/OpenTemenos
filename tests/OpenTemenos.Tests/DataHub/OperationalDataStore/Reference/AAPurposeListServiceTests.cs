using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class AAPurposeListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetAccountTransactionMetricsAsync()
    {
        var result = _client.PurposeService.GetAAPurposeListAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}