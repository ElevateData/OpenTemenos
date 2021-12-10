using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.SpinOffs;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class SpinOffServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateSpinOffAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SpinOffService.CreateSpinOffAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}