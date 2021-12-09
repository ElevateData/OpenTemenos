using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class ClientPortfoliosServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetClientPortfoliosAsync()
    {
        var result = _client.OwnBookPortfolioService.GetClientPortfoliosAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}