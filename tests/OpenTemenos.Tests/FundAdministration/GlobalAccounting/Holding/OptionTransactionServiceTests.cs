using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.OptionTransaction;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class OptionTransactionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateOptionTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OptionTransactionService
            .CreateOptionTransactionAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}