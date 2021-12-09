using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.StockDividend;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class StockDividendServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    [Ignore("POST method")]
    public void CreateStockDividendAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.StockDividendService.CreateStockDividendAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}