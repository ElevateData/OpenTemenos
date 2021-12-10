using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.SecurityTransactionRebooking;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class SecurityTransactionRebookingServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void SecurityTransactionRebookingAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityTransactionRebookingService
            .SecurityTransactionRebookingAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}