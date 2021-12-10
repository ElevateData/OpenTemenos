using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class ClientPortfoliosServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetClientPortfoliosAsync()
    {
        var result = _client.OwnBookPortfolioService.GetClientPortfoliosAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}