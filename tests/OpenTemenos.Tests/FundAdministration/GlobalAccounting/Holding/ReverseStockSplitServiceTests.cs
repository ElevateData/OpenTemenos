using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ReverseStockSplits;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class ReverseStockSplitServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void GetReverseStockSplitAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ReverseStockSplitService.GetReverseStockSplitAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}