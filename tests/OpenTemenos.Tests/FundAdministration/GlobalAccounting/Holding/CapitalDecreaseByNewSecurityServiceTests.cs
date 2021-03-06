using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseByNewSecurities;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class CapitalDecreaseByNewSecurityServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateCapitalDecreaseByNewSecurityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalDecreaseByNewSecurityService
            .CreateCapitalDecreaseByNewSecurityAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}