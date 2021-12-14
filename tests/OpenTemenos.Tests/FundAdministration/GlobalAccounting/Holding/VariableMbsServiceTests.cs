using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.VariableMbs;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class VariableMbServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateVariableMbsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.VariableMortgageBackedSecurityService
            .CreateVariableMbsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}