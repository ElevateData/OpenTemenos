using FundAdministration.GlobalInvestor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalInvestor.Order.Order;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class OrderServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void PostOrdersAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OrderService.PostOrdersAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}