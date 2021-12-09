using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.Announcements;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class AnnouncementsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod]
    [Ignore("POST method")]
    public void PostDividendPaymentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DividendPaymentService.PostDividendPaymentAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}