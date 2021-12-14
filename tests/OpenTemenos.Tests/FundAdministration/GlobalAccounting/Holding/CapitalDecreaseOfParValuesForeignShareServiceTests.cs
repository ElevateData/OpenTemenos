using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CapitalDecreaseOfParValuesForeignShares;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class CapitalDecreaseOfParValuesForeignShareServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateCapitalDecreaseOfParValueForeignWithCostAdjustmentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalDecreaseOfParValueForeignShareService
            .CreateCapitalDecreaseOfParValueForeignWithCostAdjustmentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}