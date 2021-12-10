using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.ExchangeRate;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class ExchangeRateServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostExchangeRateAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeRateService.PostexchangerateAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}