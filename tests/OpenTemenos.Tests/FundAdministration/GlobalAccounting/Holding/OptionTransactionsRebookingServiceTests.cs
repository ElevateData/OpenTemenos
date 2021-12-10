using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.OptionTransactionsRebooking;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class OptionTransactionsRebookingServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void OptionTransactionsRebookingAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OptionTransactionRebookingService
            .OptionTransactionsRebookingAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}