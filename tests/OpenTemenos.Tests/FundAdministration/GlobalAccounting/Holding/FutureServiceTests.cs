using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.Futures;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class FutureServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateFutureAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FutureService.CreateFutureAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}