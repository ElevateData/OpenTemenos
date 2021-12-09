using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.PikBond;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class PikBondServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreatePikBondAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.PikBondService.CreatePikBondAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}