using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.FundShareTransactions;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class FundShareTransactionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void FundShareTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ShareholderService.FundSharetransactionAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}