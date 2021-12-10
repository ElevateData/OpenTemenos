using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseOfParValuesWithRealizedGains;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class CapitalDecreaseOfParValuesWithRealizedGainServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateCapitalDecreaseOfParValueWithRealisedGainAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalDecreaseOfParValueDomesticSharesTaxablePayment
            .CreateCapitalDecreaseOfParValueWithRealisedGainAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}