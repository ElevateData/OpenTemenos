using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.FixedBond;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class FixedBondServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateFixedBondAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FixedBondService.CreateFixedBondAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}