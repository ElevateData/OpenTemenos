using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.Navs;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class NavServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostSharePriceAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SharePriceService.PostSharePriceAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}