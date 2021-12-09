using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.StockSplit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class StockSplitServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateStockSplitAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.StockSplitService.CreateStockSplitAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}