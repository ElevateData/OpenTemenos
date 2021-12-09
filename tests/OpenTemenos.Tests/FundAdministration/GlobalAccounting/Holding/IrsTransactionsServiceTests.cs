using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.IrsTransactions;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class IrsTransactionsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    [Ignore("POST method")]
    public void IrsTransactionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SwapService.IrsTransactionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}