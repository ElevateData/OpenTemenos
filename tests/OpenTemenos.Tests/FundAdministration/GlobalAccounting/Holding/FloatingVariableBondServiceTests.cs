using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FloatingVariableBonds;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class FloatingVariableBondServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateFloatingOrVariableBondAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FloatingVariableRateBondService
            .CreateFloatingOrVariableBondAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}