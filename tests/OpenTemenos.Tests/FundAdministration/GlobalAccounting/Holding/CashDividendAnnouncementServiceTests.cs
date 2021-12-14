using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CashDividendAnnouncements;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class CashDividendAnnouncementServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateCashDividendAnnouncementAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CashDividendAnnouncementService
            .CreateCashDividendAnnouncementAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}