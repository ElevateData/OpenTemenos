using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class StockExchangeServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetStockExchangesAsync()
    {
        var result = _client.StockExchangeService.GetStockExchangesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}