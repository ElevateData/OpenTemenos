using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CashDividendAnnouncement;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
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