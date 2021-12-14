using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.TradingDeskRates;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class TradingDeskRateServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostTradingDeskRatesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TradingDeskValidationService
            .PosttradingdeskratesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}