using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ZeroCoupons;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class ZeroCouponServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateZeroCouponAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ZeroCouponService.CreateZeroCouponAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}