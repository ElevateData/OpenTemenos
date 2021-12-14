using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.OptionMaturities;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class OptionMaturityServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateOptionMaturityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OptionMaturityService.CreateOptionMaturityAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}