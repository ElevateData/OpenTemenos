using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FloatOrRateFactors;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class FloatOrRateFactorServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateFloaterRateOrFactorAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FloatingRateOrFactorLoadService
            .CreateFloaterRateOrFactorAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}