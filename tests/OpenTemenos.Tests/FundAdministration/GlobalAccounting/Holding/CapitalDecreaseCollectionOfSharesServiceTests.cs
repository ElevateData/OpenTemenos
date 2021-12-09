using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseCollectionOfShares;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class CapitalDecreaseCollectionOfSharesServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateCapitalDecreaseByNewSecurityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalDecreaseCollectionOfShareService.CreateCapitalDecreaseCollectionOfShareAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}