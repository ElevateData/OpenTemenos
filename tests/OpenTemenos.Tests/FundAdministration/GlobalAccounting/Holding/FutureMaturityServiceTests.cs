using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FutureMaturities;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class FutureMaturityServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateFutureMaturityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FutureMaturityService.CreateFutureMaturityAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}