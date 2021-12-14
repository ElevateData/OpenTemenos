using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.PaymentAmendments;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class PaymentAmendmentServiceTests : CredentialManagement
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