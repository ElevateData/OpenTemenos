using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.OrderCancelReverse;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class OrderCancelReverseServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostOrderCancelReverseAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OrderCancellationService.PostordercancelreverseAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}