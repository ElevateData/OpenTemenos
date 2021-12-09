using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseOfParValuesWithRealizedGain;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class CapitalDecreaseOfParValuesWithRealizedGainServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    [Ignore("POST method")]
    public void CreateCapitalDecreaseOfParValueWithRealisedGainAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalDecreaseOfParValueDomesticSharesTaxablePayment
            .CreateCapitalDecreaseOfParValueWithRealisedGainAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}