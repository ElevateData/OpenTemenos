using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.Receipts;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class ReceiptServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostReceiptsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CashReceiptService.PostreceiptsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}