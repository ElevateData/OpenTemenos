using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CapitalIncreaseWithoutIssueOfSubscriptionRights;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class CapitalIncreaseWithoutIssueOfSubscriptionRightServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateCapitalIncreaseWithoutIssueOfSubscriptionRightAsync()
    {
        var payload = new _0Payload();
        var result = _client.CapitalIncreaseWithoutIssueOfSubscriptionRightService
            .CreateCapitalIncreaseWithoutIssueOfSubscriptionRightAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}