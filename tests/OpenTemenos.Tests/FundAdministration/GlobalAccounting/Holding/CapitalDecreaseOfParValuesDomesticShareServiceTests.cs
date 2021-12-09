using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseOfParValuesDomesticShare;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class CapitalDecreaseOfParValuesDomesticShareServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalDecreaseOfParValueDomesticShareService
            .CreateCapitalDecreaseOfParValueDomesticWithCostAdjustmentAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}