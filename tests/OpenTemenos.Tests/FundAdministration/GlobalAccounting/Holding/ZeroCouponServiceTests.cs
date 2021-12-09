using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.ZeroCoupon;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class ZeroCouponServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateZeroCouponAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ZeroCouponService.CreateZeroCouponAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}