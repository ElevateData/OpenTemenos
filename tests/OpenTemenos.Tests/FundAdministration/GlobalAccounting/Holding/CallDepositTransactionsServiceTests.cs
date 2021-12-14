using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CallDepositTransactions;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class CallDepositTransactionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CallDepositTransactionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CallDepositTransactionService
            .CallDepositTransactionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}