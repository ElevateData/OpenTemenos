using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseOfParValuesDomesticShares;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class CapitalDecreaseOfParValuesDomesticShareServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalDecreaseOfParValueDomesticShareService
            .CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}