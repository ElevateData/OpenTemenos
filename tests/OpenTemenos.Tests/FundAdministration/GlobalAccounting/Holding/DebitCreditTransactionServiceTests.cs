using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Holding.DebitCreditTransaction;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class DebitCreditTransactionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void DebitCreditTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DebitCreditTransactionService
            .DebitCreditTransactionAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}