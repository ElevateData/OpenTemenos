using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.DebitCreditTransaction;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class DebitCreditTransactionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void DebitCreditTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DebitCreditTransactionService
            .DebitCreditTransactionAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}