using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.FloatOrRateFactor;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class FloatOrRateFactorServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateFloaterRateOrFactorAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FloatingRateOrFactorLoadService
            .CreateFloaterRateOrFactorAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}