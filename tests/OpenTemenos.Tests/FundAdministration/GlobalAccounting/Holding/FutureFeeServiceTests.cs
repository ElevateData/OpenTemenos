using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FutureFees;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class FutureFeeServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateFutureFeeAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FutureFeeService.CreateFutureFeeAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}