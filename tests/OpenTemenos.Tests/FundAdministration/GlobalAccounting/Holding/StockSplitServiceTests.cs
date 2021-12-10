using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.StockSplits;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class StockSplitServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateStockSplitAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.StockSplitService.CreateStockSplitAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}