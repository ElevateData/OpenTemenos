using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.FutureTransactionsRebookings;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class FutureTransactionsRebookingServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void FutureTransactionsRebookingAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FutureTransactionRebookingService
            .FutureTransactionsRebookingAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}