using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.SecurityPriceUpdates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class SecurityPriceUpdatesServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void PostSecurityPriceUpdatesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.MarketValueHistoricalService.PostsecuritypriceupdatesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}