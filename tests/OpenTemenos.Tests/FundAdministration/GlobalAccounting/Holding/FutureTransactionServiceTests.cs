using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.FutureTransaction;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class FutureTransactionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateFutureTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FutureTransactionService
            .CreateFutureTransactionAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}