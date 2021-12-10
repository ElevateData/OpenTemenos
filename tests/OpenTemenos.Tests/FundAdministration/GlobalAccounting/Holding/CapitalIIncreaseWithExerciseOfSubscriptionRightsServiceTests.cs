using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CapitalIIncreaseWithExerciseOfSubscriptionRights;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class CapitalIIncreaseWithExerciseOfSubscriptionRightServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateCapitalIncreaseWithExerciseOfSubscriptionRightAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalIIncreaseWithExerciseOfSubscriptionRightService
            .CreateCapitalIncreaseWithExerciseOfSubscriptionRightAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}