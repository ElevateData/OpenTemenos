using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.PaymentAmendments;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class PaymentAmendmentsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostPaymentAmendmentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.PaymentAmendmentService.PostpaymentamendmentsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}