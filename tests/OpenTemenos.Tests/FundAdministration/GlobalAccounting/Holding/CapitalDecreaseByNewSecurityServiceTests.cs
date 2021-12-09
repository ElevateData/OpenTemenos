using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseByNewSecurity;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class CapitalDecreaseByNewSecurityServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateCapitalDecreaseByNewSecurityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalDecreaseByNewSecurityService.CreateCapitalDecreaseByNewSecurityAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}