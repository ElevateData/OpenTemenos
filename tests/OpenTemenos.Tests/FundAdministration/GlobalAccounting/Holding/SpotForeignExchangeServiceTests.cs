using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.SpotForeignExchanges;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class SpotForeignExchangeServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateSpotForeignExchangeAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SpotForeignExchangeService
            .CreateSpotForeignExchangeAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}