using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.OptionMaturity;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class OptionMaturityServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateOptionMaturityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OptionMaturityService.CreateOptionMaturityAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}