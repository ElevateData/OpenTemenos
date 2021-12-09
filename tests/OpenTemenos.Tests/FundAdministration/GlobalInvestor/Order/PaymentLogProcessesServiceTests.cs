using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.PaymentLogProcesses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class PaymentLogProcessesServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void PostPaymentLogProcessesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.PaymentLogService.PostpaymentlogprocessesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}