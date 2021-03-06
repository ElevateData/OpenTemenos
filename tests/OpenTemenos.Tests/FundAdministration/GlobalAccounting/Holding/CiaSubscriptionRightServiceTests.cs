using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CiaSubscriptionRights;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class CiaSubscriptionRightServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateCapitalIncreaseWithAllotmentOfSubscriptionRightsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalIncreaseAllotmentSubscriptionRightService
            .CreateCapitalIncreaseWithAllotmentOfSubscriptionRightsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}