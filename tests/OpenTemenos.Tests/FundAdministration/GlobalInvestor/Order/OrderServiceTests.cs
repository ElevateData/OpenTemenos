using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.Orders;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class OrderServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostOrdersAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OrderService.PostOrdersAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}