using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.DividendRates;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class DividendRatesServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostDividendRatesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DividendRateService.PostDividendRatesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}