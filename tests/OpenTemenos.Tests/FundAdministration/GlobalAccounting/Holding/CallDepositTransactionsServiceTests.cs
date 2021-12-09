using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CallDepositTransactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class CallDepositTransactionsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CallDepositTransactionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CallDepositTransactionService.CallDepositTransactionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}