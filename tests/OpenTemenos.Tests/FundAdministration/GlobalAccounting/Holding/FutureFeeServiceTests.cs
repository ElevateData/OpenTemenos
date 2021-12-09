using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.FutureFee;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class FutureFeeServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateFutureFeeAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FutureFeeService.CreateFutureFeeAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}