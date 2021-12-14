using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.SecurityPriceUpdates;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class SecurityPriceUpdateServiceTests : CredentialManagement
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