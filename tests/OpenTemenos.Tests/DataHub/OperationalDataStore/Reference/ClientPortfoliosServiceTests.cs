using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class ClientPortfolioServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetClientPortfoliosAsync()
    {
        var result = _client.OwnBookPortfolioService.GetClientPortfoliosAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}