using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CouponDividendTransaction;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class CouponDividendTransactionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CouponDividendTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CouponDividendTransactionService
            .CouponDividendTransactionAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}