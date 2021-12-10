using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.PikBond;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class PikBondServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreatePikBondAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.PikBondService.CreatePikBondAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}