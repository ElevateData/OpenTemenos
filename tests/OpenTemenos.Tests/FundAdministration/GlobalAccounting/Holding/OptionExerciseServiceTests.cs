using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.OptionExercises;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class OptionExerciseServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateOptionExerciseAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OptionExerciseService.CreateOptionExerciseAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}