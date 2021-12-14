using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class AAPurposeListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAccountTransactionMetricsAsync()
    {
        var result = _client.PurposeService.GetAAPurposeListAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}