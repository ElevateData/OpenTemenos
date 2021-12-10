using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.TermDepositTransaction;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class TermDepositTransactionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void TermDepositTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TimeTermDepositService.TermDepositTransactionAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}