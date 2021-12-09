using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.Receipts;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class ReceiptsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient){ ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostReceiptsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CashReceiptService.PostreceiptsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}