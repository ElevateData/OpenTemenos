using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.FutureMaturity;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class FutureMaturityServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateFutureMaturityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FutureMaturityService.CreateFutureMaturityAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}