using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.OptionExercise;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
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