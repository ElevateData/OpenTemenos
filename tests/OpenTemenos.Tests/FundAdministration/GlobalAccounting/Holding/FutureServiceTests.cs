using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.Future;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class FutureServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateFutureAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FutureService.CreateFutureAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}