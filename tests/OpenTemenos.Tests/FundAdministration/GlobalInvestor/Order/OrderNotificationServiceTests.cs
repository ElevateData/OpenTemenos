using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.OrderNotification;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class OrderNotificationServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void PostOrderNotificationAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ErrorInterfaceService.PostordernotificationAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}