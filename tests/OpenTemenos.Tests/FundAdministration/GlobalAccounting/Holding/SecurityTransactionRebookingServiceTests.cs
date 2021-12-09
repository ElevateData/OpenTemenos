using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.SecurityTransactionRebooking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class SecurityTransactionRebookingServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void SecurityTransactionRebookingAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityTransactionRebookingService.SecurityTransactionRebookingAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}