using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Holding.OptionExercise;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class OptionExerciseServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateOptionExerciseAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OptionExerciseService.CreateOptionExerciseAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}