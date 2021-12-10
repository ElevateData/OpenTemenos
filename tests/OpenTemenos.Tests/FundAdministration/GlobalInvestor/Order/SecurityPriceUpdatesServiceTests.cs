using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.SecurityPriceUpdates;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class SecurityPriceUpdatesServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostSecurityPriceUpdatesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.MarketValueHistoricalService
            .PostsecuritypriceupdatesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}