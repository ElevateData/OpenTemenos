using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.FloatingVariableBond;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class FloatingVariableBondServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateFloatingOrVariableBondAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FloatingVariableRateBondService.CreateFloatingOrVariableBondAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}