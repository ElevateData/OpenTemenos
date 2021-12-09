using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseOfParValuesForeignShare;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class CapitalDecreaseOfParValuesForeignShareServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    [Ignore("POST method")]
    public void CreateCapitalDecreaseOfParValueForeignWithCostAdjustmentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalDecreaseOfParValueForeignShareService
            .CreateCapitalDecreaseOfParValueForeignWithCostAdjustmentAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}