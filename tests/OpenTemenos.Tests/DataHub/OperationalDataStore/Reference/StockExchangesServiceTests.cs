using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class StockExchangesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetStockExchangesAsync()
    {
        var result = _client.StockExchangeService.GetStockExchangesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}