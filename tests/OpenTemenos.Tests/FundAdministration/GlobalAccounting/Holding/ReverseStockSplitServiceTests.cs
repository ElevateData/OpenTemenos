using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Holding.ReverseStockSplit;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class ReverseStockSplitServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void GetReverseStockSplitAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ReverseStockSplitService.GetReverseStockSplitAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}