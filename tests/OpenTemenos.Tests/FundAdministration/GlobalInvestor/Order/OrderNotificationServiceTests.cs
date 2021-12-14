using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.OrderNotifications;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class OrderNotificationServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostOrderNotificationAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ErrorInterfaceService.PostordernotificationAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}