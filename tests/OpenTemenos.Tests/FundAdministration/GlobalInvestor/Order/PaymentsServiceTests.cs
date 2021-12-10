using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.Payments;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class PaymentsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostPaymentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.PaymentService.PostpaymentsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}