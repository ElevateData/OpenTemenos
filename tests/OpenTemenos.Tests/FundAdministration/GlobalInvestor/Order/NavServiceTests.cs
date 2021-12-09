using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.Nav;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class NavServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void PostSharePriceAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SharePriceService.PostSharePriceAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}