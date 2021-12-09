using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.FutureTransactionsRebooking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class FutureTransactionsRebookingServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void FutureTransactionsRebookingAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FutureTransactionRebookingService.FutureTransactionsRebookingAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}