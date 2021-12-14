using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.PaymentLogProcesses;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class PaymentLogProcesseServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostPaymentLogProcessesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.PaymentLogService.PostpaymentlogprocessesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}