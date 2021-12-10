using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CapitalIIncreaseWithExerciseOfSubscriptionRights;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class CapitalIIncreaseWithExerciseOfSubscriptionRightsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateCapitalIncreaseWithExerciseOfSubscriptionRightAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalIIncreaseWithExerciseOfSubscriptionRightService
            .CreateCapitalIncreaseWithExerciseOfSubscriptionRightAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}