using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.VariableMbs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class VariableMbsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateVariableMbsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.VariableMortgageBackedSecurityService.CreateVariableMbsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}