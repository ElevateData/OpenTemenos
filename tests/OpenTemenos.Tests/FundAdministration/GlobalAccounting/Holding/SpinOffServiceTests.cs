using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Holding.SpinOff;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class SpinOffServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateSpinOffAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SpinOffService.CreateSpinOffAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}