using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class TradeDetailServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetSellOptionTradesAsync()
    {
        var result = _client.DerivativeInstrumentOperationService.GetSellOptionTradesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetBuyOptionTradesAsync()
    {
        var result = _client.DerivativeInstrumentOperationService.GetBuyOptionTradesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetActiveOptionTradesAsync()
    {
        var result = _client.DerivativeInstrumentOperationService.GetActiveOptionTradesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}