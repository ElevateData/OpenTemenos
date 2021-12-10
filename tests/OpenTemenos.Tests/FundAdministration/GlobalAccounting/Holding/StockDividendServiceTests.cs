using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.StockDividends;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class StockDividendServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateStockDividendAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.StockDividendService.CreateStockDividendAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}